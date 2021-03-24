/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ExtendAbilityCrestElement
	{
		// Extension methods
		public static int GetAbilityId(this AbilityCrestElement self, int abilityNo, int abilityLevel);
		public static int GetMaxBuildupCount(this AbilityCrestElement self);
		public static int GetMaxBuildupCountByLimitBreak(this AbilityCrestElement self, int limitBreak);
		public static Dictionary<int, int> GetBuildupMaterialByLevel(this AbilityCrestElement self, int level);
		public static Dictionary<int, int> GetLimitBreakMaterialByLimitCount(this AbilityCrestElement self, int limitbreak);
		public static Dictionary<int, int> GetEquipableCountMaterialByReleaseCount(this AbilityCrestElement self, int count);
		public static AbilityCrestBuildupGroupElement[] GetAbilityCrestBuildupGroupDatas(this AbilityCrestElement self, BuildupPieceType pieceType = BuildupPieceType.NONE);
		public static int GetMaxHpPlusCount(this AbilityCrestElement self);
		public static int GetMaxAtkPlusCount(this AbilityCrestElement self);
	}
}
