using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class RaidEventItem : IMaster<RaidEventItem>
	{
		[SerializeField]
		private RaidEventItemDictionary dict;

		public RaidEventItemDictionary Dict => null;

		public SerializableDictionary<int, RaidEventItemElement>.ValueCollection List => null;
	}
}
