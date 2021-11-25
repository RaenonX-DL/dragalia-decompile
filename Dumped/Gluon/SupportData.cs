using Gluon.Http;

namespace Gluon
{
	public class SupportData
	{
		private const int charaAbilityMaxCount = 3;

		private const int charaSkillMaxCount = 2;

		private const int dragonAbilityMaxCount = 2;

		private const int dragonSkillMaxCount = 1;

		public ulong viewerId;

		public GiftType giftType;

		public ulong id;

		public int masterId;

		public int level;

		public int weaponBuildupCount;

		public int additionalMaxLevel;

		public int rarity;

		public int maxHp;

		public int maxHpPlus;

		public int attack;

		public int attackPlus;

		public int defense;

		public int plusVal;

		public int[] skillLevel;

		public int[] abilityLevel;

		public int exAbilityLevel;

		public int exAbility2Level;

		public int limitBreak;

		public int limitOver;

		public bool isUnlockEditSkill;

		public int inTeamPosition;

		public string playerName;

		public int exp;

		public int manaCircleCount;

		public int equipableCount;

		public int buildupCount;

		public int additionalCrestSlotType1Count;

		public int additionalCrestSlotType2count;

		public int additionalCrestSlotType3count;

		public int reliabilityLevel;

		public int fortHpPlus;

		public int fortAtkPlus;

		public int albumHpPlus;

		public int albumAtkPlus;

		public int charaBustAttackLv;

		public int charaComboLv;

		public static SupportData Create(AtgenSupportChara atgenData, string playerName)
		{
			return null;
		}

		public static SupportData Create(AtgenSupportDragon atgenData)
		{
			return null;
		}

		public static SupportData Create(AtgenSupportWeapon atgenData)
		{
			return null;
		}

		public static SupportData Create(AtgenSupportWeaponBody atgenData, ElementalType charaElementlType = ElementalType.NONE)
		{
			return null;
		}

		public static SupportData Create(AtgenSupportAmulet atgenData)
		{
			return null;
		}

		public static SupportData Create(AtgenSupportCrestSlotType1List atgenData)
		{
			return null;
		}

		public static SupportData[] Create(AtgenSupportCrestSlotType1List[] crestData)
		{
			return null;
		}
	}
}
