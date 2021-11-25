using com.adjust.sdk;

namespace Gluon
{
	public sealed class AdjustManager
	{
		private static AdjustConf settings;

		private static bool isInitialized;

		private static string adjustDeviceID;

		public static void Initialize(string region)
		{
		}

		public static bool isEnabled()
		{
			return default(bool);
		}

		public static void setEnable(bool enabled)
		{
		}

		public static void setDeviceToken(string deviceToken)
		{
		}

		public static string getAdid()
		{
			return null;
		}

		public static string getAdjustDeviceID()
		{
			return null;
		}

		public static void setEventTracking(string eventName)
		{
		}

		public static void setEventTracking(string eventName, double amount, string currency)
		{
		}

		public static void AttributionChangedCallback(AdjustAttribution attributionData)
		{
		}

		public static void EventSuccessCallback(AdjustEventSuccess eventSuccessData)
		{
		}

		public static void EventFailureCallback(AdjustEventFailure eventFailureData)
		{
		}

		public static void SessionSuccessCallback(AdjustSessionSuccess sessionSuccessData)
		{
		}

		public static void SessionFailureCallback(AdjustSessionFailure sessionFailureData)
		{
		}

		public static void DeferredDeeplinkCallback(string deeplinkURL)
		{
		}
	}
}
