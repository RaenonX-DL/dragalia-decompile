using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SimpleEventItem : IMaster<SimpleEventItem>
	{
		[SerializeField]
		private SimpleEventItemDictionary dict;

		public SimpleEventItemDictionary Dict => null;

		public SerializableDictionary<int, SimpleEventItemElement>.ValueCollection List => null;
	}
}
