/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SerializableCollections
{
	internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue>
	{
		// Fields
		private readonly ICollection<TKey> _collection;
	
		// Properties
		[DebuggerBrowsable]
		public TKey[] Items { get; }
	
		// Constructors
		public DictionaryKeyCollectionDebugView(ICollection<TKey> collection);
	}
}
