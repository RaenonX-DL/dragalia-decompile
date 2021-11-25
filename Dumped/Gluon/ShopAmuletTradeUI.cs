using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopAmuletTradeUI : ShopTradePanelBase, ICustomMessage
	{
		[SerializeField]
		private ShopTableViewTradeAmuletCtrl[] tabCtrls;

		[SerializeField]
		private TabBase tabView;

		[SerializeField]
		private Text curDewText;

		[SerializeField]
		private Text refreshText;

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

		public ulong[] originalKeyIdList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ShopTradeProductData.CommonShopItemData itemData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static ShopAmuletTradeUI Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		public static void RequestForEntryHttp(Action onHttpDoneCallback)
		{
		}

		private void Awake()
		{
		}

		private void OnInputFilterChanged(List<int> filteredId)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected void Start()
		{
		}

		private void InitAbilityCrestTradeDataDictionary()
		{
		}

		private void OnSortButtonClicked()
		{
		}

		private void UpdateSortAndFilter(int tabViewIndex)
		{
		}

		public void OnChangeButtonTouched()
		{
		}

		private void SetRefreshText()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public override void RefreshCurrentPage()
		{
		}

		public void OnRecommendedButton()
		{
		}
	}
}
