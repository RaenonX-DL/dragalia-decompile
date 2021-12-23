using System;
using System.Collections.Generic;

namespace Gluon
{
	public class NotificationHelper
	{
		private enum NotificationID
		{
			DragonSmith,
			Ruby,
			Fruit,
			DragonContact,
			BuildComplete,
			SingleStamina,
			MultiStamina,
			HoneyDrink,
			DmodeExpedition
		}

		private static readonly string FORT_PUSH_DRAGONSMITH_FREE;

		private static readonly string FORT_PUSH_RUPI_FULL;

		private static readonly string FORT_PUSH_DRAGONFRUITS_FULL;

		private static readonly string FORT_PUSH_HONEYDRINK_FULL;

		private static readonly string FORT_BUILD_OR_LVUP_COMPLETE;

		private static readonly string DMODE_PUSH_EXPEDITION_END;

		private static readonly string COMMON_PUSH_SINGLE_STAMINA_FULL;

		private static readonly string COMMON_PUSH_MULTI_STAMINA_FULL;

		private static Dictionary<string, DateTime> rupiFullPushIds;

		private static Dictionary<string, DateTime> dragonFruitsFullPushIds;

		private static Dictionary<string, DateTime> honeyDrinkFullPushIds;

		private static Dictionary<string, DateTime> buildDonePushIds;

		private static DateTime dragonSimithPushTime;

		private static DateTime singleStaminaPushTime;

		private static DateTime multiStaminaPushTime;

		public static void PushNotificationSingleStaminaFull(int maxHealTime)
		{
		}

		public static void PushNotificationMultiStaminaFull(int maxHealTime)
		{
		}

		public static void CancelPushSingleStaminaNotification()
		{
		}

		public static void CancelPushMultiStaminaNotification()
		{
		}

		public static void PushNotificationDragonSmithFree()
		{
		}

		public static void PushNotificationRupiFull(Facility facility)
		{
		}

		public static void PushNotificationDmodeExpeditionEnd(int remainSecond)
		{
		}

		public static void CancelNotificationProductionFull(Facility facility)
		{
		}

		public static void CancelNotificationBuildOrLvUpComplete(Facility facility)
		{
		}

		public static void PushNotificationBuildOrLvUpComplete(Facility facility)
		{
		}

		private static DateTime GetPushTime(int max, int last)
		{
			return default(DateTime);
		}

		public static void CancelPushDragonSmithNotification()
		{
		}

		public static void CancelPushRupiFullNotification()
		{
		}

		public static void CancelPushDragonFruitsFullNotification()
		{
		}

		public static void CancelPushHoneyDrinkFullNotification()
		{
		}

		public static void CancelPushDmodeExpeditionEndNotification()
		{
		}

		public static void CancelPushBuildDoneNotification()
		{
		}

		public static void CancelPushUnavailableTimePeriod()
		{
		}

		private static void CancelPushIdsUnavailableTimePeriod(Dictionary<string, DateTime> ids)
		{
		}

		private static bool isAvailablePushTime(DateTime pushTime)
		{
			return default(bool);
		}

		private static bool isInTimePeriod(DateTime pushTime)
		{
			return default(bool);
		}
	}
}
