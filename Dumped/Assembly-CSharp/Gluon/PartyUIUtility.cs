/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class PartyUIUtility
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Image iconImage;
			public Image plusIcon;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _SetCrestIconAsync_b__1(Material iconMaterial);
			internal void _SetCrestIconAsync_b__0(Material iconMaterial);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public SkillAbilityDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _ShowSkill3Detail_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public SkillAbilityDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _ShowSkill4Detail_b__0();
		}
	
		// Methods
		public static int GetAbility1KeyId(CharaList character, CharaDataElement masterCharaData);
		public static int GetAbility2KeyId(CharaList character, CharaDataElement masterCharaData);
		public static int GetAbility3KeyId(CharaList character, CharaDataElement masterCharaData);
		public static int GetAbility1KeyId(WeaponDataElement masterWeaponData);
		public static int GetAbility2KeyId(WeaponDataElement masterDragonData);
		public static void SetRarityStar(Rarity rarity, GameObject[] rarityIcons);
		public static void SetCrestIconAsync(int keyId, int slotIndex, IconLoader.Size iconSize, Image iconImage, Image plusIcon);
		public static void ShowDragonDetail(int charactorIndex);
		public static void ShowWeaponDetail(int charactorIndex);
		public static void ShowCrestDetail(int charactorIndex, int crestIndex);
		public static void ShowSkill3Detail(int charactorIndex);
		public static void ShowSkill4Detail(int charactorIndex);
		public static void AdjustExitAnimationOffset(UIAnimationInnerMove animationBase, UIAnimationSetting animationSetting, float offsetY);
		public static bool HasEquipSkill(int charaId, bool isCheckAvailable = false);
		public static int GetDefaultSkill3CharaId(int targetIndexInParty);
		public static int GetDefaultSkill4CharaId(int targetIndexInParty);
		public static int GetDefaultSkill3CharaId(PartySettingList partySettingList);
		public static int GetDefaultSkill4CharaId(PartySettingList partySettingList);
	}
}
