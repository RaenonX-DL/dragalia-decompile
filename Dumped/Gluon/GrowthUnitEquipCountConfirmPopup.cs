using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUnitEquipCountConfirmPopup : CommonPopup, ICustomMessage
	{
		public GameObject originCell;

		public Transform cellParentTransform;

		public Text needRupiText;

		public Text beforeRupiText;

		public Text afterRupiText;

		public CommonSlider slider;

		public Button plusButton;

		public Button minusButton;

		public Text useCountText;

		public Text totalCountText;

		public Text conditionText;

		public GameObject[] dewUIObjects;

		public Text needDewText;

		public Text beforeDewText;

		public Text afterDewText;

		public Text shortDewText;

		public GameObject[] materialUIObjects;

		public GameObject rupiUIObject;

		public Image equipIcon;

		public Sprite weaponIconSprite;

		public Material weaponIconMaterial;

		public Sprite crestIconSprite;

		public Material crestIconMaterial;

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

		private bool isShortageRupi;

		private bool isEndInitTask;

		private bool isSkipChangeValueTask;

		private PointerEventHandler okButtonHandler;

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

		public static GrowthUnitEquipCountConfirmPopup Create()
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

		private void SetupMaterialCell()
		{
		}

		private void UpdateMaterialCell()
		{
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		private void SetupRupi()
		{
		}

		private void UpdateRupi()
		{
		}

		private void SetupDewUI()
		{
		}

		private void UpdateDewUI()
		{
		}

		private void InitReleaseCountSlider()
		{
		}

		private void SetEquiplIcon()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
