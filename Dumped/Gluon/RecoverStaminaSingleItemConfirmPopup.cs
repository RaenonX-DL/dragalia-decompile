using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RecoverStaminaSingleItemConfirmPopup : PopupBase
	{
		[SerializeField]
		[Header("Contents")]
		public CommonIcon icon;

		public Text itemName;

		public Text itemDescription;

		public Text stoneComment;

		public Text insufficientStaminaCommentText;

		public Text titleText;

		[SerializeField]
		[Header("Slider")]
		public CommonSliderSelection slider;

		[SerializeField]
		[Header("BeforeAfter")]
		public Text beforeStaminaText;

		public Text afterStaminaText;

		public Text beforeInventoryCountText;

		public Text afterInventoryCountText;

		public Text staminaTabText;

		public Text priceText;

		[SerializeField]
		[Header("OnOff")]
		public Text staminaExceedsLimitText;

		public Text stoneStaminaExceedsLimitText;

		public Button okButton;

		[SerializeField]
		[Header("StoneOnOff")]
		public GameObject[] stoneOnlyGOs;

		public GameObject[] itemOnlyGOs;

		public GameObject[] paidStoneOnlyGOs;

		public GameObject[] freeStoneOnlyGOs;

		public Button stonePlusButton;

		public Button stoneMinusButton;

		public Text itemNameTabText;

		[SerializeField]
		[Header("Other")]
		private List<MaintenanceFunctionType> maintenanceTypes;

		private int itemId;

		private bool isFreeStone;

		private int useCount;

		private StaminaUtilBase staminaUtil;

		private int recoveryPointPerItem;

		private int beforeStamina;

		private int inventoryCount;

		private bool isMulti;

		private int afterStamina;

		public ItemListPopup itemListPopup;

		private bool isShowRecoverDonePopup;

		public static RecoverStaminaSingleItemConfirmPopup Create(int itemId)
		{
			return null;
		}

		public static RecoverStaminaSingleItemConfirmPopup CreateForStoneWithModel(bool isFreeStone, bool isCreateRecoverDonePopup)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private bool IsUseButtonInteractable(int useCount)
		{
			return default(bool);
		}

		public void OnSliderValueChanged(float val)
		{
		}

		public void OnUseButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
