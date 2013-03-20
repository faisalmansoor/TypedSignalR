// Type: System.Convert
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{
    /// <summary>
    /// Converts a base data type to another base data type.
    /// 
    /// </summary>
    /// <filterpriority>1</filterpriority>
    [__DynamicallyInvokable]
    public static class Convert
    {
        private const int base64LineBreakPosition = 76;
        internal static readonly RuntimeType[] ConvertTypes;
        private static readonly RuntimeType EnumType;
        internal static readonly char[] base64Table;

        /// <summary>
        /// A constant representing a database column absent of data; that is, database null.
        /// 
        /// </summary>
        /// <filterpriority>1</filterpriority>
        public static readonly object DBNull;

        static Convert();

        /// <summary>
        /// Returns the <see cref="T:System.TypeCode"/> for the specified object.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.TypeCode"/> for <paramref name="value"/>, or <see cref="F:System.TypeCode.Empty"/> if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><filterpriority>1</filterpriority>
        public static TypeCode GetTypeCode(object value);

        /// <summary>
        /// Returns an indication whether the specified object is of type <see cref="T:System.DBNull"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is of type <see cref="T:System.DBNull"/>; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">An object.
        ///                 </param><filterpriority>1</filterpriority>
        public static bool IsDBNull(object value);

        /// <summary>
        /// Returns an <see cref="T:System.Object"/> with the specified <see cref="T:System.TypeCode"/> and whose value is equivalent to the specified object.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An object whose underlying <see cref="T:System.TypeCode"/> is <paramref name="typeCode"/> and whose value is equivalent to <paramref name="value"/>.
        /// 
        ///                     -or-
        ///                 null, if <paramref name="value"/> equals null and <paramref name="typeCode"/> equals <see cref="F:System.TypeCode.Empty"/>, <see cref="F:System.TypeCode.String"/>, or <see cref="F:System.TypeCode.Object"/>.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="typeCode">A <see cref="T:System.TypeCode"/></param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is null and <paramref name="typeCode"/> specifies a value type.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="typeCode"/> is invalid.
        ///                 </exception><filterpriority>1</filterpriority>
        public static object ChangeType(object value, TypeCode typeCode);

        /// <summary>
        /// Returns an <see cref="T:System.Object"/> with the specified <see cref="T:System.TypeCode"/> and whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An object whose underlying <see cref="T:System.TypeCode"/> is <paramref name="typeCode"/> and whose value is equivalent to <paramref name="value"/>.
        /// 
        ///                     -or-
        ///                 null, if <paramref name="value"/> equals null and <paramref name="typeCode"/> equals <see cref="F:System.TypeCode.Empty"/>, <see cref="F:System.TypeCode.String"/>, or <see cref="F:System.TypeCode.Object"/>.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="typeCode">A <see cref="T:System.TypeCode"/>.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is null and <paramref name="typeCode"/> specifies a value type.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="typeCode"/> is invalid.
        ///                 </exception><filterpriority>1</filterpriority>
        public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider);

        internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider);

        /// <summary>
        /// Returns an <see cref="T:System.Object"/> with the specified <see cref="T:System.Type"/> and whose value is equivalent to the specified object.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An object whose <see cref="T:System.Type"/> is <paramref name="conversionType"/> and whose value is equivalent to <paramref name="value"/>.
        /// 
        ///                     -or-
        ///                 null, if <paramref name="value"/> is null and <paramref name="conversionType"/> is not a value type.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="conversionType">A <see cref="T:System.Type"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is null and <paramref name="conversionType"/> is a value type.
        ///                 </exception><exception cref="T:System.ArgumentNullException"><paramref name="conversionType"/> is null.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static object ChangeType(object value, Type conversionType);

        /// <summary>
        /// Returns an <see cref="T:System.Object"/> with the specified <see cref="T:System.Type"/> and whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An object whose <see cref="T:System.Type"/> is <paramref name="conversionType"/> and whose value is equivalent to <paramref name="value"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, if the <see cref="T:System.Type"/> of <paramref name="value"/> and <paramref name="conversionType"/> are equal.
        /// 
        ///                     -or-
        ///                 null, if <paramref name="value"/> is null and <paramref name="conversionType"/> is not a value type.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="conversionType">A <see cref="T:System.Type"/>.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is null and <paramref name="conversionType"/> is a value type.
        ///                 </exception><exception cref="T:System.ArgumentNullException"><paramref name="conversionType"/> is null.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static object ChangeType(object value, Type conversionType, IFormatProvider provider);

        /// <summary>
        /// Converts the value of a specified <see cref="T:System.Object"/> to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true or false, which reflects the value returned by invoking the <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)"/> method for the underlying type of <paramref name="value"/>. If <paramref name="value"/> is null, the method returns false.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an equivalent Boolean value using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true or false, which reflects the value returned by invoking the <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)"/> method for the underlying type of <paramref name="value"/>. If <paramref name="value"/> is null, the method returns false.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement the <see cref="T:System.IConvertible"/> interface.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(object value, IFormatProvider provider);

        /// <summary>
        /// Returns the specified Boolean value; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A Boolean.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(bool value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static bool ToBoolean(sbyte value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static bool ToBoolean(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static bool ToBoolean(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static bool ToBoolean(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static bool ToBoolean(ulong value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a logical value to its Boolean equivalent.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> equals <see cref="F:System.Boolean.TrueString"/>, or false if <paramref name="value"/> equals <see cref="F:System.Boolean.FalseString"/> or null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> that contains the value of either <see cref="F:System.Boolean.TrueString"/> or <see cref="F:System.Boolean.FalseString"/>.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not equal to <see cref="F:System.Boolean.TrueString"/> or <see cref="F:System.Boolean.FalseString"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a logical value to its Boolean equivalent using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> equals <see cref="F:System.Boolean.TrueString"/>, or false if <paramref name="value"/> equals <see cref="F:System.Boolean.FalseString"/> or null.
        /// 
        /// </returns>
        /// <param name="value">A string that contains the value of either <see cref="F:System.Boolean.TrueString"/> or <see cref="F:System.Boolean.FalseString"/>.
        ///                 </param><param name="provider">(Reserved) An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not equal to <see cref="F:System.Boolean.TrueString"/> or <see cref="F:System.Boolean.FalseString"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(string value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent Boolean value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool ToBoolean(decimal value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static bool ToBoolean(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        ///                 <see cref="F:System.Char.MinValue"/> if <paramref name="value"/> equals null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement the <see cref="T:System.IConvertible"/> interface.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static char ToChar(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to its equivalent Unicode character using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        ///                 <see cref="F:System.Char.MinValue"/> if <paramref name="value"/> equals null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement the <see cref="T:System.IConvertible"/> interface.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static char ToChar(object value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Boolean"/> value.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static char ToChar(bool value);

        /// <summary>
        /// Returns the specified Unicode character value; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>1</filterpriority>
        public static char ToChar(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Char.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static char ToChar(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static char ToChar(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Char.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static char ToChar(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static char ToChar(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Char.MinValue"/> or greater than <see cref="F:System.Char.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static char ToChar(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Char.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static char ToChar(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Char.MinValue"/> or greater than <see cref="F:System.Char.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static char ToChar(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to its equivalent Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Char.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static char ToChar(ulong value);

        /// <summary>
        /// Converts the first character of a <see cref="T:System.String"/> to a Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the first and only character in <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> of length 1 or null.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="value"/> is null.
        ///                 </exception><exception cref="T:System.FormatException">The length of <paramref name="value"/> is not 1.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static char ToChar(string value);

        /// <summary>
        /// Converts the first character of a <see cref="T:System.String"/> to a Unicode character using specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Unicode character equivalent to the first and only character in <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> of length 1 or null.
        ///                 </param><param name="provider">(Reserved) An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="value"/> is null.
        ///                 </exception><exception cref="T:System.FormatException">The length of <paramref name="value"/> is not 1.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static char ToChar(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating-point number.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static char ToChar(float value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating-point number.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static char ToChar(double value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static char ToChar(decimal value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static char ToChar(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an 8-bit signed integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(bool value);

        /// <summary>
        /// Returns the specified 8-bit signed integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(sbyte value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to the equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 8-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 8-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 8-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.SByte.MaxValue"/> or less than <see cref="F:System.SByte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if value is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.SByte.MinValue"/> or greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 8-bit signed integer using specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="value"/> is null.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.SByte.MinValue"/> or greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static sbyte ToSByte(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an 8-bit unsigned integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(bool value);

        /// <summary>
        /// Returns the specified 8-bit unsigned integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(byte value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit unsigned integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Byte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static byte ToByte(sbyte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static byte ToByte(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static byte ToByte(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static byte ToByte(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 8-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Byte.MaxValue"/> or less than <see cref="F:System.Byte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 8-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Byte.MaxValue"/> or less than <see cref="F:System.Byte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 8-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Byte.MaxValue"/> or less than <see cref="F:System.Byte.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 8-bit signed integer using specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static byte ToByte(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 16-bit signed integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(bool value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit signed integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static short ToInt16(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static short ToInt16(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit signed integer equivalent of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/> or less than <see cref="F:System.Int16.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static short ToInt16(uint value);

        /// <summary>
        /// Returns the specified 16-bit signed integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(short value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/> or less than <see cref="F:System.Int16.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static short ToInt16(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 16-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/> or less than <see cref="F:System.Int16.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 16-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/> or less than <see cref="F:System.Int16.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 16-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int16.MaxValue"/> or less than <see cref="F:System.Int16.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 16-bit signed integer using specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static short ToInt16(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 16-bit unsigned integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(bool value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit unsigned integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to the equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(short value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 16-bit unsigned integer equivalent of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(int value);

        /// <summary>
        /// Returns the specified 16-bit unsigned integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 16-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 16-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 16-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 16-bit unsigned integer using specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static ushort ToUInt16(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 32-bit signed integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(bool value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit signed integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static int ToInt32(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static int ToInt32(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static int ToInt32(uint value);

        /// <summary>
        /// Returns the specified 32-bit signed integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(int value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int32.MaxValue"/> or less than <see cref="F:System.Int32.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static int ToInt32(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 32-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int32.MaxValue"/> or less than <see cref="F:System.Int32.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 32-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int32.MaxValue"/> or less than <see cref="F:System.Int32.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 32-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int32.MaxValue"/> or less than <see cref="F:System.Int32.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static int ToInt32(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int32.MinValue"/> or greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 32-bit signed integer using specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int32.MinValue"/> or greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static int ToInt32(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 32-bit unsigned integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(bool value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit unsigned integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to the equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 32-bit unsigned integer equivalent of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(int value);

        /// <summary>
        /// Returns the specified 32-bit unsigned integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 32-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 32-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 32-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int32.MinValue"/> or greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 32-bit unsigned integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int32.MinValue"/> or greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static uint ToUInt32(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 64-bit signed integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(bool value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit signed integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static long ToInt64(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static long ToInt64(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static long ToInt64(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static long ToInt64(ulong value);

        /// <summary>
        /// Returns the specified 64-bit signed integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(long value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 64-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int64.MaxValue"/> or less than <see cref="F:System.Int64.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 64-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int64.MaxValue"/> or less than <see cref="F:System.Int64.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 64-bit signed integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Int64.MaxValue"/> or less than <see cref="F:System.Int64.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int64.MinValue"/> or greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 64-bit signed integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int64.MinValue"/> or greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static long ToInt64(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a 64-bit unsigned integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit unsigned integer equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(bool value);

        /// <summary>
        /// Converts the value of the specified Unicode character to the equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit unsigned integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(char value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to the equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit unsigned integer equivalent of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 64-bit unsigned integer equivalent of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(long value);

        /// <summary>
        /// Returns the specified 64-bit unsigned integer; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 64-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 64-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// <paramref name="value"/> rounded to the nearest 64-bit unsigned integer. If <paramref name="value"/> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than zero or greater than <see cref="F:System.UInt64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int64.MinValue"/> or greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent 64-bit unsigned integer using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> does not consist of an optional sign followed by a sequence of digits (zero through nine).
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Int64.MinValue"/> or greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static ulong ToUInt64(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an single-precision floating point number using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static float ToSingle(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(byte value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static float ToSingle(char value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static float ToSingle(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static float ToSingle(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static float ToSingle(ulong value);

        /// <summary>
        /// Returns the specified single-precision floating point number; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        ///                 <paramref name="value"/> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        ///                 <paramref name="value"/> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a number in a valid format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Single.MinValue"/> or greater than <see cref="F:System.Single.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent single-precision floating point number using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a number in a valid format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Single.MinValue"/> or greater than <see cref="F:System.Single.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(string value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent single-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static float ToSingle(bool value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static float ToSingle(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an double-precision floating point number using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static double ToDouble(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(byte value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(short value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static double ToDouble(char value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static double ToDouble(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static double ToDouble(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static double ToDouble(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(float value);

        /// <summary>
        /// Returns the specified double-precision floating point number; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(double value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(decimal value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a number in a valid format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Double.MinValue"/> or greater than <see cref="F:System.Double.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent double-precision floating point number using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating point number equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a number in a valid format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Double.MinValue"/> or greater than <see cref="F:System.Double.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(string value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent double-precision floating point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static double ToDouble(bool value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static double ToDouble(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to an <see cref="T:System.Decimal"/> number using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>, or zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to the equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The 8-bit signed integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static decimal ToDecimal(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to the equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(byte value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static decimal ToDecimal(char value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to an equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to the equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static decimal ToDecimal(ushort value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to an equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to an equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static decimal ToDecimal(uint value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to an equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to an equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static decimal ToDecimal(ulong value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to the equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Decimal.MaxValue"/> or less than <see cref="F:System.Decimal.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(float value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to an equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><exception cref="T:System.OverflowException">The numeric value of <paramref name="value"/> is greater than <see cref="F:System.Decimal.MaxValue"/> or less than <see cref="F:System.Decimal.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(double value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a number in a valid format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent <see cref="T:System.Decimal"/> number using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> number equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a number in a valid format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/> represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(string value, IFormatProvider provider);

        /// <summary>
        /// Returns the specified <see cref="T:System.Decimal"/> number; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(decimal value);

        /// <summary>
        /// Converts the value of the specified Boolean value to the equivalent <see cref="T:System.Decimal"/> number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number 1 if <paramref name="value"/> is true; otherwise, 0.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal ToDecimal(bool value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static decimal ToDecimal(DateTime value);

        /// <summary>
        /// Returns the specified <see cref="T:System.DateTime"/>; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a <see cref="T:System.DateTime"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.DateTime"/> equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     A <see cref="T:System.DateTime"/> equivalent to <see cref="F:System.DateTime.MinValue"/> if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface or null.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a valid <see cref="T:System.DateTime"/> value.
        ///                 </exception><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        /// 
        ///                     -or-
        /// 
        ///                     The conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static DateTime ToDateTime(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to a <see cref="T:System.DateTime"/> using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.DateTime"/> equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     A <see cref="T:System.DateTime"/> equivalent to <see cref="F:System.DateTime.MinValue"/> if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> that implements the <see cref="T:System.IConvertible"/> interface.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.InvalidCastException"><paramref name="value"/> does not implement <see cref="T:System.IConvertible"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static DateTime ToDateTime(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a date and time to an equivalent <see cref="T:System.DateTime"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.DateTime"/> equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     A <see cref="T:System.DateTime"/> equivalent to <see cref="F:System.DateTime.MinValue"/> if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">The string representation of a date and time.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a properly formatted date and time string.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static DateTime ToDateTime(string value);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/> representation of a number to an equivalent <see cref="T:System.DateTime"/> using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.DateTime"/> equivalent to the value of <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     A <see cref="T:System.DateTime"/> equivalent to <see cref="F:System.DateTime.MinValue"/> if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a date and time to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="value"/> is not a properly formatted date and time string.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static DateTime ToDateTime(string value, IFormatProvider provider);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static DateTime ToDateTime(sbyte value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(byte value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(short value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static DateTime ToDateTime(ushort value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(int value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static DateTime ToDateTime(uint value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(long value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        public static DateTime ToDateTime(ulong value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(bool value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(char value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point value.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(float value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point value.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(double value);

        /// <summary>
        /// Calling this method always throws <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> value.
        ///                 </param><exception cref="T:System.InvalidCastException">This conversion is not supported.
        ///                 </exception><filterpriority>1</filterpriority>
        public static DateTime ToDateTime(decimal value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to its <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation of the value of <paramref name="value"/>, or <see cref="F:System.String.Empty"/> if value is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> or null.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static string ToString(object value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Object"/> to its equivalent <see cref="T:System.String"/> representation using the specified culture-specific formatting information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation of the value of <paramref name="value"/>, or <see cref="F:System.String.Empty"/> if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> or null.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(object value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Boolean to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(bool value);

        /// <summary>
        /// Converts the value of the specified Boolean to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Boolean value.
        ///                 </param><param name="provider">(Reserved) An instance of an <see cref="T:System.IFormatProvider"/> interface implementation.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(bool value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified Unicode character to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(char value);

        /// <summary>
        /// Converts the value of the specified Unicode character to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(char value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(sbyte value);

        /// <summary>
        /// Converts the value of the specified 8-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(sbyte value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(byte value);

        /// <summary>
        /// Converts the value of the specified 8-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(byte value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(short value);

        /// <summary>
        /// Converts the value of the specified 16-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(short value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(ushort value);

        /// <summary>
        /// Converts the value of the specified 16-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(ushort value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(int value);

        /// <summary>
        /// Converts the value of the specified 32-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(int value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(uint value);

        /// <summary>
        /// Converts the value of the specified 32-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(uint value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(long value);

        /// <summary>
        /// Converts the value of the specified 64-bit signed integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(long value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(ulong value);

        /// <summary>
        /// Converts the value of the specified 64-bit unsigned integer to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static string ToString(ulong value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(float value);

        /// <summary>
        /// Converts the value of the specified single-precision floating point number to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating point number.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(float value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(double value);

        /// <summary>
        /// Converts the value of the specified double-precision floating point number to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        ///                 <paramref name="provider"/> is ignored; it does not participate in this operation.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating point number.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(double value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(decimal value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> number to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> number.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(decimal value, IFormatProvider provider);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.DateTime"/> to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(DateTime value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.DateTime"/> to its equivalent <see cref="T:System.String"/> representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> equivalent of the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.DateTime"/>.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToString(DateTime value, IFormatProvider provider);

        /// <summary>
        /// Returns the specified instance of <see cref="T:System.String"/>; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/>.
        ///                 </param><filterpriority>1</filterpriority>
        public static string ToString(string value);

        /// <summary>
        /// Returns the specified instance of <see cref="T:System.String"/>; no actual conversion is performed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Parameter <paramref name="value"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/>.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        public static string ToString(string value, IFormatProvider provider);

        /// <summary>
        /// Converts the string representation of a number in a specified base to an equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 unsigned number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a base 10 unsigned number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.Byte.MinValue"/> or larger than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(string value, int fromBase);

        /// <summary>
        /// Converts the string representation of a number in a specified base to an equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A string containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.SByte.MinValue"/> or larger than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(string value, int fromBase);

        /// <summary>
        /// Converts the string representation of a number in a specified base to an equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A string containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.Int16.MinValue"/> or larger than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(string value, int fromBase);

        /// <summary>
        /// Converts the string representation of a number in a specified base to an equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A string containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 unsigned number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a non-base 10 unsigned number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.UInt16.MinValue"/> or larger than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(string value, int fromBase);

        /// <summary>
        /// Converts the <see cref="T:System.String"/> representation of a number in a specified base to an equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.String"/> containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.Int32.MinValue"/> or larger than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int ToInt32(string value, int fromBase);

        /// <summary>
        /// Converts the string representation of a number in a specified base to an equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A string containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 unsigned number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a non-base 10 unsigned number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.UInt32.MinValue"/> or larger than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(string value, int fromBase);

        /// <summary>
        /// Converts the string representation of a number in a specified base to an equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A string containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a non-base 10 signed number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.Int64.MinValue"/> or larger than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static long ToInt64(string value, int fromBase);

        /// <summary>
        /// Converts the string representation of a number in a specified base to an equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit unsigned integer equivalent to the number in <paramref name="value"/>.
        /// 
        ///                     -or-
        /// 
        ///                     Zero if <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">A string containing a number.
        ///                 </param><param name="fromBase">The base of the number in <paramref name="value"/>, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="fromBase"/> is not 2, 8, 10, or 16.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/>, which represents a non-base 10 unsigned number, is prefixed with a negative sign.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="value"/> contains a character that is not a valid digit in the base specified by <paramref name="fromBase"/>. The exception message indicates that there are no digits to convert if the first character in <paramref name="value"/> is invalid; otherwise, the message indicates that <paramref name="value"/> contains invalid trailing characters.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="value"/>, which represents a non-base 10 unsigned number, is prefixed with a negative sign.
        /// 
        ///                     -or-
        /// 
        ///                     The return value is less than <see cref="F:System.UInt64.MinValue"/> or larger than <see cref="F:System.UInt64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(string value, int fromBase);

        /// <summary>
        /// Converts the value of an 8-bit unsigned integer to its equivalent string representation in a specified base.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The string representation of <paramref name="value"/> in base <paramref name="toBase"/>.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><param name="toBase">The base of the return value, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="toBase"/> is not 2, 8, 10, or 16.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static string ToString(byte value, int toBase);

        /// <summary>
        /// Converts the value of a 16-bit signed integer to its equivalent <see cref="T:System.String"/> representation in a specified base.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation of <paramref name="value"/> in base <paramref name="toBase"/>.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><param name="toBase">The base of the return value, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="toBase"/> is not 2, 8, 10, or 16.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static string ToString(short value, int toBase);

        /// <summary>
        /// Converts the value of a 32-bit signed integer to its equivalent <see cref="T:System.String"/> representation in a specified base.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation of <paramref name="value"/> in base <paramref name="toBase"/>.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><param name="toBase">The base of the return value, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="toBase"/> is not 2, 8, 10, or 16.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static string ToString(int value, int toBase);

        /// <summary>
        /// Converts the value of a 64-bit signed integer to its equivalent <see cref="T:System.String"/> representation in a specified base.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation of <paramref name="value"/> in base <paramref name="toBase"/>.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><param name="toBase">The base of the return value, which must be 2, 8, 10, or 16.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="toBase"/> is not 2, 8, 10, or 16.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static string ToString(long value, int toBase);

        /// <summary>
        /// Converts an array of 8-bit unsigned integers to its equivalent <see cref="T:System.String"/> representation encoded with base 64 digits.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation, in base 64, of the contents of <paramref name="inArray"/>.
        /// 
        /// </returns>
        /// <param name="inArray">An array of 8-bit unsigned integers.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="inArray"/> is null.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static string ToBase64String(byte[] inArray);

        /// <summary>
        /// Converts an array of 8-bit unsigned integers to its equivalent <see cref="T:System.String"/> representation encoded with base 64 digits. A parameter specifies whether to insert line breaks in the return value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation in base 64 of the elements in <paramref name="inArray"/>.
        /// 
        /// </returns>
        /// <param name="inArray">An array of 8-bit unsigned integers.
        ///                 </param><param name="options"><see cref="F:System.Base64FormattingOptions.InsertLineBreaks"/> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None"/> to not insert line breaks.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="inArray"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="options"/> is not a valid <see cref="T:System.Base64FormattingOptions"/> value.
        ///                 </exception><filterpriority>1</filterpriority>
        [ComVisible(false)]
        public static string ToBase64String(byte[] inArray, Base64FormattingOptions options);

        /// <summary>
        /// Converts a subset of an array of 8-bit unsigned integers to its equivalent <see cref="T:System.String"/> representation encoded with base 64 digits. Parameters specify the subset as an offset in the input array, and the number of elements in the array to convert.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation in base 64 of <paramref name="length"/> elements of <paramref name="inArray"/> starting at position <paramref name="offset"/>.
        /// 
        /// </returns>
        /// <param name="inArray">An array of 8-bit unsigned integers.
        ///                 </param><param name="offset">An offset in <paramref name="inArray"/>.
        ///                 </param><param name="length">The number of elements of <paramref name="inArray"/> to convert.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="inArray"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> or <paramref name="length"/> is negative.
        /// 
        ///                     -or-
        ///                 <paramref name="offset"/> plus <paramref name="length"/> is greater than the length of <paramref name="inArray"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static string ToBase64String(byte[] inArray, int offset, int length);

        /// <summary>
        /// Converts a subset of an array of 8-bit unsigned integers to its equivalent <see cref="T:System.String"/> representation encoded with base 64 digits. Parameters specify the subset as an offset in the input array, the number of elements in the array to convert, and whether to insert line breaks in the return value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.String"/> representation in base 64 of <paramref name="length"/> elements of <paramref name="inArray"/> starting at position <paramref name="offset"/>.
        /// 
        /// </returns>
        /// <param name="inArray">An array of 8-bit unsigned integers.
        ///                 </param><param name="offset">An offset in <paramref name="inArray"/>.
        ///                 </param><param name="length">The number of elements of <paramref name="inArray"/> to convert.
        ///                 </param><param name="options"><see cref="F:System.Base64FormattingOptions.InsertLineBreaks"/> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None"/> to not insert line breaks.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="inArray"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> or <paramref name="length"/> is negative.
        /// 
        ///                     -or-
        ///                 <paramref name="offset"/> plus <paramref name="length"/> is greater than the length of <paramref name="inArray"/>.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="options"/> is not a valid <see cref="T:System.Base64FormattingOptions"/> value.
        ///                 </exception><filterpriority>1</filterpriority>
        [ComVisible(false)]
        [SecuritySafeCritical]
        public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options);

        /// <summary>
        /// Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base 64 digits. Parameters specify the subsets as offsets in the input and output arrays, and the number of elements in the input array to convert.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer containing the number of bytes in <paramref name="outArray"/>.
        /// 
        /// </returns>
        /// <param name="inArray">An input array of 8-bit unsigned integers.
        ///                 </param><param name="offsetIn">A position within <paramref name="inArray"/>.
        ///                 </param><param name="length">The number of elements of <paramref name="inArray"/> to convert.
        ///                 </param><param name="outArray">An output array of Unicode characters.
        ///                 </param><param name="offsetOut">A position within <paramref name="outArray"/>.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="inArray"/> or <paramref name="outArray"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offsetIn"/>, <paramref name="offsetOut"/>, or <paramref name="length"/> is negative.
        /// 
        ///                     -or-
        ///                 <paramref name="offsetIn"/> plus <paramref name="length"/> is greater than the length of <paramref name="inArray"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="offsetOut"/> plus the number of elements to return is greater than the length of <paramref name="outArray"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut);

        /// <summary>
        /// Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base 64 digits. Parameters specify the subsets as offsets in the input and output arrays, the number of elements in the input array to convert, and whether line breaks are inserted in the output array.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer containing the number of bytes in <paramref name="outArray"/>.
        /// 
        /// </returns>
        /// <param name="inArray">An input array of 8-bit unsigned integers.
        ///                 </param><param name="offsetIn">A position within <paramref name="inArray"/>.
        ///                 </param><param name="length">The number of elements of <paramref name="inArray"/> to convert.
        ///                 </param><param name="outArray">An output array of Unicode characters.
        ///                 </param><param name="offsetOut">A position within <paramref name="outArray"/>.
        ///                 </param><param name="options"><see cref="F:System.Base64FormattingOptions.InsertLineBreaks"/> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None"/> to not insert line breaks.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="inArray"/> or <paramref name="outArray"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offsetIn"/>, <paramref name="offsetOut"/>, or <paramref name="length"/> is negative.
        /// 
        ///                     -or-
        ///                 <paramref name="offsetIn"/> plus <paramref name="length"/> is greater than the length of <paramref name="inArray"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="offsetOut"/> plus the number of elements to return is greater than the length of <paramref name="outArray"/>.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="options"/> is not a valid <see cref="T:System.Base64FormattingOptions"/> value.
        ///                 </exception><filterpriority>1</filterpriority>
        [ComVisible(false)]
        [SecuritySafeCritical]
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut,
                                            Base64FormattingOptions options);

        /// <summary>
        /// Converts the specified <see cref="T:System.String"/>, which encodes binary data as base 64 digits, to an equivalent 8-bit unsigned integer array.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An array of 8-bit unsigned integers equivalent to <paramref name="s"/>.
        /// 
        /// </returns>
        /// <param name="s">A <see cref="T:System.String"/>.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null.
        ///                 </exception><exception cref="T:System.FormatException">The length of <paramref name="s"/>, ignoring white space characters, is not zero or a multiple of 4.
        /// 
        ///                     -or-
        /// 
        ///                     The format of <paramref name="s"/> is invalid. <paramref name="s"/> contains a non-base 64 character, more than two padding characters, or a non-white space character among the padding characters.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static byte[] FromBase64String(string s);

        /// <summary>
        /// Converts a subset of a Unicode character array, which encodes binary data as base 64 digits, to an equivalent 8-bit unsigned integer array. Parameters specify the subset in the input array and the number of elements to convert.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An array of 8-bit unsigned integers equivalent to <paramref name="length"/> elements at position <paramref name="offset"/> in <paramref name="inArray"/>.
        /// 
        /// </returns>
        /// <param name="inArray">A Unicode character array.
        ///                 </param><param name="offset">A position within <paramref name="inArray"/>.
        ///                 </param><param name="length">The number of elements in <paramref name="inArray"/> to convert.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="inArray"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> or <paramref name="length"/> is less than 0.
        /// 
        ///                     -or-
        ///                 <paramref name="offset"/> plus <paramref name="length"/> indicates a position not within <paramref name="inArray"/>.
        ///                 </exception><exception cref="T:System.FormatException">The length of <paramref name="inArray"/>, ignoring white space characters, is not zero or a multiple of 4.
        /// 
        ///                     -or-
        /// 
        ///                     The format of <paramref name="inArray"/> is invalid. <paramref name="inArray"/> contains a non-base 64 character, more than two padding characters, or a non-white space character among the padding characters.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static byte[] FromBase64CharArray(char[] inArray, int offset, int length);

        [SecurityCritical]
        private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length,
                                                bool insertLineBreaks);

        private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks);

        [SecurityCritical]
        private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength);

        [SecurityCritical]
        private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength);

        [SecurityCritical]
        private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength);
    }
}
