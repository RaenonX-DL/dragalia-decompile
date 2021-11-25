using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemDetailPopup : CommonPopup
	{
		public enum ShowType
		{
			MenuItemList,
			Other
		}

		public ItemListPopup itemListPopup;

		[SerializeField]
		private CommonIcon itemIcon;

		[SerializeField]
		private Text itemNameText;

		[SerializeField]
		[FormerlySerializedAs("discriptionText")]
		private Text descriptionText;

		[SerializeField]
		private Text dateText;

		[SerializeField]
		private Text overLimitWarningText;

		[SerializeField]
		private GameObject normalObj;

		[SerializeField]
		private GameObject tradeObj;

		[SerializeField]
		private Button questButton;

		private const string prefabPath = "Prefabs/OutGame/Item/ItemDetailPopup";

		private int useLimit;

		private int itemId;

		public static ItemDetailPopup Create()
		{
			return null;
		}

		public void InitSetting(GiftType giftType, int itemId, bool isBackList = true, bool isInInventory = true, bool isShowNumberOwned = false, bool canTrade = false, bool enableChangeScene = true, ShowType showType = ShowType.Other)
		{
		}

		public void InitWithShopSpecialIconSetting(ShopCommonIcon.SpecialIconSetting specialIcon)
		{
		}

		private UnityAction SetupMaterialPopup(GiftType giftType, int itemId, string itemName, string detail, string description, DetailLinkType detailLinkType, int[] moveQuests, bool isInInventory = true)
		{
			return null;
		}

		public void SetUseLimitText(int useLimit)
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		public void OnFetchFromTradeButtonPressed()
		{
		}

		private void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void LoadSceneShopTrade(ShopTradeModel.PanelType nextPanel)
		{
		}

		private bool IsUseLimitOver()
		{
			return default(bool);
		}

		public void SetItemCount(int count)
		{
		}
	}
}
