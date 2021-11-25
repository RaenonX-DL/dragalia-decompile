using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class UseItem : IMaster<UseItem>
	{
		[SerializeField]
		private UseItemDictionary dict;

		public UseItemDictionary Dict => null;

		public SerializableDictionary<int, UseItemElement>.ValueCollection List => null;
	}
}
