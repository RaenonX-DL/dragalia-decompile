/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class DifferenceImageSkillCutInObject : ScriptableObject
	{
		// Fields
		public SkillData[] skillTable;
	
		// Nested types
		public enum Type
		{
			None = -1,
			Skill_1 = 0,
			Skill_2 = 1,
			Skill_3 = 2,
			Skill_4 = 3,
			EnhancedSkill_1 = 4,
			EnhancedSkill_2 = 5,
			EnhancedSkill_3 = 6,
			EnhancedSkill_4 = 7
		}
	
		[Serializable]
		public class EmotionData
		{
			// Fields
			public int groupNo;
			public int frameNo;
			public float showTime;
	
			// Constructors
			public EmotionData();
		}
	
		[Serializable]
		public class PartsData
		{
			// Fields
			public EmotionData[] emotionTable;
	
			// Constructors
			public PartsData();
		}
	
		[Serializable]
		public class SkillData
		{
			// Fields
			public Type type;
			public PartsData[] partsTable;
	
			// Constructors
			public SkillData();
		}
	
		// Constructors
		public DifferenceImageSkillCutInObject();
	
		// Methods
		public SkillData GetSkillData(Type _type);
	}
}
