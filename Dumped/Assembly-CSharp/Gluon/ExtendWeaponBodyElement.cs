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
	public static class ExtendWeaponBodyElement
	{
		// Extension methods
		public static int GetMaxLimitOverCount(this WeaponBodyElement self);
		public static int GetMaxLimitBreakCount(this WeaponBodyElement self);
		public static int GetMaxLimitBreakCountByLimitOver(this WeaponBodyElement self, int limitOver);
		public static int GetMaxBuildupCount(this WeaponBodyElement self);
		public static int GetMaxBuildupCountByLimitBreak(this WeaponBodyElement self, int limitBreak);
		public static WeaponPassiveAbilityElement[] GetWeaponPassiveAbilityDatas(this WeaponBodyElement self);
		public static int GetSkillId(this WeaponBodyElement self, int skillNo);
		public static int GetAbilityId(this WeaponBodyElement self, int abilityNo, int abilityLevel);
		public static Dictionary<int, int> GetBuildupMaterialByLevel(this WeaponBodyElement self, int level);
		public static Dictionary<int, int> GetLimitBreakMaterialByLimitCount(this WeaponBodyElement self, int limitbreak);
		public static Dictionary<int, int> GetEquipableCountMaterialByReleaseCount(this WeaponBodyElement self, int count);
		public static WeaponBodyBuildupGroupElement[] GetWeaponBodyBuildupGroupDatas(this WeaponBodyElement self, BuildupPieceType pieceType = BuildupPieceType.NONE);
		public static int GetWeaponSkinIdBySkinNo(this WeaponBodyElement self, int skinNo);
		public static int ConvertAbilityNoToAbilityDataId(this WeaponBodyElement self, int abilityNo);
		public static int GetWeaponSkinId(this WeaponBodyElement self, int limitOverCount);
	}
}
