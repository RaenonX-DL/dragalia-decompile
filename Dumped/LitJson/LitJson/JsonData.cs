/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 47: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	public class JsonData : IJsonWrapper, IEquatable<LitJson.JsonData>
	{
		// Fields
		private IList<JsonData> inst_array;
		private bool inst_boolean;
		private double inst_double;
		private int inst_int;
		private long inst_long;
		private IDictionary<string, JsonData> inst_object;
		private string inst_string;
		private string json;
		private JsonType type;
		private IList<KeyValuePair<string, JsonData>> object_list;
	
		// Properties
		int ICollection.Count { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		bool IDictionary.IsFixedSize { get; }
		bool IDictionary.IsReadOnly { get; }
		ICollection IDictionary.Keys { get; }
		ICollection IDictionary.Values { get; }
		bool IJsonWrapper.IsArray { get; }
		bool IJsonWrapper.IsBoolean { get; }
		bool IJsonWrapper.IsDouble { get; }
		bool IJsonWrapper.IsInt { get; }
		bool IJsonWrapper.IsLong { get; }
		bool IJsonWrapper.IsObject { get; }
		bool IJsonWrapper.IsString { get; }
		bool IList.IsFixedSize { get; }
		bool IList.IsReadOnly { get; }
		object IDictionary.this[object key] { get => default; set {} }
		object IList.this[int index] { get => default; set {} }
		public int Count { get; }
		public bool IsArray { get; }
		public bool IsBoolean { get; }
		public bool IsDouble { get; }
		public bool IsInt { get; }
		public bool IsLong { get; }
		public bool IsObject { get; }
		public bool IsString { get; }
		public JsonData this[string prop_name] { set {} }
		public JsonData this[int index] { set {} }
	
		// Constructors
		public JsonData();
		public JsonData(object obj);
	
		// Methods
		void ICollection.CopyTo(Array array, int index);
		void IDictionary.Add(object key, object value);
		bool IDictionary.Contains(object key);
		IDictionaryEnumerator IDictionary.GetEnumerator();
		void IDictionary.Remove(object key);
		IEnumerator IEnumerable.GetEnumerator();
		bool IJsonWrapper.GetBoolean();
		double IJsonWrapper.GetDouble();
		int IJsonWrapper.GetInt();
		long IJsonWrapper.GetLong();
		string IJsonWrapper.GetString();
		void IJsonWrapper.SetBoolean(bool val);
		void IJsonWrapper.SetDouble(double val);
		void IJsonWrapper.SetInt(int val);
		void IJsonWrapper.SetLong(long val);
		void IJsonWrapper.SetString(string val);
		string IJsonWrapper.ToJson();
		void IJsonWrapper.ToJson(JsonWriter writer);
		int IList.Add(object value);
		void IList.Clear();
		bool IList.Contains(object value);
		int IList.IndexOf(object value);
		void IList.Insert(int index, object value);
		void IList.Remove(object value);
		void IList.RemoveAt(int index);
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator();
		private ICollection EnsureCollection();
		private IDictionary EnsureDictionary();
		private IList EnsureList();
		private JsonData ToJsonData(object obj);
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer);
		public int Add(object value);
		public bool Equals(JsonData x);
		public void SetJsonType(JsonType type);
		public string ToJson();
		public void ToJson(JsonWriter writer);
		public override string ToString();
	}
}
