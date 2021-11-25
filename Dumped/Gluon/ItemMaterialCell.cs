using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemMaterialCell : TableViewCell<ItemMaterialCellData>
	{
		public Image itemIcon;

		public Text itemNameText;

		public Text useCountText;

		public Text maxCountText;

		public Slider useCountSlider;

		public Button plusButton;

		public Button minusButton;

		public Image plusButtonIcon;

		public Image minusButtonIcon;

		public Sprite buttonEnableIcon;

		public Sprite buttonDisableIcon;

		public UnityAction longPressCallBack;

		public UnityAction longPressEndCallBack;

		public Image cellLockImage;

		[SerializeField]
		public UnityAction<int> buttonPressed;

		[SerializeField]
		public MaterialSliderUpdateEvent sliderUpdate;

		private int materialId;

		private int useItemCount;

		private int maxUseCount;

		private bool maxExpFlg;

		private bool isNotUpdateSlider;

		private PointerEventHandler plusButtonEventHandler;

		private PointerEventHandler minusButtonEventHandler;

		private Coroutine countCoroutine;

		private bool isScrollLock;

		private ItemMaterialCellData cellData;

		private GameObject lockButtonObj;

		private void Start()
		{
		}

		public override void UpdateContent(ItemMaterialCellData data)
		{
		}

		public void UseCountButtonPressed(int countInc)
		{
		}

		public void UseCountButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isPlus)
		{
			return null;
		}

		public void SliderValueChanged()
		{
		}

		public void OnButtonPressed()
		{
		}

		public void UpdateItemCountButton()
		{
		}

		private void LongPressEnded()
		{
		}
	}
}
