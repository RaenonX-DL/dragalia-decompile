/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class AbilityUtility
	{
		// Methods
		public static bool IsEnableMixBuffAbility(int abilityId1, int abilityId2);
		private static bool IsEnableMixGroup(int group1, int group2);
		public static int GetShiftAbility(int abilityId1, int abilityId2);
		private static int GetShiftId(int level, AbilityShiftGroupElement shiftData);
		public static bool IsShiftAbility(int id);
		public static int GetShiftLevel(int id);
		public static bool IsBuffAbility(int type);
		public static bool IsContinuousCondition(AbilityCondition condition);
		public static AbilityConst.UnitType GetExchangeGiftType(GiftType type);
		public static List<int> GetUnionBonusList(int[] args, int[] abilityIds = null);
		public static void AddCrestGroupScoreByAbility(int[] abilityIds, ref Dictionary<int, int> baseScoreDict);
		public static int GetCrestGroupUpScore(AbilityDataElement masterAbilityData, int baseScore);
	}
}
