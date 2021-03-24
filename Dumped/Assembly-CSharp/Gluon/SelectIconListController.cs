/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SelectIconListController : SelectIconListControllerBase
	{
		// Fields
		public static SelectListType listType;
		public static SelectedItemData selectedItem;
		public Action<List<ulong>> onSelectionChanged;
		public SelectListCanvas mainCanvas;
		[SerializeField]
		private SelectIconListBase selectIconListBase;
		[SerializeField]
		private Button decideButton;
		private SelectIconListController listController;
		public const string prefabDir = "Prefabs/OutGame/SelectList/";
		private IEnumerator loadUnitDetailCoroutine;
		[CompilerGenerated]
		private int _dataListCount_k__BackingField;
	
		// Properties
		public int dataListCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class SelectedItemData
		{
			// Fields
			public List<int> candidateIdList;
			public int selectedId;
			public int limitBreakCount;
			public int maxCount;
			public List<ulong> tempKeyIds;
			private ulong keyId;
	
			// Constructors
			public SelectedItemData();
	
			// Methods
			public void Clear();
			public void AddCandidateId(int id);
			public bool IsEnable(int id);
			public bool IsValid(ShopTradeProductData.TradeShopItemData.NeedMaterialInfo info);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public SelectIconListController __4__this;
			public CommonIconListCellData data;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadScene_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SelectIconListController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadScene_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SelectIconListController();
		static SelectIconListController();
	
		// Methods
		protected override void Start();
		private int SelectTargetListSort(ConfigDialogSortData currCell, ConfigDialogSortData nextCell);
		protected override void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void UpdateSelectFrameInfo();
		private void SelectFrameResetPresed();
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		[IteratorStateMachine]
		private IEnumerator UnloadScene();
		private void ListTabButtonPressed();
		private void LoadListData();
		private ulong[] CreateDataIdList(out GiftType giftType, int id, int limitBreakCount);
		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyId, int decoNum);
		protected override void UpdateContents();
		public ulong[] GetAutoSelectKeys(int maxSelect);
		private void ResetSelectInfo();
		protected override void UnSelectIcon(ulong targetKey);
		public void OnSortApplied();
		public void OnSortButtonClicked();
		[CompilerGenerated]
		private bool _UnloadScene_b__20_0();
	}
}
