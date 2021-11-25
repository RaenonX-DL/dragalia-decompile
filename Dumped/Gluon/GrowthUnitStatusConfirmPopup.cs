using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUnitStatusConfirmPopup : CommonPopup, ICustomMessage
	{
		public Text beforeHpText;

		public Text afterHpText;

		public Text diffHpText;

		public Text beforeAtkText;

		public Text afterAtkText;

		public Text diffAtkText;

		public GameObject originCell;

		public Transform cellParentTransform;

		public CommonSlider slider;

		public Button plusButton;

		public Button minusButton;

		public Text useCountText;

		public Text totalCountText;

		public Text conditionText;

		public GameObject needMaterialTextObject;

		public Action reloadCanvasUICallBack;

		private int _nowValue;

		private GrowthUnitEnhanceModel model;

		private List<CraftMaterialCell> materialCells;

		private Coroutine updateUICoroutine;

		private Coroutine countCoroutine;

		private PointerEventHandler plusButtonEventHandler;

		private PointerEventHandler minusButtonEventHandler;

		private int minValue;

		private int maxValue;

		private bool isDesabledReleaseButton;

		private bool isEndInitTask;

		private bool isSkipChangeValueTask;

		private PointerEventHandler okButtonHandler;

		private readonly Color positiveColor;

		private readonly Color normalColor;

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

		public static GrowthUnitStatusConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		public void ChangedSliderValue(float newValue)
		{
		}

		public void OnPlusButtonPressed()
		{
		}

		public void OnMinusButtonPressed()
		{
		}

		public void OnValueChangeButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isPlus)
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

		private void UpdateStatus()
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

		private void DesableTutorialUI()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
