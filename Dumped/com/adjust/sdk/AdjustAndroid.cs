using System;
using System.Collections.Generic;
using UnityEngine;

namespace com.adjust.sdk
{
	public class AdjustAndroid
	{
		private class AttributionChangeListener : AndroidJavaProxy
		{
			private Action<AdjustAttribution> callback;

			public AttributionChangeListener(Action<AdjustAttribution> pCallback)
			{
			}

			public void onAttributionChanged(AndroidJavaObject attribution)
			{
			}
		}

		private class DeferredDeeplinkListener : AndroidJavaProxy
		{
			private Action<string> callback;

			public DeferredDeeplinkListener(Action<string> pCallback)
			{
			}

			public bool launchReceivedDeeplink(AndroidJavaObject deeplink)
			{
				return default(bool);
			}
		}

		private class EventTrackingSucceededListener : AndroidJavaProxy
		{
			private Action<AdjustEventSuccess> callback;

			public EventTrackingSucceededListener(Action<AdjustEventSuccess> pCallback)
			{
			}

			public void onFinishedEventTrackingSucceeded(AndroidJavaObject eventSuccessData)
			{
			}
		}

		private class EventTrackingFailedListener : AndroidJavaProxy
		{
			private Action<AdjustEventFailure> callback;

			public EventTrackingFailedListener(Action<AdjustEventFailure> pCallback)
			{
			}

			public void onFinishedEventTrackingFailed(AndroidJavaObject eventFailureData)
			{
			}
		}

		private class SessionTrackingSucceededListener : AndroidJavaProxy
		{
			private Action<AdjustSessionSuccess> callback;

			public SessionTrackingSucceededListener(Action<AdjustSessionSuccess> pCallback)
			{
			}

			public void onFinishedSessionTrackingSucceeded(AndroidJavaObject sessionSuccessData)
			{
			}
		}

		private class SessionTrackingFailedListener : AndroidJavaProxy
		{
			private Action<AdjustSessionFailure> callback;

			public SessionTrackingFailedListener(Action<AdjustSessionFailure> pCallback)
			{
			}

			public void onFinishedSessionTrackingFailed(AndroidJavaObject sessionFailureData)
			{
			}
		}

		private class DeviceIdsReadListener : AndroidJavaProxy
		{
			private Action<string> onPlayAdIdReadCallback;

			public DeviceIdsReadListener(Action<string> pCallback)
			{
			}

			public void onGoogleAdIdRead(string playAdId)
			{
			}

			public void onGoogleAdIdRead(AndroidJavaObject ajoAdId)
			{
			}
		}

		private const string sdkPrefix = "unity4.28.0";

		private static bool launchDeferredDeeplink;

		private static AndroidJavaClass ajcAdjust;

		private static AndroidJavaObject ajoCurrentActivity;

		private static DeferredDeeplinkListener onDeferredDeeplinkListener;

		private static AttributionChangeListener onAttributionChangedListener;

		private static EventTrackingFailedListener onEventTrackingFailedListener;

		private static EventTrackingSucceededListener onEventTrackingSucceededListener;

		private static SessionTrackingFailedListener onSessionTrackingFailedListener;

		private static SessionTrackingSucceededListener onSessionTrackingSucceededListener;

		public static void Start(AdjustConfig adjustConfig)
		{
		}

		public static void TrackEvent(AdjustEvent adjustEvent)
		{
		}

		public static bool IsEnabled()
		{
			return default(bool);
		}

		public static void SetEnabled(bool enabled)
		{
		}

		public static void SetOfflineMode(bool enabled)
		{
		}

		public static void SendFirstPackages()
		{
		}

		public static void SetDeviceToken(string deviceToken)
		{
		}

		public static string GetAdid()
		{
			return null;
		}

		public static void GdprForgetMe()
		{
		}

		public static void DisableThirdPartySharing()
		{
		}

		public static AdjustAttribution GetAttribution()
		{
			return null;
		}

		public static void AddSessionPartnerParameter(string key, string value)
		{
		}

		public static void AddSessionCallbackParameter(string key, string value)
		{
		}

		public static void RemoveSessionPartnerParameter(string key)
		{
		}

		public static void RemoveSessionCallbackParameter(string key)
		{
		}

		public static void ResetSessionPartnerParameters()
		{
		}

		public static void ResetSessionCallbackParameters()
		{
		}

		public static void AppWillOpenUrl(string url)
		{
		}

		public static void TrackAdRevenue(string source, string payload)
		{
		}

		public static void TrackPlayStoreSubscription(AdjustPlayStoreSubscription subscription)
		{
		}

		public static void TrackThirdPartySharing(AdjustThirdPartySharing thirdPartySharing)
		{
		}

		public static void TrackMeasurementConsent(bool measurementConsent)
		{
		}

		public static void OnPause()
		{
		}

		public static void OnResume()
		{
		}

		public static void SetReferrer(string referrer)
		{
		}

		public static void GetGoogleAdId(Action<string> onDeviceIdsRead)
		{
		}

		public static string GetAmazonAdId()
		{
			return null;
		}

		public static string GetSdkVersion()
		{
			return null;
		}

		public static void SetTestOptions(Dictionary<string, string> testOptions)
		{
		}

		private static bool IsAppSecretSet(AdjustConfig adjustConfig)
		{
			return default(bool);
		}
	}
}
