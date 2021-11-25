using System.Collections.Generic;
using System.Diagnostics;

namespace SerializableCollections
{
	internal sealed class IDictionaryDebugView<K, V>
	{
		private readonly IDictionary<K, V> _dict;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public KeyValuePair<K, V>[] Items => null;

		public IDictionaryDebugView(IDictionary<K, V> dictionary)
		{
		}
	}
}
