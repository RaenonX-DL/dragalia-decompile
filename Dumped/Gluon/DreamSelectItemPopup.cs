using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DreamSelectItemPopup : PopupBase, ICustomMessage
	{
		public const string path = "Prefabs/OutGame/ShopTrade/Popup/DreamSelectItemPopup";

		[SerializeField]
		private DreamSelectItemCtrl[] tabCtrls;

		[SerializeField]
		private TabBase tabView;

		[SerializeField]
		private Text periodText;

		[SerializeField]
		private Text remainCountText;

		[SerializeField]
		private float sortButtonPosY;

		private CommonSortButton sortButton;

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

		public static void Create(ShopTradeProductData.CommonShopItemData itemData)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
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

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
