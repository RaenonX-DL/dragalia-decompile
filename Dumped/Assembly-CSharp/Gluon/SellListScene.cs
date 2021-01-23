/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SellListScene : SceneBase
	{
		// Fields
		public static SellListType listType;
		public static SellListActionType listActionType;
		public const string prefabDir = "Prefabs/OutGame/SellList/";
		public const int maxSellCount = 50;
		public SellListCanvas mainCanvas;
		private SellIconListBase sellIconListBase;
		private SellModeFrame sellModeFrame;
		private SellIconListController listController;
		private List<ulong> selectKeys;
		private bool isAllListIconLock;
		private Canvas gardCanvas;
		private List<ConfigDialogSortData> selectUserData;
		private long totalSellGold;
		private int totalSellMoon;
		private long beforeGold;
		private int beforeMoon;
		private Button sceneBackButton;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__19_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UnloadScene_b__19_0();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadScene_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SellListScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadScene_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public SellListScene __4__this;
			public CommonIconListCellData data;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _IconButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public SellListScene __4__this;
			public CommonIconListCellData data;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public SellListScene __4__this;
			public SellConfigDialog sellConfigDialog;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _SellFrameSellPressed_b__0();
			internal void _SellFrameSellPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public SellListScene __4__this;
			public SellConfigDialog sellCompleteDialog;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _ShowSellCompleteDialog_b__0();
		}
	
		// Constructors
		public SellListScene();
		static SellListScene();
	
		// Methods
		private void Start();
		private void OnDestroy();
		[IteratorStateMachine]
		private IEnumerator UnloadScene();
		public override void OnPresentReceived();
		public void BackButtonPressed();
		public void SetNoSelectableIconLayout(bool noSelectable);
		private bool IsEnableTotalMoon();
		private void SetCaption();
		private void LoadListData();
		public void OnSortButtonClicked();
		public void OnSortApplied();
		private ulong[] CreateDataIdList(out GiftType giftType);
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void UpdateEquipIconLock(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void UnSelectIcon(ulong targetKey);
		private void ListTabButtonPressed();
		private void SellModeButtonPressed();
		private void ResetSellInfo();
		private void UpdateSelectIconNumber();
		public int CheckSelectIcon(ulong keyId);
		private void UpdateSellFrameInfo();
		private void SellFrameResetPresed();
		private void SellFrameBackPresed(bool skipListReload);
		private void SellFrameAutoPressed();
		private void SellFrameSellPressed();
		private int SellTargetListSort(ConfigDialogSortData currCell, ConfigDialogSortData nextCell);
		private void DoAutoSelect();
		private void SendSellData();
		public void SendDataOnSuccess(DragonSellResponse res);
		public void SendDataOnSuccess(WeaponSellResponse res);
		public void SendDataOnSuccess(AmuletSellResponse res);
		private void ShowSellCompleteDialog();
		public void OnListChangeButtonPressed();
		[CompilerGenerated]
		private void _SellModeButtonPressed_b__34_0();
		[CompilerGenerated]
		private int _SellFrameAutoPressed_b__41_0();
	}
}
