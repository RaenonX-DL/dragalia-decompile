using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityLimitedGroup : IMaster<AbilityLimitedGroup>
	{
		[SerializeField]
		private AbilityLimitedGroupDictionary dict;

		public AbilityLimitedGroupDictionary Dict => null;

		public SerializableDictionary<int, AbilityLimitedGroupElement>.ValueCollection List => null;
	}
}
