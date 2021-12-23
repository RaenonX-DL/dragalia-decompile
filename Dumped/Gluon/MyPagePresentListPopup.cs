using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPagePresentListPopup : CommonPopup
	{
		public enum TypeTab
		{
			None = -1,
			Limit,
			Normal,
			History,
			Max
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
			Stamp = 0xF,
			AnotherName = 0x10,
			DragonGift = 17,
			SkipTicket = 18,
			AstralItem = 19,
			DragonHammer = 20,
			LotteryLetter = 21,
			Other = 22,
			WeaponSkin = 23,
			Talisman = 24,
			ExchangeTicket = 25,
			Dpoint = 26,
			Ticket = 27,
			Max = 28,
			ProvMax = 27
		}

		public enum NextScenePattern
		{
			Summon,
			Shop,
			Fort,
			Formation,
			PowerUp,
			TradePrace,
			Item,
			DragonGarden,
			Stamp,
			AnotherName,
			TicketTrade,
			EventTop,
			Quest,
			Dmode,
			Max
		}

		public TypeTab currentTypeTab;

		[SerializeField]
		private MyPagePresentListController baseListController;

		[SerializeField]
		private TabBase typeTabBase;

		[SerializeField]
		private Text warningText;

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

		protected override void OnDestroy()
		{
		}

		public static int GetLimitPresentCount()
		{
			return default(int);
		}

		public static int GetNormalPresentCount()
		{
			return default(int);
		}

		public static MyPagePresentListPopup Create()
		{
			return null;
		}

		public void InitSetting(TypeTab type = TypeTab.Limit)
		{
		}

		private void SetListData(TypeTab type)
		{
		}

		public void LoadListData(TypeTab tabType)
		{
		}

		private void SetTypeTab(int typeIndex)
		{
		}

		public static void RequestAllListData([Optional] UnityAction successCallback)
		{
		}

		private static void RequestListData(TypeTab type, [Optional] UnityAction successCallback, ulong startPresentId = 0uL)
		{
		}

		public static void RequestReceivePresent(ulong[] presentIdList, bool isLimit, UnityAction successCallback, [Optional] UnityAction errorCallback)
		{
		}

		public static void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void ListOnButtonPressed(MyPagePresentListCellData cellData)
		{
		}

		public static ItemCategory ConvertToItemCategory(GiftType type, int id)
		{
			return default(ItemCategory);
		}

		public static NextScenePattern[] GetNextSceneFromItemCategory(ItemCategory itemCategory, bool isSummonTicket = false)
		{
			return null;
		}

		public static UnityAction GetNextSceneCallback(NextScenePattern nextScenePattern, UnityAction closeCallback)
		{
			return null;
		}

		public static string GetPresentMessage(int messageId, int[] messageValues, out string title)
		{
			return null;
		}

		public void ShowOtherDetail(MyPagePresentListCellData data, Canvas[] popupCanvases)
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		private static bool IsBuyedOneItemOnShopPresentMessage(PresentMessageElement messageData, int materialShopDataId)
		{
			return default(bool);
		}
	}
}
