using System.Net;
using UnityEngine;

namespace Cute.Core
{
	public static class NativePluginWrapper
	{
		public enum BatteryState
		{
			Unknown,
			Discharging,
			Charging,
			Full
		}

		public enum NetworkMode
		{
			Unconnected,
			WiFi,
			Mobile
		}

		public enum CLAuthorizationStatus
		{
			NotDetermined,
			Restricted,
			Denied,
			AuthorizedAlways,
			AuthorizedWhenInUse
		}

		private static AndroidJavaClass nativePluginJavaClass;

		public static void DeviceInit()
		{
		}

		public static int GetUseResidentMemory()
		{
			return default(int);
		}

		public static int GetUseVirtualMemory()
		{
			return default(int);
		}

		public static int GetDeviceFreeMemory()
		{
			return default(int);
		}

		public static int GetVmUseMemory()
		{
			return default(int);
		}

		public static int GetVmFreeMemory()
		{
			return default(int);
		}

		public static void SetStringToClipboard(string copyText)
		{
		}

		public static int GetAccelerometerRotation()
		{
			return default(int);
		}

		public static void RequestAudioFocus()
		{
		}

		public static void AbandonAudioFocus()
		{
		}

		public static string GetMacAddressByName(string devicename)
		{
			return null;
		}

		public static void DispStatusBar(bool display)
		{
		}

		public static void RegistPhoneStateListener()
		{
		}

		public static void UnregistPhoneStateListener()
		{
		}

		public static int GetBatteryLevel()
		{
			return default(int);
		}

		public static BatteryState GetBatteryState()
		{
			return default(BatteryState);
		}

		public static int GetWifiAntenaLevel()
		{
			return default(int);
		}

		public static NetworkMode GetNetworkMode()
		{
			return default(NetworkMode);
		}

		public static bool IsAirplaneMode()
		{
			return default(bool);
		}

		public static void ShowToast(string text)
		{
		}

		public static void DumpWWWCache()
		{
		}

		public static int GetCacheDiskUsage()
		{
			return default(int);
		}

		public static int GetCacheDiskCapacity()
		{
			return default(int);
		}

		public static int GetCacheCurrentMemoryUsage()
		{
			return default(int);
		}

		public static int GetCacheCurrentMemoryCapacity()
		{
			return default(int);
		}

		public static void ClearWWWCache()
		{
		}

		public static WebProxy GetDefaultProxy()
		{
			return null;
		}

		public static void RequestReview()
		{
		}

		public static void RequestPermissions(string[] permissions)
		{
		}

		public static void CheckAndRequestPermissions(string[] permissions)
		{
		}

		public static bool ShouldShowRequestPermissionRationale(string[] permissions)
		{
			return default(bool);
		}

		public static bool CheckSelfPermissions(string[] permissions)
		{
			return default(bool);
		}

		private static string[] GetPermissionsArray(string[] permissions)
		{
			return null;
		}

		public static string GetLocaleString()
		{
			return null;
		}

		public static string GetLanguageAndScriptCode()
		{
			return null;
		}

		public static string GetCountryCode()
		{
			return null;
		}

		public static CLAuthorizationStatus GetCLAuthorizationStatus()
		{
			return default(CLAuthorizationStatus);
		}

		public static float GetVersionIOS()
		{
			return default(float);
		}

		public static int GetVMFootPrint()
		{
			return default(int);
		}

		public static int GetVMFInternalAndCompress()
		{
			return default(int);
		}
	}
}
