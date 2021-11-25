using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CollectEventItem : IMaster<CollectEventItem>
	{
		[SerializeField]
		private CollectEventItemDictionary dict;

		public CollectEventItemDictionary Dict => null;

		public SerializableDictionary<int, CollectEventItemElement>.ValueCollection List => null;
	}
}
