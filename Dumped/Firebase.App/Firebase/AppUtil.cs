/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 41: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	internal class AppUtil
	{
		// Methods
		internal static void PollCallbacks();
		internal static void AppEnableLogCallback(bool arg0);
		internal static void SetEnabledAllAppCallbacks(bool arg0);
		internal static void SetEnabledAppCallbackByName(string arg0, bool arg1);
		internal static bool GetEnabledAppCallbackByName(string arg0);
		internal static void SetLogFunction(LogUtil.LogMessageDelegate arg0);
		public static GooglePlayServicesAvailability CheckAndroidDependencies();
		public static Task FixAndroidDependenciesAsync();
		internal static void InitializePlayServicesInternal();
		internal static void TerminatePlayServicesInternal();
	}
}
