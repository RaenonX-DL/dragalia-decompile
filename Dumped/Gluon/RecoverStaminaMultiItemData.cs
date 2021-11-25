using Gluon.Http;

namespace Gluon
{
	public class RecoverStaminaMultiItemData
	{
		public int itemId;

		public int pointPerItem;

		public int sliderValue;

		public int sliderMax;

		public int sliderInvalidMax;

		public bool sliderDirty;

		public void AdjustInvalidOnOtherSliderValueChanged(int currentValue, int maxValue)
		{
		}

		public bool CanSelectMore(out bool isSliderMax)
		{
			return default(bool);
		}

		internal void InitWithItem(ItemList itemList, int afterStamina, int absoluteStaminaMax)
		{
		}
	}
}
