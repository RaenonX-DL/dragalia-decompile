using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityCrestBuildupLevel : IMaster<AbilityCrestBuildupLevel>
	{
		[SerializeField]
		private AbilityCrestBuildupLevelDictionary dict;

		public AbilityCrestBuildupLevelDictionary Dict => null;

		public SerializableDictionary<int, AbilityCrestBuildupLevelElement>.ValueCollection List => null;
	}
}
