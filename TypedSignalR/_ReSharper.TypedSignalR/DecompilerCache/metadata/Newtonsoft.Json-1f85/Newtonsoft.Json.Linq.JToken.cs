// Type: Newtonsoft.Json.Linq.JToken
// Assembly: Newtonsoft.Json, Version=4.5.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\Resources\Newtonsoft.Json.dll

using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Linq
{
    public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable,
                                   IDynamicMetaObjectProvider
    {
        private static JTokenEqualityComparer _equalityComparer;
        private static readonly JTokenType[] BooleanTypes;
        private static readonly JTokenType[] NumberTypes;
        private static readonly JTokenType[] StringTypes;
        private static readonly JTokenType[] GuidTypes;
        private static readonly JTokenType[] TimeSpanTypes;
        private static readonly JTokenType[] UriTypes;
        private static readonly JTokenType[] CharTypes;
        private static readonly JTokenType[] DateTimeTypes;
        private static readonly JTokenType[] BytesTypes;
        private int? _lineNumber;
        private int? _linePosition;
        private JToken _next;
        private JContainer _parent;
        private JToken _previous;
        static JToken();
        internal JToken();
        public static JTokenEqualityComparer EqualityComparer { get; }

        public JContainer Parent { [DebuggerStepThrough]
        get; internal set; }

        public JToken Root { get; }
        public abstract JTokenType Type { get; }
        public abstract bool HasValues { get; }
        public JToken Next { get; internal set; }
        public JToken Previous { get; internal set; }
        public virtual JToken this[object key] { get; set; }
        public virtual JToken First { get; }
        public virtual JToken Last { get; }

        #region ICloneable Members

        object ICloneable.Clone();

        #endregion

        #region IDynamicMetaObjectProvider Members

        DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter);

        #endregion

        #region IJEnumerable<JToken> Members

        IEnumerator IEnumerable.GetEnumerator();
        IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator();
        IJEnumerable<JToken> IJEnumerable<JToken>.this[object key] { get; }

        #endregion

        #region IJsonLineInfo Members

        bool IJsonLineInfo.HasLineInfo();
        int IJsonLineInfo.LineNumber { get; }
        int IJsonLineInfo.LinePosition { get; }

        #endregion

        public static explicit operator bool(JToken value);
        public static explicit operator DateTimeOffset(JToken value);
        public static explicit operator bool?(JToken value);
        public static explicit operator long(JToken value);
        public static explicit operator DateTime?(JToken value);
        public static explicit operator DateTimeOffset?(JToken value);
        public static explicit operator decimal?(JToken value);
        public static explicit operator double?(JToken value);
        public static explicit operator char?(JToken value);
        public static explicit operator int(JToken value);
        public static explicit operator short(JToken value);

        [CLSCompliant(false)]
        public static explicit operator ushort(JToken value);

        [CLSCompliant(false)]
        public static explicit operator char(JToken value);

        public static explicit operator byte(JToken value);
        public static explicit operator int?(JToken value);
        public static explicit operator short?(JToken value);

        [CLSCompliant(false)]
        public static explicit operator ushort?(JToken value);

        public static explicit operator byte?(JToken value);
        public static explicit operator DateTime(JToken value);
        public static explicit operator long?(JToken value);
        public static explicit operator float?(JToken value);
        public static explicit operator decimal(JToken value);

        [CLSCompliant(false)]
        public static explicit operator uint?(JToken value);

        [CLSCompliant(false)]
        public static explicit operator ulong?(JToken value);

        public static explicit operator double(JToken value);
        public static explicit operator float(JToken value);
        public static explicit operator string(JToken value);

        [CLSCompliant(false)]
        public static explicit operator uint(JToken value);

        [CLSCompliant(false)]
        public static explicit operator ulong(JToken value);

        public static explicit operator byte[](JToken value);
        public static explicit operator Guid(JToken value);
        public static explicit operator Guid?(JToken value);
        public static explicit operator TimeSpan(JToken value);
        public static explicit operator TimeSpan?(JToken value);
        public static explicit operator Uri(JToken value);
        public static implicit operator JToken(bool value);
        public static implicit operator JToken(DateTimeOffset value);
        public static implicit operator JToken(bool? value);
        public static implicit operator JToken(long value);
        public static implicit operator JToken(DateTime? value);
        public static implicit operator JToken(DateTimeOffset? value);
        public static implicit operator JToken(decimal? value);
        public static implicit operator JToken(double? value);

        [CLSCompliant(false)]
        public static implicit operator JToken(short value);

        [CLSCompliant(false)]
        public static implicit operator JToken(ushort value);

        public static implicit operator JToken(int value);
        public static implicit operator JToken(int? value);
        public static implicit operator JToken(DateTime value);
        public static implicit operator JToken(long? value);
        public static implicit operator JToken(float? value);
        public static implicit operator JToken(decimal value);

        [CLSCompliant(false)]
        public static implicit operator JToken(short? value);

        [CLSCompliant(false)]
        public static implicit operator JToken(ushort? value);

        [CLSCompliant(false)]
        public static implicit operator JToken(uint? value);

        [CLSCompliant(false)]
        public static implicit operator JToken(ulong? value);

        public static implicit operator JToken(double value);
        public static implicit operator JToken(float value);
        public static implicit operator JToken(string value);

        [CLSCompliant(false)]
        public static implicit operator JToken(uint value);

        [CLSCompliant(false)]
        public static implicit operator JToken(ulong value);

        public static implicit operator JToken(byte[] value);
        public static implicit operator JToken(Uri value);
        public static implicit operator JToken(TimeSpan value);
        public static implicit operator JToken(TimeSpan? value);
        public static implicit operator JToken(Guid value);
        public static implicit operator JToken(Guid? value);
        internal abstract JToken CloneToken();
        internal abstract bool DeepEquals(JToken node);
        public static bool DeepEquals(JToken t1, JToken t2);
        public void AddAfterSelf(object content);
        public void AddBeforeSelf(object content);
        public IEnumerable<JToken> Ancestors();
        public IEnumerable<JToken> AfterSelf();
        public IEnumerable<JToken> BeforeSelf();
        public virtual T Value<T>(object key);
        public virtual JEnumerable<JToken> Children();
        public JEnumerable<T> Children<T>() where T : JToken;
        public virtual IEnumerable<T> Values<T>();
        public void Remove();
        public void Replace(JToken value);
        public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);
        public override string ToString();
        public string ToString(Formatting formatting, params JsonConverter[] converters);
        private static JValue EnsureValue(JToken value);
        private static string GetType(JToken token);
        private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable);
        internal abstract int GetDeepHashCode();
        public JsonReader CreateReader();
        internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer);
        public static JToken FromObject(object o);
        public static JToken FromObject(object o, JsonSerializer jsonSerializer);
        public T ToObject<T>();
        public object ToObject(Type objectType);
        private object ToObject(Type objectType, bool isNullable);
        public T ToObject<T>(JsonSerializer jsonSerializer);
        public object ToObject(Type objectType, JsonSerializer jsonSerializer);
        public static JToken ReadFrom(JsonReader reader);
        public static JToken Parse(string json);
        public static JToken Load(JsonReader reader);
        internal void SetLineInfo(IJsonLineInfo lineInfo);
        internal void SetLineInfo(int lineNumber, int linePosition);
        public JToken SelectToken(string path);
        public JToken SelectToken(string path, bool errorWhenNoMatch);
        protected virtual DynamicMetaObject GetMetaObject(Expression parameter);
        public JToken DeepClone();
    }
}
