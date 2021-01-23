/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public static class Device
	{
		// Fields
		private static string buildVersion;
		private static string persistentDataPath;
	
		// Constructors
		static Device();
	
		// Methods
		public static string GetModelName();
		public static string GetAppVersion();
		public static string GetSignatureForClient();
		public static string GetSignature();
		public static bool IsIllegalUser();
		public static void IsEmulator(Action<bool> finishCallback);
		public static string GetCarrier();
		private static string GetAndroidVersion();
		private static string GetAndroidCarrier();
		public static string GetPersistentDataPath();
		public static float GetBatteryTemperature();
	}
}
