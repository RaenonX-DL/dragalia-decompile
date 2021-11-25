using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SkillData : IMaster<SkillData>
	{
		[SerializeField]
		private SkillDataDictionary dict;

		public SkillDataDictionary Dict => null;

		public SerializableDictionary<int, SkillDataElement>.ValueCollection List => null;
	}
}
