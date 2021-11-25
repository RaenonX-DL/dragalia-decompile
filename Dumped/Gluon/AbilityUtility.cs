using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;

namespace Gluon
{
	public static class AbilityUtility
	{
		public static bool IsEnableMixBuffAbility(int abilityId1, int abilityId2)
		{
			return default(bool);
		}

		private static bool IsEnableMixGroup(int group1, int group2)
		{
			return default(bool);
		}

		public static int GetShiftAbility(int abilityId1, int abilityId2)
		{
			return default(int);
		}

		private static int GetShiftId(int level, AbilityShiftGroupElement shiftData)
		{
			return default(int);
		}

		public static bool IsShiftAbility(int id)
		{
			return default(bool);
		}

		public static int GetShiftLevel(int id)
		{
			return default(int);
		}

		public static bool IsBuffAbility(int type)
		{
			return default(bool);
		}

		public static bool IsContinuousCondition(AbilityCondition condition)
		{
			return default(bool);
		}

		public static AbilityConst.UnitType GetExchangeGiftType(GiftType type)
		{
			return default(AbilityConst.UnitType);
		}

		public static List<int> GetUnionBonusList(int[] args, [Optional] int[] abilityIds)
		{
			return null;
		}

		public static void AddCrestGroupScoreByAbility(int[] abilityIds, ref Dictionary<int, int> baseScoreDict)
		{
		}

		public static int GetCrestGroupUpScore(AbilityDataElement masterAbilityData, int baseScore)
		{
			return default(int);
		}
	}
}
