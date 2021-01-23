/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SerializableCollections
{
	internal sealed class DictionaryValueCollectionDebugView<TKey, TValue>
	{
		// Fields
		private readonly ICollection<TValue> _collection;
	
		// Properties
		[DebuggerBrowsable]
		public TValue[] Items { get; }
	
		// Constructors
		public DictionaryValueCollectionDebugView(ICollection<TValue> collection);
	}
}
