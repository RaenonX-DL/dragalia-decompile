/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WeaponPassiveAbilityIcon : CommonIcon
	{
		// Fields
		public UnityEngine.UI.Text selectCountText;
		public GameObject selectCountImageGO;
		public GameObject blackMaskObject;
		private WeaponPassiveAbilityListCellData cellData;
		private GameObject releasableEffectObject;
	
		// Constructors
		public WeaponPassiveAbilityIcon();
	
		// Methods
		public void SetupAbilityIcon(WeaponPassiveAbilityListCellData data);
		private void ShowAbilityDetailPopup();
		private void SetSelectCount(int count);
		private void PlayReleasablePieceEffect();
		private void DestroyReleasablePieceEffect();
	}
}
