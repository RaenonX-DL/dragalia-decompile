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

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public abstract class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : IMessagePackFormatter<TCollection>
		where TEnumerator : IEnumerator<TElement>
		where TCollection : IEnumerable<TElement>
	{
		// Constructors
		protected CollectionFormatterBase();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, TCollection value, IFormatterResolver formatterResolver);
		public TCollection Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
		protected virtual int? GetCount(TCollection sequence);
		protected abstract TEnumerator GetSourceEnumerator(TCollection source);
		protected abstract TIntermediate Create(int count);
		protected abstract void Add(TIntermediate collection, int index, TElement value);
		protected abstract TCollection Complete(TIntermediate intermediateCollection);
	}
}
