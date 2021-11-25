using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityCrestFeatureGroup : IMaster<AbilityCrestFeatureGroup>
	{
		[SerializeField]
		private AbilityCrestFeatureGroupDictionary dict;

		public AbilityCrestFeatureGroupDictionary Dict => null;

		public SerializableDictionary<int, AbilityCrestFeatureGroupElement>.ValueCollection List => null;
	}
}
