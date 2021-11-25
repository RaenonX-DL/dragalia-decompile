using System;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class DifferenceImageSkillCutInObject : ScriptableObject
	{
		public enum Type
		{
			None = -1,
			Skill_1,
			Skill_2,
			Skill_3,
			Skill_4,
			EnhancedSkill_1,
			EnhancedSkill_2,
			EnhancedSkill_3,
			EnhancedSkill_4
		}

		[Serializable]
		public class EmotionData
		{
			public int groupNo;

			public int frameNo;

			public float showTime;
		}

		[Serializable]
		public class PartsData
		{
			public EmotionData[] emotionTable;
		}

		[Serializable]
		public class SkillData
		{
			public Type type;

			public PartsData[] partsTable;
		}

		public SkillData[] skillTable;

		public SkillData GetSkillData(Type _type)
		{
			return null;
		}
	}
}
