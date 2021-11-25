using System.Collections.Generic;
using System.Diagnostics;

namespace SerializableCollections
{
	internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue>
	{
		private readonly ICollection<TKey> _collection;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public TKey[] Items => null;

		public DictionaryKeyCollectionDebugView(ICollection<TKey> collection)
		{
		}
	}
}
