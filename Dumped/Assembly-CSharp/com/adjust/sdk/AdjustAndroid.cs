/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustAndroid
	{
		// Fields
		private const string sdkPrefix = "unity4.24.1";
		private static bool launchDeferredDeeplink;
		private static AndroidJavaClass ajcAdjust;
		private static AndroidJavaObject ajoCurrentActivity;
		private static DeferredDeeplinkListener onDeferredDeeplinkListener;
		private static AttributionChangeListener onAttributionChangedListener;
		private static EventTrackingFailedListener onEventTrackingFailedListener;
		private static EventTrackingSucceededListener onEventTrackingSucceededListener;
		private static SessionTrackingFailedListener onSessionTrackingFailedListener;
		private static SessionTrackingSucceededListener onSessionTrackingSucceededListener;
	
		// Nested types
		private class AttributionChangeListener : AndroidJavaProxy
		{
			// Fields
			private Action<AdjustAttribution> callback;
	
			// Constructors
			public AttributionChangeListener(Action<AdjustAttribution> pCallback);
	
			// Methods
			public void onAttributionChanged(AndroidJavaObject attribution);
		}
	
		private class DeferredDeeplinkListener : AndroidJavaProxy
		{
			// Fields
			private Action<string> callback;
	
			// Constructors
			public DeferredDeeplinkListener(Action<string> pCallback);
	
			// Methods
			public bool launchReceivedDeeplink(AndroidJavaObject deeplink);
		}
	
		private class EventTrackingSucceededListener : AndroidJavaProxy
		{
			// Fields
			private Action<AdjustEventSuccess> callback;
	
			// Constructors
			public EventTrackingSucceededListener(Action<AdjustEventSuccess> pCallback);
	
			// Methods
			public void onFinishedEventTrackingSucceeded(AndroidJavaObject eventSuccessData);
		}
	
		private class EventTrackingFailedListener : AndroidJavaProxy
		{
			// Fields
			private Action<AdjustEventFailure> callback;
	
			// Constructors
			public EventTrackingFailedListener(Action<AdjustEventFailure> pCallback);
	
			// Methods
			public void onFinishedEventTrackingFailed(AndroidJavaObject eventFailureData);
		}
	
		private class SessionTrackingSucceededListener : AndroidJavaProxy
		{
			// Fields
			private Action<AdjustSessionSuccess> callback;
	
			// Constructors
			public SessionTrackingSucceededListener(Action<AdjustSessionSuccess> pCallback);
	
			// Methods
			public void onFinishedSessionTrackingSucceeded(AndroidJavaObject sessionSuccessData);
		}
	
		private class SessionTrackingFailedListener : AndroidJavaProxy
		{
			// Fields
			private Action<AdjustSessionFailure> callback;
	
			// Constructors
			public SessionTrackingFailedListener(Action<AdjustSessionFailure> pCallback);
	
			// Methods
			public void onFinishedSessionTrackingFailed(AndroidJavaObject sessionFailureData);
		}
	
		private class DeviceIdsReadListener : AndroidJavaProxy
		{
			// Fields
			private Action<string> onPlayAdIdReadCallback;
	
			// Constructors
			public DeviceIdsReadListener(Action<string> pCallback);
	
			// Methods
			public void onGoogleAdIdRead(string playAdId);
			public void onGoogleAdIdRead(AndroidJavaObject ajoAdId);
		}
	
		// Constructors
		public AdjustAndroid();
		static AdjustAndroid();
	
		// Methods
		public static void Start(AdjustConfig adjustConfig);
		public static void TrackEvent(AdjustEvent adjustEvent);
		public static bool IsEnabled();
		public static void SetEnabled(bool enabled);
		public static void SetOfflineMode(bool enabled);
		public static void SendFirstPackages();
		public static void SetDeviceToken(string deviceToken);
		public static string GetAdid();
		public static void GdprForgetMe();
		public static void DisableThirdPartySharing();
		public static AdjustAttribution GetAttribution();
		public static void AddSessionPartnerParameter(string key, string value);
		public static void AddSessionCallbackParameter(string key, string value);
		public static void RemoveSessionPartnerParameter(string key);
		public static void RemoveSessionCallbackParameter(string key);
		public static void ResetSessionPartnerParameters();
		public static void ResetSessionCallbackParameters();
		public static void AppWillOpenUrl(string url);
		public static void TrackAdRevenue(string source, string payload);
		public static void TrackPlayStoreSubscription(AdjustPlayStoreSubscription subscription);
		public static void OnPause();
		public static void OnResume();
		public static void SetReferrer(string referrer);
		public static void GetGoogleAdId(Action<string> onDeviceIdsRead);
		public static string GetAmazonAdId();
		public static string GetSdkVersion();
		public static void SetTestOptions(Dictionary<string, string> testOptions);
		private static bool IsAppSecretSet(AdjustConfig adjustConfig);
	}
}
