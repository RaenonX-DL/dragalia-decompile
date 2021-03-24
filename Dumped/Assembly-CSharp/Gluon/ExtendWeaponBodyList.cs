/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ExtendWeaponBodyList
	{
		// Extension methods
		public static bool CanBuildupUptoNextLevel(this WeaponBodyList self);
		public static bool CanLimitBreak(this WeaponBodyList self);
		public static bool CanLimitOver(this WeaponBodyList self);
		public static bool CanReleaseWeaponPassiveAbility(this WeaponBodyList self);
		public static bool CanReleaseCrestSlot(this WeaponBodyList self);
		public static bool CanReleaseWeaponBonus(this WeaponBodyList self);
		public static bool CanReleaseEquipableCount(this WeaponBodyList self);
		public static int[] GetReleasedWeaponPassiveAbilityNoList(this WeaponBodyList self);
		public static int GetEquipableCountSatisfyReleaseCondition(this WeaponBodyList self);
		public static bool HasSlot(this WeaponBodyList self, int slotIndex);
		public static bool IsEnableSlot(this WeaponBodyList self, int slotIndex);
		public static bool IsUsableSlot(this WeaponBodyList self, int slotIndex);
	}
}
