using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponTypeAbilityResultPopup : CommonPopup
	{
		public Image[] abilityIcons;

		public Action popAnimationEndedCallBack;

		public static GrowthWeaponTypeAbilityResultPopup Create()
		{
			return null;
		}

		public void InitPopup(int[] abilityDataIds)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
