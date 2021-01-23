/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 47: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator
	{
		// Fields
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	
		// Properties
		public object Current { get; }
		public DictionaryEntry Entry { get; }
		public object Key { get; }
		public object Value { get; }
	
		// Constructors
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator);
	
		// Methods
		public bool MoveNext();
		public void Reset();
	}
}
