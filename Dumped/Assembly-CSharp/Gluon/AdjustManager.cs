/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using com.adjust.sdk;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public sealed class AdjustManager
	{
		// Fields
		private static AdjustConf settings;
		private static bool isInitialized;
		private static string adjustDeviceID;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<string> __9__3_0;
			public static Action<string> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Initialize_b__3_0(string msg);
			internal void _getAdjustDeviceID_b__8_0(string googleAdId);
		}
	
		// Constructors
		public AdjustManager();
		static AdjustManager();
	
		// Methods
		public static void Initialize(string region);
		public static bool isEnabled();
		public static void setEnable(bool enabled);
		public static void setDeviceToken(string deviceToken);
		public static string getAdid();
		public static string getAdjustDeviceID();
		public static void setEventTracking(string eventName);
		public static void setEventTracking(string eventName, double amount, string currency);
		public static void AttributionChangedCallback(AdjustAttribution attributionData);
		public static void EventSuccessCallback(AdjustEventSuccess eventSuccessData);
		public static void EventFailureCallback(AdjustEventFailure eventFailureData);
		public static void SessionSuccessCallback(AdjustSessionSuccess sessionSuccessData);
		public static void SessionFailureCallback(AdjustSessionFailure sessionFailureData);
		public static void DeferredDeeplinkCallback(string deeplinkURL);
	}
}
