using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AuraEffectGroup : IMaster<AuraEffectGroup>
	{
		[SerializeField]
		private AuraEffectGroupDictionary dict;

		public AuraEffectGroupDictionary Dict => null;

		public SerializableDictionary<int, AuraEffectGroupElement>.ValueCollection List => null;
	}
}
