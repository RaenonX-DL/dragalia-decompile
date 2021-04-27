/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemListPopup : CommonPopup
	{
		// Fields
		public TypeTab currentTypeTab;
		[SerializeField]
		private ItemListController baseListController;
		[SerializeField]
		private TabBase typeTabBase;
		private bool[] isShowCaptionCell;
		private ItemListController[] listController;
		private List<ItemListCellData>[] cellDataList;
		private const string prefabPath = "Prefabs/OutGame/Item/ItemListPopup";
		private readonly Localize.TextId[] CaptionCategoryTextId;
	
		// Nested types
		public enum TypeTab
		{
			None = -1,
			Useful = 0,
			Material = 1,
			Max = 2
		}
	
		private enum CaptionCategory
		{
			Funds = 0,
			RecoveryItem = 1,
			Ticket = 2,
			PowerUpMaterial = 3,
			Treasure = 4,
			Valuable = 5,
			Other = 6,
			Max = 7
		}
	
		private struct SummonTicket
		{
			// Fields
			public SummonTicketElement element;
			public int count;
			public int uselimit;
		}
	
		private struct ExchangeTicket
		{
			// Fields
			public ExchangeTicketElement element;
			public int count;
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<UseItemElement> __9__15_0;
			public static Func<SummonTicket, int> __9__15_1;
			public static Func<SummonTicket, int> __9__15_2;
			public static Func<ExchangeTicket, int> __9__15_3;
			public static Func<AstralItemElement, int> __9__15_4;
			public static Comparison<MaterialDataElement> __9__15_5;
			public static Comparison<DragonGiftDataElement> __9__15_6;
			public static Comparison<GatherItemElement> __9__15_7;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetListData_b__15_0(UseItemElement a, UseItemElement b);
			internal int _SetListData_b__15_1(SummonTicket x);
			internal int _SetListData_b__15_2(SummonTicket x);
			internal int _SetListData_b__15_3(ExchangeTicket x);
			internal int _SetListData_b__15_4(AstralItemElement x);
			internal int _SetListData_b__15_5(MaterialDataElement a, MaterialDataElement b);
			internal int _SetListData_b__15_6(DragonGiftDataElement a, DragonGiftDataElement b);
			internal int _SetListData_b__15_7(GatherItemElement a, GatherItemElement b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public ItemListPopup __4__this;
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _CreateItemUseLimitOverPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _RequestGetItemList_b__0(ItemGetListResponse res);
		}
	
		// Constructors
		public ItemListPopup();
	
		// Methods
		public static ItemListPopup Create();
		public void InitSetting();
		private void RecreateItemListPopup();
		public void SetListData();
		private void SetTypeTab(int typeIndex);
		private void CreateItemDetailPopup(ItemListCellData data);
		public void CreateItemUseLimitOverPopup();
		private void CreateRecoveryDetailPopup(ItemListCellData data);
		private void AddCaptionCellData(CaptionCategory category, int typeNum);
		private void RequestGetItemList(UnityAction successCallback);
		public void OnError(ErrorType errorType, int resultCode);
	}
}
