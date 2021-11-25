using System.Collections.Generic;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class ItemListPopup : CommonPopup
	{
		public enum TypeTab
		{
			None = -1,
			Useful,
			Material,
			Max
		}

		private enum CaptionCategory
		{
			Funds,
			RecoveryItem,
			Ticket,
			PowerUpMaterial,
			Treasure,
			Valuable,
			Other,
			Max
		}

		private struct SummonTicket
		{
			public SummonTicketElement element;

			public int count;

			public int uselimit;
		}

		private struct ExchangeTicket
		{
			public ExchangeTicketElement element;

			public int count;
		}

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

		public static ItemListPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		private void RecreateItemListPopup()
		{
		}

		public void SetListData()
		{
		}

		private void SetTypeTab(int typeIndex)
		{
		}

		private void CreateItemDetailPopup(ItemListCellData data)
		{
		}

		public void CreateItemUseLimitOverPopup()
		{
		}

		private void CreateRecoveryDetailPopup(ItemListCellData data)
		{
		}

		private void AddCaptionCellData(CaptionCategory category, int typeNum)
		{
		}

		private void RequestGetItemList(UnityAction successCallback)
		{
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
