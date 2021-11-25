using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public static class ExtendAbilityCrestElement
	{
		public static int GetAbilityId(this AbilityCrestElement self, int abilityNo, int abilityLevel)
		{
			return default(int);
		}

		public static int GetMaxBuildupCount(this AbilityCrestElement self)
		{
			return default(int);
		}

		public static int GetMaxBuildupCountByLimitBreak(this AbilityCrestElement self, int limitBreak)
		{
			return default(int);
		}

		public static Dictionary<int, int> GetBuildupMaterialByLevel(this AbilityCrestElement self, int level)
		{
			return null;
		}

		public static Dictionary<int, int> GetLimitBreakMaterialByLimitCount(this AbilityCrestElement self, int limitbreak)
		{
			return null;
		}

		public static Dictionary<int, int> GetEquipableCountMaterialByReleaseCount(this AbilityCrestElement self, int count)
		{
			return null;
		}

		public static AbilityCrestBuildupGroupElement[] GetAbilityCrestBuildupGroupDatas(this AbilityCrestElement self, BuildupPieceType pieceType = BuildupPieceType.NONE)
		{
			return null;
		}

		public static int GetMaxHpPlusCount(this AbilityCrestElement self)
		{
			return default(int);
		}

		public static int GetMaxAtkPlusCount(this AbilityCrestElement self)
		{
			return default(int);
		}
	}
}
