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
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePresentListPopup : CommonPopup
	{
		// Fields
		public TypeTab currentTypeTab;
		[SerializeField]
		private MyPagePresentListController baseListController;
		[SerializeField]
		private TabBase typeTabBase;
		[SerializeField]
		private UnityEngine.UI.Text warningText;
		[SerializeField]
		private Badge LimitBadge;
		[SerializeField]
		private Badge NormalBadge;
		private MyPagePresentListController[] listController;
		private List<MyPagePresentListCellData>[] cellDataList;
		private bool[] isAllAdded;
		private bool isWaitingResponse;
		private const string prefabPath = "Prefabs/OutGame/Present/MyPagePresentListPopup";
		private const int PresentMessageMaterialShopByItemId = 2120002;
		public static readonly Localize.TextId[] CategoryNameTextId;
		public static readonly Localize.TextId[] NextSceneButtonNameTextId;
		public static TutorialUIManager.LockButtonType[] NextSceneLockButtonType;
	
		// Nested types
		public enum TypeTab
		{
			None = -1,
			Limit = 0,
			Normal = 1,
			History = 2,
			Max = 3
		}
	
		public enum ItemCategory
		{
			None = -1,
			Diamond = 0,
			Crystal = 1,
			Coin = 2,
			Mana = 3,
			DewPoint = 4,
			Chara = 5,
			Weapon = 6,
			Amulet = 7,
			Dragon = 8,
			Material = 9,
			Treasure = 10,
			EventItem = 11,
			Valuable = 12,
			RecoveryItem = 13,
			Facility = 14,
			Stamp = 15,
			AnotherName = 16,
			DragonGift = 17,
			SkipTicket = 18,
			AstralItem = 19,
			DragonHammer = 20,
			LotteryLetter = 21,
			Other = 22,
			WeaponSkin = 23,
			Ticket = 24,
			ProvMax = 24,
			Max = 25
		}
	
		public enum NextScenePattern
		{
			Summon = 0,
			Shop = 1,
			Fort = 2,
			Formation = 3,
			PowerUp = 4,
			TradePrace = 5,
			Item = 6,
			DragonGarden = 7,
			Stamp = 8,
			AnotherName = 9,
			TicketTrade = 10,
			EventTop = 11,
			Quest = 12,
			Max = 13
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__22_0;
			public static UnityAction __9__22_1;
			public static Comparison<PresentDetailList> __9__23_0;
			public static Comparison<PresentHistoryList> __9__23_1;
			public static Action __9__33_7;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InitSetting_b__22_0();
			internal void _InitSetting_b__22_1();
			internal int _SetListData_b__23_0(PresentDetailList a, PresentDetailList b);
			internal int _SetListData_b__23_1(PresentHistoryList a, PresentHistoryList b);
			internal void _GetNextSceneCallback_b__33_7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public UnityAction successCallback;
			public UnityAction __9__2;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _RequestAllListData_b__0();
			internal void _RequestAllListData_b__1();
			internal void _RequestAllListData_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public ulong startPresentId;
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _RequestListData_b__0(PresentGetPresentListResponse res);
			internal void _RequestListData_b__1(PresentGetHistoryListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public UnityAction successCallback;
			public UnityAction errorCallback;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _RequestReceivePresent_b__0(PresentReceiveResponse res);
			internal void _RequestReceivePresent_b__1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public UnityAction closeCallback;
			public Footer.MenuTab nextMenuTab;
			public string nextSceneName;
			public UnityAction __9__8;
			public Action __9__9;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _GetNextSceneCallback_b__0();
			internal void _GetNextSceneCallback_b__1();
			internal void _GetNextSceneCallback_b__2();
			internal void _GetNextSceneCallback_b__3();
			internal void _GetNextSceneCallback_b__4();
			internal void _GetNextSceneCallback_b__8();
			internal void _GetNextSceneCallback_b__5();
			internal void _GetNextSceneCallback_b__6();
			internal void _GetNextSceneCallback_b__9();
		}
	
		// Constructors
		public MyPagePresentListPopup();
		static MyPagePresentListPopup();
	
		// Methods
		protected override void OnDestroy();
		public static int GetLimitPresentCount();
		public static int GetNormalPresentCount();
		public static MyPagePresentListPopup Create();
		public void InitSetting(TypeTab type = TypeTab.Limit);
		private void SetListData(TypeTab type);
		public void LoadListData(TypeTab tabType);
		private void SetTypeTab(int typeIndex);
		public static void RequestAllListData(UnityAction successCallback = null);
		private static void RequestListData(TypeTab type, UnityAction successCallback = null, ulong startPresentId = 0);
		public static void RequestReceivePresent(ulong[] presentIdList, bool isLimit, UnityAction successCallback, UnityAction errorCallback = null);
		public static void OnError(ErrorType errorType, int resultCode);
		private void ListOnButtonPressed(MyPagePresentListCellData cellData);
		public static ItemCategory ConvertToItemCategory(GiftType type, int id);
		public static NextScenePattern[] GetNextSceneFromItemCategory(ItemCategory itemCategory, bool isSummonTicket = false);
		public static UnityAction GetNextSceneCallback(NextScenePattern nextScenePattern, UnityAction closeCallback);
		public static string GetPresentMessage(int messageId, int[] messageValues, out string title);
		public void ShowOtherDetail(MyPagePresentListCellData data, Canvas[] popupCanvases);
		public override void OnOkButtonPressed();
		private static bool IsBuyedOneItemOnShopPresentMessage(PresentMessageElement messageData, int materialShopDataId);
		[CompilerGenerated]
		private void _InitSetting_b__22_2(bool isExcessScrollForBottomDirection);
		[CompilerGenerated]
		private void _InitSetting_b__22_3();
	}
}
