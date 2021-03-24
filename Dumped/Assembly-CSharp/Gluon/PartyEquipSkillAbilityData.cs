/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipSkillAbilityData
	{
		// Fields
		public int dataId;
		public int level;
		public int maxLevel;
		public ElementalType type;
		public bool isNotMatchElement;
		public bool isSecondExAbility;
		public List<PartyEquipSkillAbilityData> overlapedAbility;
		public List<PartyEquipSkillAbilityData> duplicationShiftAbilityIds;
		public AbilityType abilityType;
	
		// Nested types
		public enum AbilityType
		{
			Chara = 0,
			Weapon = 1,
			Amulet = 2,
			Dragon = 3,
			Skill = 4
		}
	
		// Constructors
		public PartyEquipSkillAbilityData();
	}
}
