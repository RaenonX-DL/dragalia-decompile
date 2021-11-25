using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class HeaderMenuButton : MonoBehaviour
	{
		[SerializeField]
		private Badge menuBadge;

		public MenuPopup menuPopup;

		private DateTime lastCheckInquiryTime;

		private const int checkInquiryInterval = 1800000;

		public bool isHavingUnreadComments
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void OnButtonPressed()
		{
		}

		public void SetMenuBadge(bool isActive)
		{
		}

		public void UpdateMenuBadge()
		{
		}

		public void CheckInquiryStatus(bool checkTime = true, [Optional] Action onComplete)
		{
		}
	}
}
