using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SkillChainData : IMaster<SkillChainData>
	{
		[SerializeField]
		private SkillChainDataDictionary dict;

		public SkillChainDataDictionary Dict => null;

		public SerializableDictionary<int, SkillChainDataElement>.ValueCollection List => null;
	}
}
