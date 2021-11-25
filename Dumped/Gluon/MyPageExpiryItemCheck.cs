using System;
using System.Collections.Generic;

namespace Gluon
{
	public class MyPageExpiryItemCheck
	{
		private class WarningExpiryItemInfo
		{
			public GiftType giftType;

			public int itemId;

			public string itemName;

			public TimeSpan span;

			public WarningExpiryItemInfo(GiftType giftType, int itemId, string itemName, TimeSpan span)
			{
			}

			public bool ShouldForceMove()
			{
				return default(bool);
			}

			public void OnMoveButtonPressed()
			{
			}

			public string GetMoveButtonText()
			{
				return null;
			}
		}

		private static long ticketWarningLastDisplayDate;

		private const int ticketWarningforceMoveSceneDays = 7;

		private const int ticketWarningStartDisplayDays = 2;

		public static void CheckAndShowExpriryWarning()
		{
		}

		private static void CreateWarningPopupOneByOne(List<WarningExpiryItemInfo> warningList)
		{
		}
	}
}
