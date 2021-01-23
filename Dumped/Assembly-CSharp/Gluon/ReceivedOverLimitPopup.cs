/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ReceivedOverLimitPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Item/ReceivedOverLimitPopup";
		public static bool withUpdatedOpen;
		public UnityAction onCloseCallback;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		[Header]
		[SerializeField]
		private GameObject singleReceivedArea;
		[SerializeField]
		private CommonIcon singleItemIcon;
		[SerializeField]
		private UnityEngine.UI.Text singleItemName;
		[Header]
		[SerializeField]
		private GameObject multiReceivedArea;
		[SerializeField]
		private ReceivedOverLimitListController multiReceivedListController;
		private const float showListInfoTextUpper = 16f;
		private State popupState;
		private Localize.TextId[] GroupNameTextId;
	
		// Nested types
		public struct ItemData
		{
			// Fields
			public int id;
			public int quantity;
			public GiftType giftType;
			public GiftSort giftSort;
			public int sortId;
			public GroupType groupType;
	
			// Methods
			public void UpdateSortParam();
		}
	
		private enum State
		{
			None = -1,
			Discard = 0,
			DiscardOneOff = 1,
			ToPresent = 2,
			Max = 3
		}
	
		public enum GiftSort
		{
			None = -1,
			Diamond = 0,
			Crystal = 1,
			Money = 2,
			ManaPoint = 3,
			Chara = 4,
			Weapon = 5,
			Amulet = 6,
			Dragon = 7,
			Material = 8,
			Item = 9,
			FortAsset = 10,
			Stamp = 11,
			Title = 12,
			SummonTicket = 13,
			ExchangeTicket = 14,
			DragonGift = 15,
			RaidEventItem = 16,
			MazeEventItem = 17,
			BuildEventItem = 18,
			Clb01EventItem = 19,
			CollectEventItem = 20,
			LotteryTicket = 21,
			GatherItem = 22,
			ExRushEventItem = 23,
			ExHunterEventItem = 24,
			BattleRoyalEventItem = 25,
			Max = 26
		}
	
		public enum GroupType
		{
			None = -1,
			Money = 0,
			Diamond = 1,
			Crystal = 2,
			ManaPoint = 3,
			Weapon = 4,
			DiscardMax = 4,
			Amulet = 5,
			Dragon = 6,
			ToPresentMax = 7
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public List<ItemData> discardItems;
			public List<ItemData> discardOneOffItems;
			public List<ItemData> toPresentItems;
			public List<ItemData>[] items;
			public ReceivedOverLimitPopup __4__this;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _InitSetting_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<ItemData> __9__25_0;
			public static Comparison<ItemData> __9__25_1;
			public static Comparison<ItemData> __9__25_2;
			public static Comparison<ItemData> __9__30_0;
			public static Comparison<ItemData> __9__30_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _CreateItemsList_b__25_0(ItemData a, ItemData b);
			internal int _CreateItemsList_b__25_1(ItemData a, ItemData b);
			internal int _CreateItemsList_b__25_2(ItemData a, ItemData b);
			internal int _CreateOverNotDoragonCharaEntityList_b__30_0(ItemData a, ItemData b);
			internal int _CreateOverNotDoragonCharaEntityList_b__30_1(ItemData a, ItemData b);
		}
	
		// Constructors
		public ReceivedOverLimitPopup();
		static ReceivedOverLimitPopup();
	
		// Methods
		public static ReceivedOverLimitPopup Create();
		public void InitSetting(List<ItemData>[] items);
		private void SetItem(List<ItemData> items, bool isDiscard = true);
		public void OnCloseButtonPressed();
		private static bool IsShowItem(AtgenBuildEventRewardEntityList discardList);
		public static bool CheckReceivedOverLimit();
		public static bool IsEnableList(List<ItemData>[] list);
		public static ReceivedOverLimitPopup CreateReceivedOverLimitPopupIfOverLimit();
		public static List<ItemData>[] CreateItemsList();
		private static void AddItemData(AtgenBuildEventRewardEntityList item, List<ItemData>[] itemsList);
		public static bool CheckReceivedOverDirectLimit(int id, GiftType type);
		public static bool CheckReceivedOverNotDragonCharaLimit(bool withCreatePopup = false);
		public static List<ItemData>[] CreateOverDirectList(int id, GiftType type);
		public static List<ItemData>[] CreateOverNotDoragonCharaEntityList();
	}
}
