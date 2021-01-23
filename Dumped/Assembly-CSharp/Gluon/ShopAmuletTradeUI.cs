/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopAmuletTradeUI : ShopTradePanelBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private ShopTableViewTradeAmuletCtrl[] tabCtrls;
		[SerializeField]
		private TabBase tabView;
		[SerializeField]
		private UnityEngine.UI.Text curDewText;
		[SerializeField]
		private UnityEngine.UI.Text refreshText;
		[SerializeField]
		private Transform sortParentTransform;
		[SerializeField]
		private Vector2 sortButtonPos;
		[SerializeField]
		private GameObject emptyTextObject;
		private CommonSortButton sortButton;
		[SerializeField]
		private CommonTagSearch tagSearch;
		protected List<CommonIconListCellData> originalTableData;
		[CompilerGenerated]
		private ulong[] _originalKeyIdList_k__BackingField;
		[CompilerGenerated]
		private ShopTradeProductData.CommonShopItemData _itemData_k__BackingField;
	
		// Properties
		public ulong[] originalKeyIdList { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ShopTradeProductData.CommonShopItemData itemData { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public Action onHttpDoneCallback;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _RequestForEntryHttp_b__0(AbilityCrestTradeGetListResponse res);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<int, ulong> __9__21_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal ulong _OnInputFilterChanged_b__21_0(int x);
		}
	
		// Constructors
		public ShopAmuletTradeUI();
	
		// Methods
		public static ShopAmuletTradeUI Create(Transform parent, ShopTradeScene scene);
		public static void RequestForEntryHttp(Action onHttpDoneCallback);
		private void Awake();
		private void OnInputFilterChanged(List<int> filteredId);
		private void OnEnable();
		private void OnDisable();
		protected void Start();
		private void InitAbilityCrestTradeDataDictionary();
		private void OnSortButtonClicked();
		private void UpdateSortAndFilter(int tabViewIndex);
		public void OnChangeButtonTouched();
		private void SetRefreshText();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public override void RefreshCurrentPage();
		public void OnRecommendedButton();
		[CompilerGenerated]
		private void _Start_b__24_1(int tabDataCount);
		[CompilerGenerated]
		private void _Start_b__24_0(int index, bool calledFromUI);
		[CompilerGenerated]
		private void _OnSortButtonClicked_b__26_0();
	}
}
