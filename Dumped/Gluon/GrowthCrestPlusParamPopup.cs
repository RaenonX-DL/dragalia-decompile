using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthCrestPlusParamPopup : CommonPopup
	{
		public Text hpItemName;

		public Text atkItemName;

		public Image hpItemIcon;

		public Image atkItemIcon;

		public CommonSlider hpItemSlider;

		public CommonSlider atkItemSlider;

		public Button hpPlusButton;

		public Button hpMinusButton;

		public Button atkPlusButton;

		public Button atkMinusButton;

		public Text hpUseCountText;

		public Text hpTotalCountText;

		public Text atkUseCountText;

		public Text atkTotalCountText;

		public GameObject[] hpPlusUIObjects;

		public GameObject[] atkPlusUIObjects;

		private int _nowHPValue;

		private int maxHPValue;

		private int _nowAtkValue;

		private int maxAtkValue;

		private GrowthUnitEnhanceModel model;

		private Coroutine countCoroutine;

		private PointerEventHandler hpPlusButtonEventHandler;

		private PointerEventHandler hpMinusButtonEventHandler;

		private PointerEventHandler atkPlusButtonEventHandler;

		private PointerEventHandler atkMinusButtonEventHandler;

		private int hpItemId;

		private int atkItemId;

		private int oldSliderHpValue;

		private int oldSliderAtkValue;

		public int nowHPValue
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public int nowAtkValue
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public static GrowthCrestPlusParamPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		public void OnChangeHPSliderValue(float newValue)
		{
		}

		public void OnChangeAtkSliderValue(float newValue)
		{
		}

		public void OnHpPlusButtonPressed()
		{
		}

		public void OnHpMinusButtonPressed()
		{
		}

		public void OnAtkPlusButtonPressed()
		{
		}

		public void OnAtkMinusButtonPressed()
		{
		}

		public Dictionary<int, int> GetUseMaterial()
		{
			return null;
		}

		private void InitHpSlider()
		{
		}

		private void InitAtkSlider()
		{
		}

		private void UpdateOkButtonState()
		{
		}

		public void OnValueChangeButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isAtkSlider, bool isPlus)
		{
			return null;
		}
	}
}
