using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MaterialShopWeekly : IMaster<MaterialShopWeekly>
	{
		[SerializeField]
		private MaterialShopWeeklyDictionary dict;

		public MaterialShopWeeklyDictionary Dict => null;

		public SerializableDictionary<int, MaterialShopWeeklyElement>.ValueCollection List => null;
	}
}
