/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 50: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	public class JsonMockWrapper : IJsonWrapper
	{
		// Properties
		bool IList.IsFixedSize { get; }
		bool IList.IsReadOnly { get; }
		object IList.this[int index] { get => default; set {} }
		int ICollection.Count { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		bool IDictionary.IsFixedSize { get; }
		bool IDictionary.IsReadOnly { get; }
		ICollection IDictionary.Keys { get; }
		ICollection IDictionary.Values { get; }
		object IDictionary.this[object key] { get => default; set {} }
		public bool IsArray { get; }
		public bool IsBoolean { get; }
		public bool IsDouble { get; }
		public bool IsInt { get; }
		public bool IsLong { get; }
		public bool IsObject { get; }
		public bool IsString { get; }
	
		// Constructors
		public JsonMockWrapper();
	
		// Methods
		public bool GetBoolean();
		public double GetDouble();
		public int GetInt();
		public long GetLong();
		public string GetString();
		public void SetBoolean(bool val);
		public void SetDouble(double val);
		public void SetInt(int val);
		public void SetJsonType(JsonType type);
		public void SetLong(long val);
		public void SetString(string val);
		public string ToJson();
		public void ToJson(JsonWriter writer);
		int IList.Add(object value);
		void IList.Clear();
		bool IList.Contains(object value);
		int IList.IndexOf(object value);
		void IList.Insert(int i, object v);
		void IList.Remove(object value);
		void IList.RemoveAt(int index);
		void ICollection.CopyTo(Array array, int index);
		IEnumerator IEnumerable.GetEnumerator();
		void IDictionary.Add(object k, object v);
		bool IDictionary.Contains(object key);
		void IDictionary.Remove(object key);
		IDictionaryEnumerator IDictionary.GetEnumerator();
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator();
	}
}
