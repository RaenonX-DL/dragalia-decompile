/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SerializableCollections
{
	internal sealed class IDictionaryDebugView<K, V>
	{
		// Fields
		private readonly IDictionary<K, V> _dict;
	
		// Properties
		[DebuggerBrowsable]
		public KeyValuePair<K, V>[] Items { get; }
	
		// Constructors
		public IDictionaryDebugView(IDictionary<K, V> dictionary);
	}
}
