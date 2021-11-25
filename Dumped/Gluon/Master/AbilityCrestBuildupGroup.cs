using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityCrestBuildupGroup : IMaster<AbilityCrestBuildupGroup>
	{
		[SerializeField]
		private AbilityCrestBuildupGroupDictionary dict;

		public AbilityCrestBuildupGroupDictionary Dict => null;

		public SerializableDictionary<int, AbilityCrestBuildupGroupElement>.ValueCollection List => null;
	}
}
