// Type: Newtonsoft.Json.JsonWriter
// Assembly: Newtonsoft.Json, Version=4.5.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\Resources\Newtonsoft.Json.dll

using System;
using System.Collections.Generic;

namespace Newtonsoft.Json
{
    public abstract class JsonWriter : IDisposable
    {
        private static readonly JsonWriter.State[][] StateArray;
        internal static readonly JsonWriter.State[][] StateArrayTempate;
        private readonly List<JsonPosition> _stack;
        private JsonPosition _currentPosition;
        private JsonWriter.State _currentState;
        private DateFormatHandling _dateFormatHandling;
        private DateTimeZoneHandling _dateTimeZoneHandling;
        private Formatting _formatting;
        private StringEscapeHandling _stringEscapeHandling;
        static JsonWriter();
        protected JsonWriter();
        public bool CloseOutput { get; set; }
        protected internal int Top { get; }
        public WriteState WriteState { get; }
        internal string ContainerPath { get; }
        public string Path { get; }
        public Formatting Formatting { get; set; }
        public DateFormatHandling DateFormatHandling { get; set; }
        public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
        public StringEscapeHandling StringEscapeHandling { get; set; }

        #region IDisposable Members

        void IDisposable.Dispose();

        #endregion

        internal static JsonWriter.State[][] BuildStateArray();
        internal void UpdateScopeWithFinishedValue();
        private void Push(JsonContainerType value);
        private JsonContainerType Pop();
        private JsonContainerType Peek();
        public abstract void Flush();
        public virtual void Close();
        public virtual void WriteStartObject();
        internal void InternalWriteStart(JsonToken token, JsonContainerType container);
        public virtual void WriteEndObject();
        public virtual void WriteStartArray();
        public virtual void WriteEndArray();
        public virtual void WriteStartConstructor(string name);
        public virtual void WriteEndConstructor();
        internal void InternalWriteEnd(JsonContainerType container);
        public virtual void WritePropertyName(string name);
        internal void InternalWritePropertyName(string name);
        public virtual void WriteEnd();
        public void WriteToken(JsonReader reader);
        internal void WriteToken(JsonReader reader, int initialDepth);
        private void WriteConstructorDate(JsonReader reader);
        private bool IsEndToken(JsonToken token);
        private bool IsStartToken(JsonToken token);
        private void WriteEnd(JsonContainerType type);
        private void AutoCompleteAll();
        private JsonToken GetCloseTokenForType(JsonContainerType type);
        private void AutoCompleteClose(JsonContainerType type);
        protected virtual void WriteEnd(JsonToken token);
        protected virtual void WriteIndent();
        protected virtual void WriteValueDelimiter();
        protected virtual void WriteIndentSpace();
        internal void AutoComplete(JsonToken tokenBeingWritten);
        public virtual void WriteNull();
        internal void InternalWriteNull();
        public virtual void WriteUndefined();
        internal void InternalWriteUndefined();
        public virtual void WriteRaw(string json);
        internal void InternalWriteRaw();
        public virtual void WriteRawValue(string json);
        public virtual void WriteValue(string value);
        internal void InternalWriteValue(JsonToken token);
        public virtual void WriteValue(int value);

        [CLSCompliant(false)]
        public virtual void WriteValue(uint value);

        public virtual void WriteValue(long value);

        [CLSCompliant(false)]
        public virtual void WriteValue(ulong value);

        public virtual void WriteValue(float value);
        public virtual void WriteValue(double value);
        public virtual void WriteValue(bool value);
        public virtual void WriteValue(short value);

        [CLSCompliant(false)]
        public virtual void WriteValue(ushort value);

        public virtual void WriteValue(char value);
        public virtual void WriteValue(byte value);

        [CLSCompliant(false)]
        public virtual void WriteValue(sbyte value);

        public virtual void WriteValue(decimal value);
        public virtual void WriteValue(DateTime value);
        public virtual void WriteValue(DateTimeOffset value);
        public virtual void WriteValue(Guid value);
        public virtual void WriteValue(TimeSpan value);
        public virtual void WriteValue(int? value);

        [CLSCompliant(false)]
        public virtual void WriteValue(uint? value);

        public virtual void WriteValue(long? value);

        [CLSCompliant(false)]
        public virtual void WriteValue(ulong? value);

        public virtual void WriteValue(float? value);
        public virtual void WriteValue(double? value);
        public virtual void WriteValue(bool? value);
        public virtual void WriteValue(short? value);

        [CLSCompliant(false)]
        public virtual void WriteValue(ushort? value);

        public virtual void WriteValue(char? value);
        public virtual void WriteValue(byte? value);

        [CLSCompliant(false)]
        public virtual void WriteValue(sbyte? value);

        public virtual void WriteValue(decimal? value);
        public virtual void WriteValue(DateTime? value);
        public virtual void WriteValue(DateTimeOffset? value);
        public virtual void WriteValue(Guid? value);
        public virtual void WriteValue(TimeSpan? value);
        public virtual void WriteValue(byte[] value);
        public virtual void WriteValue(Uri value);
        public virtual void WriteValue(object value);
        public virtual void WriteComment(string text);
        internal void InternalWriteComment();
        public virtual void WriteWhitespace(string ws);
        internal void InternalWriteWhitespace(string ws);
        private void Dispose(bool disposing);

        #region Nested type: State

        internal enum State
        {
            Start,
            Property,
            ObjectStart,
            Object,
            ArrayStart,
            Array,
            ConstructorStart,
            Constructor,
            Closed,
            Error,
        }

        #endregion
    }
}
