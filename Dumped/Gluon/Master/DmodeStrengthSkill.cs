using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeStrengthSkill : IMaster<DmodeStrengthSkill>
	{
		[SerializeField]
		private DmodeStrengthSkillDictionary dict;

		public DmodeStrengthSkillDictionary Dict => null;

		public SerializableDictionary<int, DmodeStrengthSkillElement>.ValueCollection List => null;
	}
}
