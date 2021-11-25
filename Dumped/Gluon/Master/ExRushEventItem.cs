using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ExRushEventItem : IMaster<ExRushEventItem>
	{
		[SerializeField]
		private ExRushEventItemDictionary dict;

		public ExRushEventItemDictionary Dict => null;

		public SerializableDictionary<int, ExRushEventItemElement>.ValueCollection List => null;
	}
}
