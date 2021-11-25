using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonGiftData : IMaster<DragonGiftData>
	{
		[SerializeField]
		private DragonGiftDataDictionary dict;

		public DragonGiftDataDictionary Dict => null;

		public SerializableDictionary<int, DragonGiftDataElement>.ValueCollection List => null;
	}
}
