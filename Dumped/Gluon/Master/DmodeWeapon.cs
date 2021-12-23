using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeWeapon : IMaster<DmodeWeapon>
	{
		[SerializeField]
		private DmodeWeaponDictionary dict;

		public DmodeWeaponDictionary Dict => null;

		public SerializableDictionary<int, DmodeWeaponElement>.ValueCollection List => null;
	}
}
