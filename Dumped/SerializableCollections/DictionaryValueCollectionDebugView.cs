using System.Collections.Generic;
using System.Diagnostics;

namespace SerializableCollections
{
	internal sealed class DictionaryValueCollectionDebugView<TKey, TValue>
	{
		private readonly ICollection<TValue> _collection;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public TValue[] Items => null;

		public DictionaryValueCollectionDebugView(ICollection<TValue> collection)
		{
		}
	}
}
