using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GatherItem : IMaster<GatherItem>
	{
		[SerializeField]
		private GatherItemDictionary dict;

		public GatherItemDictionary Dict => null;

		public SerializableDictionary<int, GatherItemElement>.ValueCollection List => null;
	}
}
