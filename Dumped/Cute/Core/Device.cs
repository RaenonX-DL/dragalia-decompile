using System;

namespace Cute.Core
{
	public static class Device
	{
		private static string buildVersion;

		private static string persistentDataPath;

		public static string GetModelName()
		{
			return null;
		}

		public static string GetAppVersion()
		{
			return null;
		}

		public static string GetSignatureForClient()
		{
			return null;
		}

		public static string GetSignature()
		{
			return null;
		}

		public static bool IsIllegalUser()
		{
			return default(bool);
		}

		public static void IsEmulator(Action<bool> finishCallback)
		{
		}

		public static string GetCarrier()
		{
			return null;
		}

		private static string GetAndroidVersion()
		{
			return null;
		}

		private static string GetAndroidCarrier()
		{
			return null;
		}

		public static string GetPersistentDataPath()
		{
			return null;
		}

		public static float GetBatteryTemperature()
		{
			return default(float);
		}
	}
}
