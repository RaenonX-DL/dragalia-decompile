/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NotificationHelper
	{
		// Fields
		private static readonly string FORT_PUSH_DRAGONSMITH_FREE;
		private static readonly string FORT_PUSH_RUPI_FULL;
		private static readonly string FORT_PUSH_DRAGONFRUITS_FULL;
		private static readonly string FORT_PUSH_HONEYDRINK_FULL;
		private static readonly string FORT_BUILD_OR_LVUP_COMPLETE;
		private static readonly string COMMON_PUSH_SINGLE_STAMINA_FULL;
		private static readonly string COMMON_PUSH_MULTI_STAMINA_FULL;
		private static Dictionary<string, DateTime> rupiFullPushIds;
		private static Dictionary<string, DateTime> dragonFruitsFullPushIds;
		private static Dictionary<string, DateTime> honeyDrinkFullPushIds;
		private static Dictionary<string, DateTime> buildDonePushIds;
		private static DateTime dragonSimithPushTime;
		private static DateTime singleStaminaPushTime;
		private static DateTime multiStaminaPushTime;
	
		// Nested types
		private enum NotificationID
		{
			DragonSmith = 0,
			Ruby = 1,
			Fruit = 2,
			DragonContact = 3,
			BuildComplete = 4,
			SingleStamina = 5,
			MultiStamina = 6,
			HoneyDrink = 7
		}
	
		// Constructors
		public NotificationHelper();
		static NotificationHelper();
	
		// Methods
		public static void PushNotificationSingleStaminaFull(int maxHealTime);
		public static void PushNotificationMultiStaminaFull(int maxHealTime);
		public static void CancelPushSingleStaminaNotification();
		public static void CancelPushMultiStaminaNotification();
		public static void PushNotificationDragonSmithFree();
		public static void PushNotificationRupiFull(Facility facility);
		public static void CancelNotificationProductionFull(Facility facility);
		public static void CancelNotificationBuildOrLvUpComplete(Facility facility);
		public static void PushNotificationBuildOrLvUpComplete(Facility facility);
		private static DateTime GetPushTime(int max, int last);
		public static void CancelPushDragonSmithNotification();
		public static void CancelPushRupiFullNotification();
		public static void CancelPushDragonFruitsFullNotification();
		public static void CancelPushHoneyDrinkFullNotification();
		public static void CancelPushBuildDoneNotification();
		public static void CancelPushUnavailableTimePeriod();
		private static void CancelPushIdsUnavailableTimePeriod(Dictionary<string, DateTime> ids);
		private static bool isAvailablePushTime(DateTime pushTime);
		private static bool isInTimePeriod(DateTime pushTime);
	}
}
