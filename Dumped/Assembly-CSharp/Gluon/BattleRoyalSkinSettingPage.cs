/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalSkinSettingPage : EventQuestPageBase
	{
		// Fields
		public UnitDetail2dModel unit2dModel;
		public RawImage charaSkinIcon;
		public RawImage weaponSkinIcon;
		private WeaponType charaWeaponType;
	
		// Constructors
		public BattleRoyalSkinSettingPage();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		private void SetupCharaImage();
		private void SetupWeaponIcon();
		public override void OnPageEnterAnimationEnded();
		public void OnCharaSkinChangeButtonPressed();
		public void OnWeaponSkinChangeButtonPressed();
		private void OnBackButtonTouched();
		[CompilerGenerated]
		private void _OnCharaSkinChangeButtonPressed_b__8_0();
		[CompilerGenerated]
		private void _OnWeaponSkinChangeButtonPressed_b__9_0();
	}
}
