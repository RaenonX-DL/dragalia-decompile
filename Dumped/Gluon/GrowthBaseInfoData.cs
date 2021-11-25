using UnityEngine;

namespace Gluon
{
	public class GrowthBaseInfoData
	{
		public ulong growthBaseKeyId;

		public int growthBaseId;

		public ElementalType elementType;

		public WeaponType weaponType;

		public int rarity;

		public string name;

		public int manaCount;

		public int limitBreak;

		public int recordHighLimitBreak;

		public int level;

		public int maxLevel;

		public int maxLimitLevel;

		public int nowLvExp;

		public int needNextLvExp;

		public int nowTotalExp;

		public int needMaxLvExp;

		public int hpParam;

		public int atkParam;

		public int defParam;

		public int hpPlusParam;

		public int atkPlusParam;

		public int maxHpPlus;

		public int maxAtkPlus;

		public int manaCirclePlusHp;

		public int manaCirclePlusAtk;

		public int fortPlusHp;

		public int fortPlusAtk;

		public int albumPlusHp;

		public int albumPlusAtk;

		public int skillId1;

		public int skillLvParam1;

		public int skillId2;

		public int skillLvParam2;

		public int skillLearning;

		public int abilityId;

		public int abilityId2;

		public int abilityId3;

		public int abilityLv1;

		public int abilityLv2;

		public int abilityLv3;

		public int powerParam;

		public bool isAbilityEnable1;

		public bool isAbilityEnable2;

		public bool isAbilityEnable3;

		private int[] charaGrowPlus;

		public GrowthBaseInfoData(ulong dataId)
		{
		}

		public int GetNeedNewLvExp(int newLv)
		{
			return default(int);
		}

		public int GetTotalNewLvExp(int newLv)
		{
			return default(int);
		}

		public int GetGrowLv(int getExp)
		{
			return default(int);
		}

		public int GetGrowAtk(int growLv, int growPlus)
		{
			return default(int);
		}

		public int GetGrowDef(int growLv, int growPlus)
		{
			return default(int);
		}

		public int GetGrowHp(int growLv, int growPlus)
		{
			return default(int);
		}

		public static Material GetTargetIconMaterial()
		{
			return null;
		}
	}
}
