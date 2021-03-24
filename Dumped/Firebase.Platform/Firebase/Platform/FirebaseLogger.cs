/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Platform
{
	internal class FirebaseLogger
	{
		// Fields
		private static MainThreadProperty<bool> incompatibleStackUnwindingEnabled;
		[CompilerGenerated]
		private static Func<bool> __f__mg_cache0;
	
		// Properties
		internal static bool CanRedirectNativeLogs { get; }
	
		// Constructors
		static FirebaseLogger();
	
		// Methods
		private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType);
		private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs();
		internal static void LogMessage(PlatformLogLevel logLevel, string message);
	}
}
