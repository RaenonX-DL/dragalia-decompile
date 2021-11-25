using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponEquipCountResultPopup : CommonPopup
	{
		public Text beforeCountText;

		public Text afterCountText;

		public Action popAnimationEndedCallBack;

		public static GrowthWeaponEquipCountResultPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, int beforeCount)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
