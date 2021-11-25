using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponSkin : IMaster<WeaponSkin>
	{
		[SerializeField]
		private WeaponSkinDictionary dict;

		public WeaponSkinDictionary Dict => null;

		public SerializableDictionary<int, WeaponSkinElement>.ValueCollection List => null;
	}
}
