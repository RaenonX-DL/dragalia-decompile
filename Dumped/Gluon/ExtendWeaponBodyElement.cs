using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public static class ExtendWeaponBodyElement
	{
		public static int GetMaxLimitOverCount(this WeaponBodyElement self)
		{
			return default(int);
		}

		public static int GetMaxLimitBreakCount(this WeaponBodyElement self)
		{
			return default(int);
		}

		public static int GetMaxLimitBreakCountByLimitOver(this WeaponBodyElement self, int limitOver)
		{
			return default(int);
		}

		public static int GetMaxBuildupCount(this WeaponBodyElement self)
		{
			return default(int);
		}

		public static int GetMaxBuildupCountByLimitBreak(this WeaponBodyElement self, int limitBreak)
		{
			return default(int);
		}

		public static WeaponPassiveAbilityElement[] GetWeaponPassiveAbilityDatas(this WeaponBodyElement self)
		{
			return null;
		}

		public static int GetSkillId(this WeaponBodyElement self, int skillNo)
		{
			return default(int);
		}

		public static int GetAbilityId(this WeaponBodyElement self, int abilityNo, int abilityLevel)
		{
			return default(int);
		}

		public static Dictionary<int, int> GetBuildupMaterialByLevel(this WeaponBodyElement self, int level)
		{
			return null;
		}

		public static Dictionary<int, int> GetLimitBreakMaterialByLimitCount(this WeaponBodyElement self, int limitbreak)
		{
			return null;
		}

		public static Dictionary<int, int> GetEquipableCountMaterialByReleaseCount(this WeaponBodyElement self, int count)
		{
			return null;
		}

		public static WeaponBodyBuildupGroupElement[] GetWeaponBodyBuildupGroupDatas(this WeaponBodyElement self, BuildupPieceType pieceType = BuildupPieceType.NONE)
		{
			return null;
		}

		public static int GetWeaponSkinIdBySkinNo(this WeaponBodyElement self, int skinNo)
		{
			return default(int);
		}

		public static int ConvertAbilityNoToAbilityDataId(this WeaponBodyElement self, int abilityNo)
		{
			return default(int);
		}

		public static int GetWeaponSkinId(this WeaponBodyElement self, int limitOverCount)
		{
			return default(int);
		}
	}
}
