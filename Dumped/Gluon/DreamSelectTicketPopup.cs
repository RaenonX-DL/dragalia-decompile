using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DreamSelectTicketPopup : PopupBase
	{
		public const string path = "Prefabs/OutGame/ShopTrade/Popup/DreamSelectTicketPopup";

		[SerializeField]
		private DreamSelectTicketCtrl[] tabCtrls;

		[SerializeField]
		private TabBase tabView;

		[SerializeField]
		private float sortButtonPosY;

		[SerializeField]
		private Text titleText;

		[HideInInspector]
		public ItemListPopup itemListPopup;

		private CommonSortButton sortButton;

		private int ticketId;

		private GiftTextLoader.NameAndDescription unitData;

		private CommonSortModel.Condition prevSortModelCondition;

		private Func<CommonListCustomSortData, CommonListCustomSortData> prevCustomSortAction;

		public static DreamSelectTicketPopup Create(int ticketId)
		{
			return null;
		}

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		private List<ulong> CreateDataIdList(GiftType giftType)
		{
			return null;
		}

		private void OnSortButtonClicked()
		{
		}

		private void UpdateSortAndFilter(int tabViewIndex)
		{
		}

		public void OnClickButton(GiftType giftType, int unitId)
		{
		}

		private void OnSummonRequest(GiftType giftType, int unitId)
		{
		}

		private Task<ExchangeGetUnitListResponse> ExchangeGetUnitListRequest(int ticketId)
		{
			return null;
		}

		private Task<ExchangeSelectUnitResponse> ExchangeSelectUnitRequest(int ticketId, GiftType giftType, int id)
		{
			return null;
		}
	}
}
