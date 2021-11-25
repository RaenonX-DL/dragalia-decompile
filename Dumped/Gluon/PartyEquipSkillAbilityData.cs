using System.Collections.Generic;

namespace Gluon
{
	public class PartyEquipSkillAbilityData
	{
		public enum AbilityType
		{
			Chara,
			Weapon,
			Amulet,
			Dragon,
			Skill
		}

		public int dataId;

		public int level;

		public int maxLevel;

		public ElementalType type;

		public bool isNotMatchElement;

		public bool isSecondExAbility;

		public List<PartyEquipSkillAbilityData> overlapedAbility;

		public List<PartyEquipSkillAbilityData> duplicationShiftAbilityIds;

		public AbilityType abilityType;
	}
}
