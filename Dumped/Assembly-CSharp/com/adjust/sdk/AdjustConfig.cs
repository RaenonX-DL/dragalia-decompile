/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustConfig
	{
		// Fields
		public const string AdjustAdRevenueSourceMopub = "mopub";
		public const string AdjustUrlStrategyChina = "china";
		public const string AdjustUrlStrategyIndia = "india";
		internal string appToken;
		internal string sceneName;
		internal string userAgent;
		internal string defaultTracker;
		internal string externalDeviceId;
		internal string urlStrategy;
		internal long? info1;
		internal long? info2;
		internal long? info3;
		internal long? info4;
		internal long? secretId;
		internal double? delayStart;
		internal bool? isDeviceKnown;
		internal bool? sendInBackground;
		internal bool? eventBufferingEnabled;
		internal bool? allowSuppressLogLevel;
		internal bool? needsCost;
		internal bool launchDeferredDeeplink;
		internal AdjustLogLevel? logLevel;
		internal AdjustEnvironment environment;
		internal Action<string> deferredDeeplinkDelegate;
		internal Action<AdjustEventSuccess> eventSuccessDelegate;
		internal Action<AdjustEventFailure> eventFailureDelegate;
		internal Action<AdjustSessionSuccess> sessionSuccessDelegate;
		internal Action<AdjustSessionFailure> sessionFailureDelegate;
		internal Action<AdjustAttribution> attributionChangedDelegate;
		internal bool? readImei;
		internal bool? preinstallTrackingEnabled;
		internal string processName;
		internal bool? allowiAdInfoReading;
		internal bool? allowIdfaReading;
		internal bool? skAdNetworkHandling;
		internal Action<string> logDelegate;
	
		// Constructors
		public AdjustConfig(string appToken, AdjustEnvironment environment);
		public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel);
	
		// Methods
		public void setLogLevel(AdjustLogLevel logLevel);
		public void setDefaultTracker(string defaultTracker);
		public void setExternalDeviceId(string externalDeviceId);
		public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink);
		public void setSendInBackground(bool sendInBackground);
		public void setEventBufferingEnabled(bool eventBufferingEnabled);
		public void setNeedsCost(bool needsCost);
		public void setDelayStart(double delayStart);
		public void setUserAgent(string userAgent);
		public void setIsDeviceKnown(bool isDeviceKnown);
		public void setUrlStrategy(string urlStrategy);
		public void deactivateSKAdNetworkHandling();
		public void setDeferredDeeplinkDelegate(Action<string> deferredDeeplinkDelegate, string sceneName = "Adjust");
		public Action<string> getDeferredDeeplinkDelegate();
		public void setAttributionChangedDelegate(Action<AdjustAttribution> attributionChangedDelegate, string sceneName = "Adjust");
		public Action<AdjustAttribution> getAttributionChangedDelegate();
		public void setEventSuccessDelegate(Action<AdjustEventSuccess> eventSuccessDelegate, string sceneName = "Adjust");
		public Action<AdjustEventSuccess> getEventSuccessDelegate();
		public void setEventFailureDelegate(Action<AdjustEventFailure> eventFailureDelegate, string sceneName = "Adjust");
		public Action<AdjustEventFailure> getEventFailureDelegate();
		public void setSessionSuccessDelegate(Action<AdjustSessionSuccess> sessionSuccessDelegate, string sceneName = "Adjust");
		public Action<AdjustSessionSuccess> getSessionSuccessDelegate();
		public void setSessionFailureDelegate(Action<AdjustSessionFailure> sessionFailureDelegate, string sceneName = "Adjust");
		public Action<AdjustSessionFailure> getSessionFailureDelegate();
		public void setAppSecret(long secretId, long info1, long info2, long info3, long info4);
		public void setAllowiAdInfoReading(bool allowiAdInfoReading);
		public void setAllowIdfaReading(bool allowIdfaReading);
		public void setProcessName(string processName);
		[Obsolete]
		public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity);
		public void setPreinstallTrackingEnabled(bool preinstallTrackingEnabled);
		public void setLogDelegate(Action<string> logDelegate);
	}
}
