/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public sealed class DictionaryFormatter<TKey, TValue> : DictionaryFormatterBase<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>>
	{
		// Constructors
		public DictionaryFormatter();
	
		// Methods
		protected override void Add(Dictionary<TKey, TValue> collection, int index, TKey key, TValue value);
		protected override Dictionary<TKey, TValue> Complete(Dictionary<TKey, TValue> intermediateCollection);
		protected override Dictionary<TKey, TValue> Create(int count);
	}
}
