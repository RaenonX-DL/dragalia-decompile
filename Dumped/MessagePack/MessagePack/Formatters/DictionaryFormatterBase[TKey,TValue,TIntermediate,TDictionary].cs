/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public abstract class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : IMessagePackFormatter<TDictionary>
		where TDictionary : IDictionary<TKey, TValue>
	{
		// Constructors
		protected DictionaryFormatterBase();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, TDictionary value, IFormatterResolver formatterResolver);
		public TDictionary Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
		protected abstract TIntermediate Create(int count);
		protected abstract void Add(TIntermediate collection, int index, TKey key, TValue value);
		protected abstract TDictionary Complete(TIntermediate intermediateCollection);
	}
}
