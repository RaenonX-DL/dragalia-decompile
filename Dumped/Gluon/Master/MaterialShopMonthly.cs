using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MaterialShopMonthly : IMaster<MaterialShopMonthly>
	{
		[SerializeField]
		private MaterialShopMonthlyDictionary dict;

		public MaterialShopMonthlyDictionary Dict => null;

		public SerializableDictionary<int, MaterialShopMonthlyElement>.ValueCollection List => null;
	}
}
