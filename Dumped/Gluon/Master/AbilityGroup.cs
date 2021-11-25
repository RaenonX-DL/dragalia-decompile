using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityGroup : IMaster<AbilityGroup>
	{
		[SerializeField]
		private AbilityGroupDictionary dict;

		public AbilityGroupDictionary Dict => null;

		public SerializableDictionary<int, AbilityGroupElement>.ValueCollection List => null;
	}
}
