// Type: Newtonsoft.Json.Linq.JObject
// Assembly: Newtonsoft.Json, Version=4.5.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\Resources\Newtonsoft.Json.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Linq
{
    public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>,
                           IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged,
                           ICustomTypeDescriptor, INotifyPropertyChanging
    {
        private readonly JPropertyKeyedCollection _properties;
        private PropertyChangedEventHandler PropertyChanged;
        private PropertyChangingEventHandler PropertyChanging;
        public JObject();
        public JObject(JObject other);
        public JObject(params object[] content);
        public JObject(object content);
        protected override IList<JToken> ChildrenTokens { get; }
        public override JTokenType Type { get; }
        public override JToken this[object key] { get; set; }

        #region ICustomTypeDescriptor Members

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties();
        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes);
        AttributeCollection ICustomTypeDescriptor.GetAttributes();
        string ICustomTypeDescriptor.GetClassName();
        string ICustomTypeDescriptor.GetComponentName();
        TypeConverter ICustomTypeDescriptor.GetConverter();
        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent();
        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty();
        object ICustomTypeDescriptor.GetEditor(Type editorBaseType);
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes);
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents();
        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd);

        #endregion

        #region IDictionary<string,JToken> Members

        public void Add(string propertyName, JToken value);
        bool IDictionary<string, JToken>.ContainsKey(string key);
        public bool Remove(string propertyName);
        public bool TryGetValue(string propertyName, out JToken value);
        void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item);
        void ICollection<KeyValuePair<string, JToken>>.Clear();
        bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item);
        void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex);
        bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item);
        public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator();
        public JToken this[string propertyName] { get; set; }
        ICollection<string> IDictionary<string, JToken>.Keys { get; }
        ICollection<JToken> IDictionary<string, JToken>.Values { get; }
        bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly { get; }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        #endregion

        internal override bool DeepEquals(JToken node);
        internal override void InsertItem(int index, JToken item, bool skipParentCheck);
        internal override void ValidateToken(JToken o, JToken existing);
        internal void InternalPropertyChanged(JProperty childProperty);
        internal void InternalPropertyChanging(JProperty childProperty);
        internal override JToken CloneToken();
        public IEnumerable<JProperty> Properties();
        public JProperty Property(string name);
        public JEnumerable<JToken> PropertyValues();
        public new static JObject Load(JsonReader reader);
        public new static JObject Parse(string json);
        public new static JObject FromObject(object o);
        public new static JObject FromObject(object o, JsonSerializer jsonSerializer);
        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters);
        public JToken GetValue(string propertyName);
        public JToken GetValue(string propertyName, StringComparison comparison);
        public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value);
        internal override int GetDeepHashCode();
        protected virtual void OnPropertyChanged(string propertyName);
        protected virtual void OnPropertyChanging(string propertyName);
        private static Type GetTokenPropertyType(JToken token);
        protected override DynamicMetaObject GetMetaObject(Expression parameter);

        #region Nested type: JObjectDynamicProxy

        private class JObjectDynamicProxy : DynamicProxy<JObject>
        {
            public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object result);
            public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value);
            public override IEnumerable<string> GetDynamicMemberNames(JObject instance);
        }

        #endregion
    }
}
