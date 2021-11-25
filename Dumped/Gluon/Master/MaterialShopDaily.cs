using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MaterialShopDaily : IMaster<MaterialShopDaily>
	{
		[SerializeField]
		private MaterialShopDailyDictionary dict;

		public MaterialShopDailyDictionary Dict => null;

		public SerializableDictionary<int, MaterialShopDailyElement>.ValueCollection List => null;
	}
}
