using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponType : IMaster<WeaponType>
	{
		[SerializeField]
		private WeaponTypeDictionary dict;

		public WeaponTypeDictionary Dict => null;

		public SerializableDictionary<int, WeaponTypeElement>.ValueCollection List => null;
	}
}
