using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;

namespace TypedSignalR
{
    public class Util
    {
        /// <summary>
        /// Formats string with named variables. E.g.
        /// 
        /// var student = new
        /// {
        ///   Name = "John",
        ///   Email = "john@roffle.edu",
        ///   BirthDate = new DateTime(1983, 3, 20),
        ///   Results = new[] 
        ///   {
        ///       new { Name = "COMP101", Grade = 10 },
        ///       new { Name = "ECON101", Grade = 9 }
        ///   }
        /// };
        /// 
        /// StringUtil.FormatNamed("Top result for {Name} was {Results[0].Name}", student);
        /// </summary>
        public static string FormatNamed(string format, object source)
        {
            return FormatNamed(format, null, source);
        }

        /// <summary>
        /// Formats string with named variables. E.g.
        /// 
        /// var student = new
        /// {
        ///   Name = "John",
        ///   Email = "john@roffle.edu",
        ///   BirthDate = new DateTime(1983, 3, 20),
        ///   Results = new[] 
        ///   {
        ///       new { Name = "COMP101", Grade = 10 },
        ///       new { Name = "ECON101", Grade = 9 }
        ///   }
        /// };
        /// 
        /// StringUtil.FormatNamed("Top result for {Name} was {Results[0].Name}", student);
        /// </summary>
        public static string FormatNamed(string format, IFormatProvider provider, object source)
        {
            if (format == null)
                throw new ArgumentNullException("format");

            var values = new List<object>();

            // Create the format string required by String.Format methos having {0} instead of {PlaceHolder}
            // The regex description
            // <start> = { 
            // <property> = alpha numeric including charactes .[] 
            // <format> = starting with : any character other than } 
            // <end> = }
            string rewrittenFormat = Regex.Replace(format,
              @"(?<start>\{)+(?<property>[\w\.\[\]]+)(?<format>:[^}]+)?(?<end>\})+",
              delegate(Match m) //This delegate will be called for every matched goup in the named format string
              {
                  Group startGroup = m.Groups["start"];
                  Group propertyGroup = m.Groups["property"];
                  Group formatGroup = m.Groups["format"];
                  Group endGroup = m.Groups["end"];

                  values.Add((propertyGroup.Value == "0") // If we didn't named but provided a number instead for format 
                    ? source                              // use the source
                    : Eval(source, propertyGroup.Value)); // otherwise evluation the property chain using the source object

                  int openings = startGroup.Captures.Count;
                  int closings = endGroup.Captures.Count;

                  return openings > closings || openings % 2 == 0 // This is fail safe, for properly formated formats openinigns == cosings == 1
                     ? m.Value
                     : new string('{', openings) + (values.Count - 1)
                       + formatGroup.Value
                       + new string('}', closings);
              },
              RegexOptions.Compiled
              | RegexOptions.CultureInvariant
              | RegexOptions.IgnoreCase);

            return string.Format(provider, rewrittenFormat, values.ToArray());
        }

        private static object Eval(object source, string expression)
        {
            try
            {
                return DataBinder.Eval(source, expression);
            }
            catch (HttpException e)
            {
                throw new FormatException(null, e);
            }
        }
    }
}
