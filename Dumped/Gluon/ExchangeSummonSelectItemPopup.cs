using System;
using System.Collections.Generic;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExchangeSummonSelectItemPopup : PopupBase
	{
		[SerializeField]
		private ExchangeSummonSelectItemCtrl[] tabCtrls;

		[SerializeField]
		private TabBase tabView;

		[SerializeField]
		private Text detailText;

		[SerializeField]
		private Text periodText;

		[SerializeField]
		private Transform sortButtonArea;

		[SerializeField]
		private Text nowSummonPointText;

		private CommonSortButton sortButton;

		private int summonId;

		private SummonDataElement sde;

		private SummonPointDataElement spde;

		private bool isSentToPresentBox;

		private DateTime endScheduleDateTime;

		public Action onClose;

		public static ExchangeSummonSelectItemPopup Create(int summonId, DateTime completeDateTime)
		{
			return null;
		}

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Request(int summonId)
		{
		}

		public void UpdateItemList()
		{
		}

		public void OnSummonSummonPointTradeRequestError(ErrorType errorType, int errorCode)
		{
		}

		private List<ulong> CreateDataIdList(GiftType giftType)
		{
			return null;
		}

		private void UpdateSortAndFilter(int tabViewIndex)
		{
		}

		private void OnSortButtonClicked()
		{
		}

		public void OnSummonClick(ExchangeSummonSelectItemCellData data)
		{
		}

		public void OnExchangeSuccess(int summonId, int id, int giftType)
		{
		}

		public void ExchangePopupClose()
		{
		}
	}
}
