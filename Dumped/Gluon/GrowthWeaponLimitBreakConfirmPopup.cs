using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponLimitBreakConfirmPopup : CommonPopup, ICustomMessage
	{
		public GameObject originCell;

		public Transform cellParentTransform;

		public CommonSlider itemSlider;

		public CommonSlider slider;

		public Button plusItemButton;

		public Button minusItemButton;

		public Button plusButton;

		public Button minusButton;

		public Text useItemCountText;

		public Text totalItemCountText;

		public Text useCountText;

		public Text totalCountText;

		public Text conditionText;

		public GameObject[] itemSliderBaseObjects;

		public Image itemIcon;

		public Text itemCountText;

		public GameObject[] abilityUIObjects;

		public Image abilityIcon1;

		public Image abilityIcon2;

		public GameObject[] dewUIObjects;

		public Text needDewText;

		public Text beforeDewText;

		public Text afterDewText;

		public Text shortDewText;

		public GameObject[] materialUIObjects;

		public GameObject rupiUIObject;

		public Text needRupiText;

		public Text beforeRupiText;

		public Text afterRupiText;

		public GameObject needMaterialTextObject;

		public Action reloadCanvasUICallBack;

		public Action doLimitBreakAction;

		private int _nowItemValue;

		private int _nowValue;

		private GrowthUnitEnhanceModel model;

		private List<CraftMaterialCell> materialCells;

		private Coroutine updateUICoroutine;

		private Coroutine countCoroutine;

		private PointerEventHandler itemPlusButtonEventHandler;

		private PointerEventHandler itemMinusButtonEventHandler;

		private PointerEventHandler plusButtonEventHandler;

		private PointerEventHandler minusButtonEventHandler;

		private int itemMinValue;

		private int itemMaxValue;

		private int minValue;

		private int maxValue;

		private bool isDesabledReleaseButton;

		private bool isEndInitTask;

		private bool isSkipChangeValueTask;

		private bool isSkipChangeItemValueTask;

		private bool isShortageRupi;

		private PointerEventHandler okButtonHandler;

		public int nowItemValue
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public int nowValue
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static GrowthWeaponLimitBreakConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		private void SetupRupi()
		{
		}

		public void ChangedSliderValue(float newValue)
		{
		}

		public void ChangedItemSliderValue(float newValue)
		{
		}

		public void OnPlusButtonPressed()
		{
		}

		public void OnMinusButtonPressed()
		{
		}

		public void OnItemPlusButtonPressed()
		{
		}

		public void OnAbilityIconPressed(int index)
		{
		}

		public void OnItemMinusButtonPressed()
		{
		}

		public void OnValueChangeButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isItemSlider, bool isPlus)
		{
			return null;
		}

		private IEnumerator UpdatePopupUIDelay()
		{
			return null;
		}

		private void UpdatePopupUI()
		{
		}

		private void SetupMaterialCell()
		{
		}

		private void UpdateMaterialCell()
		{
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		private void InitReleaseCountSlider()
		{
		}

		private void InitItemCountSlider()
		{
		}

		private void SetupAbilityUI()
		{
		}

		private void SetupDewUI()
		{
		}

		private void UpdateAbilityUI()
		{
		}

		private void UpdateDewUI()
		{
		}

		private void UpdateRupiUI()
		{
		}

		private void DesableTutorialUI()
		{
		}

		public void ShowFinalCheckPopup()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
