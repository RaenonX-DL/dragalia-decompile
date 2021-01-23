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
		public BattleRoyalCharaSkinIconListController charaSkinIconListController;
		public WeaponSkinSelectListController weaponSkinListController;
		public UnityEngine.UI.Text popupTitle;
		public UnityEngine.UI.Text comment;
		public int maxAnimCount;
		private WeaponType selectedWeaponType;
		private int selectedSkinId;
		private List<BattleRoyalSkinCell> cellList;
		private GiftType skinType;
		private Action onDone;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public BattleRoyalCharaSkinIconListCellData cellData;
			public BattleRoyalSelectSkinPopup __4__this;
			public Action<int> __9__2;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _OnCharaIconButtonPressed_b__2(int charaSkinId);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_1
		{
			// Fields
			public BattleRoyalReleaseCharaSkinConfirmPopup popup;
			public __c__DisplayClass22_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass22_1();
	
			// Methods
			internal void _OnCharaIconButtonPressed_b__0();
			internal void _OnCharaIconButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_2
		{
			// Fields
			public BattleRoyalReleaseCharaSkinConfirmPopup popup;
			public __c__DisplayClass22_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass22_2();
	
			// Methods
			internal void _OnCharaIconButtonPressed_b__3();
			internal void _OnCharaIconButtonPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_3
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass22_3();
	
			// Methods
			internal void _OnCharaIconButtonPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public BattleRoyalReleaseCharaSkinResultPopup popup;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _ShowSkinReleaseResultPopup_b__0();
		}
	
		// Constructors
		public BattleRoyalSelectSkinPopup();
	
		// Methods
		public static BattleRoyalSelectSkinPopup Create(WeaponType selectedWeaponType, GiftType type, Action onDone);
		private void Setup(WeaponType selectedWeaponType, GiftType skinType, Action onDone);
		private void OnIconPressed(int skinId);
		private void UpdateSelectedIcon(int skinId);
		public void OnOKButtonPressed();
		public void OnCancelButtonPressed();
		private void SetupCharaSkinList();
		private void SetupWeaponSkinList();
		private ulong[] GetCharaSkinListIds();
		private int[] GetWeaponSkinListIds();
		private void OnCharaIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void ShowSkinReleaseResultPopup(int charaSkinId);
		private void OnWeaponIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
	}
}
