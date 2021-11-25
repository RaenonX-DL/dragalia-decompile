using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponSlotResultPopup : CommonPopup
	{
		public Image breforeType1SlotImage;

		public Text breforeType1SlotText;

		public Image breforeType2SlotImage;

		public Text breforeType2SlotText;

		public Image breforeType3SlotImage;

		public Text breforeType3SlotText;

		public Image afterType1SlotImage;

		public Text afterType1SlotText;

		public Image afterType2SlotImage;

		public Text afterType2SlotText;

		public Image afterType3SlotImage;

		public Text afterType3SlotText;

		public Action popAnimationEndedCallBack;

		public static GrowthWeaponSlotResultPopup Create()
		{
			return null;
		}

		public void InitPopup(int beforeType1Slot, int beforeType2Slot, int beforeType3Slot, int afterType1Slot, int afterType2Slot, int afterType3Slot)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
