using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ExHunterEventItem : IMaster<ExHunterEventItem>
	{
		[SerializeField]
		private ExHunterEventItemDictionary dict;

		public ExHunterEventItemDictionary Dict => null;

		public SerializableDictionary<int, ExHunterEventItemElement>.ValueCollection List => null;
	}
}
