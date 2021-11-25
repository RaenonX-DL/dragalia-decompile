using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AuraEffect : IMaster<AuraEffect>
	{
		[SerializeField]
		private AuraEffectDictionary dict;

		public AuraEffectDictionary Dict => null;

		public SerializableDictionary<int, AuraEffectElement>.ValueCollection List => null;
	}
}
