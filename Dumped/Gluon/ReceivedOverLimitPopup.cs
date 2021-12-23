using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ReceivedOverLimitPopup : PopupBase
	{
		public struct ItemData
		{
			public int id;

			public int quantity;

			public GiftType giftType;

			public GiftSort giftSort;

			public int sortId;

			public GroupType groupType;

			public void UpdateSortParam()
			{
			}
		}

		private enum State
		{
			None = -1,
			Discard,
			DiscardOneOff,
			ToPresent,
			Max
		}

		public enum GiftSort
		{
			None = -1,
			Diamond,
			Crystal,
			Money,
			ManaPoint,
			Chara,
			Weapon,
			Amulet,
			Talisman,
			Dragon,
			Material,
			Item,
			FortAsset,
			Stamp,
			Title,
			SummonTicket,
			ExchangeTicket,
			DragonGift,
			RaidEventItem,
			MazeEventItem,
			BuildEventItem,
			Clb01EventItem,
			CollectEventItem,
			LotteryTicket,
			GatherItem,
			ExRushEventItem,
			ExHunterEventItem,
			BattleRoyalEventItem,
			Max
		}

		public enum GroupType
		{
			None = -1,
			Money = 0,
			Diamond = 1,
			Crystal = 2,
			ManaPoint = 3,
			Weapon = 4,
			Amulet = 5,
			Dragon = 6,
			Talisman = 7,
			ToPresentMax = 8,
			DiscardMax = 4
		}

		private const string prefabPath = "Prefabs/OutGame/Item/ReceivedOverLimitPopup";

		public static bool withUpdatedOpen;

		public UnityAction onCloseCallback;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text infoText;

		[SerializeField]
		[Header("å\u008d\u0098å\u0093\u0081å\u008f\u0097å\u008f\u0096")]
		private GameObject singleReceivedArea;

		[SerializeField]
		private CommonIcon singleItemIcon;

		[SerializeField]
		private Text singleItemName;

		[SerializeField]
		[Header("è¤\u0087æ\u0095°å\u008f\u0097å\u008f\u0096")]
		private GameObject multiReceivedArea;

		[SerializeField]
		private ReceivedOverLimitListController multiReceivedListController;

		private const float showListInfoTextUpper = 16f;

		private State popupState;

		private Localize.TextId[] GroupNameTextId;

		public static ReceivedOverLimitPopup Create()
		{
			return null;
		}

		public void InitSetting(List<ItemData>[] items)
		{
		}

		private void SetItem(List<ItemData> items, bool isDiscard = true)
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		private static bool IsShowItem(AtgenBuildEventRewardEntityList discardList)
		{
			return default(bool);
		}

		public static bool CheckReceivedOverLimit()
		{
			return default(bool);
		}

		public static bool IsEnableList(List<ItemData>[] list)
		{
			return default(bool);
		}

		public static ReceivedOverLimitPopup CreateReceivedOverLimitPopupIfOverLimit()
		{
			return null;
		}

		public static List<ItemData>[] CreateItemsList()
		{
			return null;
		}

		private static void AddItemData(AtgenBuildEventRewardEntityList item, List<ItemData>[] itemsList)
		{
		}

		public static bool CheckReceivedOverDirectLimit(int id, GiftType type)
		{
			return default(bool);
		}

		public static bool CheckReceivedOverNotDragonCharaLimit(bool withCreatePopup = false)
		{
			return default(bool);
		}

		public static List<ItemData>[] CreateOverDirectList(int id, GiftType type)
		{
			return null;
		}

		public static List<ItemData>[] CreateOverNotDoragonCharaEntityList()
		{
			return null;
		}
	}
}
