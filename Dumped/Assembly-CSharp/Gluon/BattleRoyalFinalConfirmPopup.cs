/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalFinalConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Graphic icon;
		public Graphic jobIcon;
		public UnityEngine.UI.Text jobTitle;
		public UnityEngine.UI.Text jobDescription;
		public GameObject[] selectJobGOs;
		public GameObject[] goShopGOs;
		private Mode mode;
		private WeaponType selectedWeaponType;
		private Action<bool> onDone;
		private AnimationUICanvas.AnimationPattern exitPattern;
	
		// Nested types
		public enum Mode
		{
			SelectJob = 0,
			GoShop = 1
		}
	
		// Constructors
		public BattleRoyalFinalConfirmPopup();
	
		// Methods
		public static BattleRoyalFinalConfirmPopup Create(Mode mode, WeaponType selectedWeaponType, Action<bool> onDone, AnimationUICanvas.AnimationPattern nowPageExitPattern = AnimationUICanvas.AnimationPattern.Pattern_1);
		private void Setup(Mode mode, WeaponType selectedWeaponType, Action<bool> onDone, AnimationUICanvas.AnimationPattern exitPattern);
		public void OnDecided();
		public void OnCancel();
	}
}
