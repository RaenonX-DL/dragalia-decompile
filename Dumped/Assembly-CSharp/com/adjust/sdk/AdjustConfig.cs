/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustConfig
	{
		// Fields
		internal string appToken;
		internal string sceneName;
		internal string userAgent;
		internal string defaultTracker;
		internal bool? isDeviceKnown;
		internal bool? sendInBackground;
		internal bool? eventBufferingEnabled;
		internal bool? allowSuppressLogLevel;
		internal bool launchDeferredDeeplink;
		internal AdjustLogLevel? logLevel;
		internal AdjustEnvironment environment;
		internal Action<string> deferredDeeplinkDelegate;
		internal Action<AdjustEventSuccess> eventSuccessDelegate;
		internal Action<AdjustEventFailure> eventFailureDelegate;
		internal Action<AdjustSessionSuccess> sessionSuccessDelegate;
		internal Action<AdjustSessionFailure> sessionFailureDelegate;
		internal Action<AdjustAttribution> attributionChangedDelegate;
		internal long? info1;
		internal long? info2;
		internal long? info3;
		internal long? info4;
		internal long? secretId;
		internal double? delayStart;
		internal string processName;
		internal bool? readImei;
		internal Action<string> logDelegate;
	
		// Constructors
		public AdjustConfig(string appToken, AdjustEnvironment environment);
		public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel);
	
		// Methods
		public void setLogLevel(AdjustLogLevel logLevel);
		public void setDefaultTracker(string defaultTracker);
		public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink);
		public void setSendInBackground(bool sendInBackground);
		public void setEventBufferingEnabled(bool eventBufferingEnabled);
		public void setDelayStart(double delayStart);
		public void setUserAgent(string userAgent);
		public void setIsDeviceKnown(bool isDeviceKnown);
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
		public void setProcessName(string processName);
		public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity);
		public void setLogDelegate(Action<string> logDelegate);
	}
}
