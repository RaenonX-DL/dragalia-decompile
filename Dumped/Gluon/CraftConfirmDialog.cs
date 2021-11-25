using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftConfirmDialog : CommonPopup, ICustomMessage
	{
		public Image targetWeaponIcon;

		public Text message;

		public CraftMaterialCell originCell;

		public Text needCoinText;

		public Text totalCoin;

		public Text breforeCoin;

		public Text afterCoin;

		public Text craftCount;

		public Text craftMaxCount;

		public Slider craftSlider;

		public int totalCraftCount;

		public Button plusButton;

		public Button minusButton;

		public GameObject sliberBase;

		public Text errorMessage;

		public GameObject sortDecoAttachNode;

		public List<CraftMaterialCell> materialCellList;

		public GameObject autoLimitBreakBase;

		public Toggle autoLimitBreakToggle;

		public Text autoLimitBreakText;

		private PointerEventHandler plusButtonEventHandler;

		private PointerEventHandler minusButtonEventHandler;

		private Coroutine countCoroutine;

		private int assembleCoin;

		private int targetId;

		private bool isMuteSliderSe;

		private WeaponCraftDataElement craftData;

		public bool isItemUpdate
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CraftConfirmDialog Create(bool showBlackLayer = true)
		{
			return null;
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

		public void InitPop(WeaponCraftDataElement craftData)
		{
		}

		private void UpdatePopup()
		{
		}

		private IEnumerator SliderSeActiveDelay()
		{
			return null;
		}

		public void SliderValueChanged()
		{
		}

		public void OnValueChangeButtonPressed(int value)
		{
		}

		public void OnValueChangeButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isPlus)
		{
			return null;
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		public void OnToggleClickedAutoLimitBreak(bool bOn)
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		public override void OnCancelButtonPressed()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
