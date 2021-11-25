using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EditSkillCharaOffset : IMaster<EditSkillCharaOffset>
	{
		[SerializeField]
		private EditSkillCharaOffsetDictionary dict;

		public EditSkillCharaOffsetDictionary Dict => null;

		public SerializableDictionary<int, EditSkillCharaOffsetElement>.ValueCollection List => null;
	}
}
