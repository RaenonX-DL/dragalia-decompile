using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityShiftGroup : IMaster<AbilityShiftGroup>
	{
		[SerializeField]
		private AbilityShiftGroupDictionary dict;

		public AbilityShiftGroupDictionary Dict => null;

		public SerializableDictionary<int, AbilityShiftGroupElement>.ValueCollection List => null;
	}
}
