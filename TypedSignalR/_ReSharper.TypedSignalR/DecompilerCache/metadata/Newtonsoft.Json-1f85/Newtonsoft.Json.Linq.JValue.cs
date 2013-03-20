// Type: Newtonsoft.Json.Linq.JValue
// Assembly: Newtonsoft.Json, Version=4.5.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\Resources\Newtonsoft.Json.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Linq
{
    public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>
    {
        private object _value;
        private JTokenType _valueType;
        internal JValue(object value, JTokenType type);
        public JValue(JValue other);
        public JValue(long value);
        public JValue(char value);

        [CLSCompliant(false)]
        public JValue(ulong value);

        public JValue(double value);
        public JValue(float value);
        public JValue(DateTime value);
        public JValue(bool value);
        public JValue(string value);
        public JValue(Guid value);
        public JValue(Uri value);
        public JValue(TimeSpan value);
        public JValue(object value);
        public override bool HasValues { get; }
        public override JTokenType Type { get; }
        public object Value { get; set; }

        #region IComparable Members

        int IComparable.CompareTo(object obj);

        #endregion

        #region IComparable<JValue> Members

        public int CompareTo(JValue obj);

        #endregion

        #region IEquatable<JValue> Members

        public bool Equals(JValue other);

        #endregion

        #region IFormattable Members

        public string ToString(string format, IFormatProvider formatProvider);

        #endregion

        internal override bool DeepEquals(JToken node);
        private static int Compare(JTokenType valueType, object objA, object objB);
        private static int CompareFloat(object objA, object objB);
        private static bool Operation(ExpressionType operation, object objA, object objB, out object result);
        internal override JToken CloneToken();
        public static JValue CreateComment(string value);
        public static JValue CreateString(string value);
        private static JTokenType GetValueType(JTokenType? current, object value);
        private static JTokenType GetStringValueType(JTokenType? current);
        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters);
        internal override int GetDeepHashCode();
        private static bool ValuesEquals(JValue v1, JValue v2);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider formatProvider);
        protected override DynamicMetaObject GetMetaObject(Expression parameter);

        #region Nested type: JValueDynamicProxy

        private class JValueDynamicProxy : DynamicProxy<JValue>
        {
            public override bool TryConvert(JValue instance, ConvertBinder binder, out object result);

            public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg,
                                                    out object result);
        }

        #endregion
    }
}
