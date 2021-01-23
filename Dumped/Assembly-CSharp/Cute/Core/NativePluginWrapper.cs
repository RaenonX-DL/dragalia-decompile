/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public static class NativePluginWrapper
	{
		// Fields
		private static AndroidJavaClass nativePluginJavaClass;
	
		// Nested types
		public enum BatteryState
		{
			Unknown = 0,
			Discharging = 1,
			Charging = 2,
			Full = 3
		}
	
		public enum NetworkMode
		{
			Unconnected = 0,
			WiFi = 1,
			Mobile = 2
		}
	
		public enum CLAuthorizationStatus
		{
			NotDetermined = 0,
			Restricted = 1,
			Denied = 2,
			AuthorizedAlways = 3,
			AuthorizedWhenInUse = 4
		}
	
		// Constructors
		static NativePluginWrapper();
	
		// Methods
		public static void DeviceInit();
		public static int GetUseResidentMemory();
		public static int GetUseVirtualMemory();
		public static int GetDeviceFreeMemory();
		public static int GetVmUseMemory();
		public static int GetVmFreeMemory();
		public static void SetStringToClipboard(string copyText);
		public static int GetAccelerometerRotation();
		public static void RequestAudioFocus();
		public static void AbandonAudioFocus();
		public static string GetMacAddressByName(string devicename);
		public static void DispStatusBar(bool display);
		public static void RegistPhoneStateListener();
		public static void UnregistPhoneStateListener();
		public static int GetBatteryLevel();
		public static BatteryState GetBatteryState();
		public static int GetWifiAntenaLevel();
		public static NetworkMode GetNetworkMode();
		public static bool IsAirplaneMode();
		public static void ShowToast(string text);
		public static void DumpWWWCache();
		public static int GetCacheDiskUsage();
		public static int GetCacheDiskCapacity();
		public static int GetCacheCurrentMemoryUsage();
		public static int GetCacheCurrentMemoryCapacity();
		public static void ClearWWWCache();
		public static WebProxy GetDefaultProxy();
		public static void RequestReview();
		public static void RequestPermissions(params string[] permissions);
		public static void CheckAndRequestPermissions(params string[] permissions);
		public static bool ShouldShowRequestPermissionRationale(params string[] permissions);
		public static bool CheckSelfPermissions(params string[] permissions);
		private static string[] GetPermissionsArray(params string[] permissions);
		public static string GetLocaleString();
		public static string GetLanguageAndScriptCode();
		public static string GetCountryCode();
		public static CLAuthorizationStatus GetCLAuthorizationStatus();
		public static float GetVersionIOS();
		public static int GetVMFootPrint();
		public static int GetVMFInternalAndCompress();
	}
}
