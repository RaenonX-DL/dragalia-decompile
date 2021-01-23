/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 39: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Platform
{
	internal static class PlatformInformation
	{
		// Fields
		private static string runtimeVersion;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private static float _RealtimeSinceStartupSafe_k__BackingField;
		[CompilerGenerated]
		private static Func<string> __f__am_cache0;
		[CompilerGenerated]
		private static Func<string> __f__am_cache1;
	
		// Properties
		internal static bool IsAndroid { get; }
		internal static bool IsIOS { get; }
		internal static string DefaultConfigLocation { get; }
		internal static float RealtimeSinceStartup { get; }
		internal static float RealtimeSinceStartupSafe { [CompilerGenerated] set; }
		internal static string RuntimeName { get; }
		internal static string RuntimeVersion { get; }
	
		// Methods
		[CompilerGenerated]
		private static string _get_DefaultConfigLocation_m__0();
		[CompilerGenerated]
		private static string _get_RuntimeVersion_m__1();
	}
}
