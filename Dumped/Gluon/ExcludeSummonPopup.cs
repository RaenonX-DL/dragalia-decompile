using System.Collections.Generic;
using System.Threading.Tasks;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ExcludeSummonPopup : PopupBase
	{
		[SerializeField]
		private ExcludeSummonCtrl tabCtrls;

		[SerializeField]
		private Transform sortButtonArea;

		[SerializeField]
		private Button allReleaseButton;

		[SerializeField]
		private Button allSelectButton;

		private GiftType type;

		private CommonSortButton sortButton;

		private int summonId;

		private SummonDataElement sde;

		private SummonTopItemData summonTopItemData;

		private UnityAction onSummonRequest;

		public static ExcludeSummonPopup Create(SummonTopItemData itemData, UnityAction onSummonRequest)
		{
			return null;
		}

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void UpdateSortAndFilter(int tabViewIndex)
		{
		}

		private void OnSortButtonClicked()
		{
		}

		private List<ulong> CreateDataIdList(GiftType giftType)
		{
			return null;
		}

		public void UpdateItemList()
		{
		}

		private void SetrReleaseAndSelectButton()
		{
		}

		public void OnOkButton()
		{
		}

		public void OnSummonRequest()
		{
		}

		public void OnAllSelect()
		{
		}

		public void OnAllRelease()
		{
		}

		public Task<SummonExcludeGetListResponse> RequestSummonExcludeGetList()
		{
			return null;
		}
	}
}
