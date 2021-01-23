/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class Adjust : MonoBehaviour
	{
		// Fields
		private const string errorMsgEditor = "Adjust: SDK can not be used in Editor.";
		private const string errorMsgStart = "Adjust: SDK not started. Start it manually using the \'start\' method.";
		private const string errorMsgPlatform = "Adjust: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";
		public bool startManually;
		public bool eventBuffering;
		public bool sendInBackground;
		public bool launchDeferredDeeplink;
		public string appToken;
		public AdjustLogLevel logLevel;
		public AdjustEnvironment environment;
	
		// Constructors
		public Adjust();
	
		// Methods
		private void Awake();
		private void OnApplicationPause(bool pauseStatus);
		public static void start(AdjustConfig adjustConfig);
		public static void trackEvent(AdjustEvent adjustEvent);
		public static void setEnabled(bool enabled);
		public static bool isEnabled();
		public static void setOfflineMode(bool enabled);
		public static void setDeviceToken(string deviceToken);
		public static void gdprForgetMe();
		public static void appWillOpenUrl(string url);
		public static void sendFirstPackages();
		public static void addSessionPartnerParameter(string key, string value);
		public static void addSessionCallbackParameter(string key, string value);
		public static void removeSessionPartnerParameter(string key);
		public static void removeSessionCallbackParameter(string key);
		public static void resetSessionPartnerParameters();
		public static void resetSessionCallbackParameters();
		public static string getAdid();
		public static AdjustAttribution getAttribution();
		public static string getWinAdid();
		public static string getIdfa();
		[Obsolete]
		public static void setReferrer(string referrer);
		public static void getGoogleAdId(Action<string> onDeviceIdsRead);
		public static string getAmazonAdId();
		private static bool IsEditor();
	}
}
