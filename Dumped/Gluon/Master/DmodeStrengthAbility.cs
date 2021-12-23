using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeStrengthAbility : IMaster<DmodeStrengthAbility>
	{
		[SerializeField]
		private DmodeStrengthAbilityDictionary dict;

		public DmodeStrengthAbilityDictionary Dict => null;

		public SerializableDictionary<int, DmodeStrengthAbilityElement>.ValueCollection List => null;
	}
}
