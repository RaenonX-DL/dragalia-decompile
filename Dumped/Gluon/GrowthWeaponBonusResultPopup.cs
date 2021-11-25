using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponBonusResultPopup : CommonPopup
	{
		public Image weaponTypeIcon;

		public Text hpParamText;

		public Text atkParamText;

		public Action popAnimationEndedCallBack;

		public static GrowthWeaponBonusResultPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
