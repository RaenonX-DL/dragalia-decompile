/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public sealed class HashSetFormatter<T> : CollectionFormatterBase<T, HashSet<T>, HashSet<T>, HashSet<T>>
	{
		// Constructors
		public HashSetFormatter();
	
		// Methods
		protected override int? GetCount(HashSet<T> sequence);
		protected override void Add(HashSet<T> collection, int index, T value);
		protected override HashSet<T> Complete(HashSet<T> intermediateCollection);
		protected override HashSet<T> Create(int count);
		protected override HashSet<T> GetSourceEnumerator(HashSet<T> source);
	}
}
