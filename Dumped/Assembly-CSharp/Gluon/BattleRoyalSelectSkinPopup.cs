/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalSelectSkinPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public RectTransform layoutParent;
		public RawImage selectedIcon;
		public BattleRoyalSkinCell templateCell;
		public UnityEngine.UI.Text comment;
		public int maxAnimCount;
		private WeaponType selectedWeaponType;
		private int selectedSkinId;
		private List<BattleRoyalSkinCell> cellList;
		private Action onDone;
	
		// Constructors
		public BattleRoyalSelectSkinPopup();
	
		// Methods
		public static BattleRoyalSelectSkinPopup Create(WeaponType selectedWeaponType, Action onDone);
		private void Setup(WeaponType selectedWeaponType, Action onDone);
		private void OnIconPressed(int skinId);
		private void UpdateSelectedIcon(int skinId);
		public void OnOKButtonPressed();
		public void OnCancelButtonPressed();
	}
}
