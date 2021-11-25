using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EarnEventItem : IMaster<EarnEventItem>
	{
		[SerializeField]
		private EarnEventItemDictionary dict;

		public EarnEventItemDictionary Dict => null;

		public SerializableDictionary<int, EarnEventItemElement>.ValueCollection List => null;
	}
}
