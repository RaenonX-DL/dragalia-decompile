/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Firebase;
using UnityEngine.Scripting;

// Image 49: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	[Preserve]
	public static class Crashlytics
	{
		// Properties
		public static bool IsCrashlyticsCollectionEnabled { get; set; }
	
		// Nested types
		[Preserve]
		internal static class PlatformAccessor
		{
			// Fields
			private static ExceptionHandler _exceptionHandler;
			private static Impl _impl;
			private static FirebaseApp _app;
	
			// Properties
			[Preserve]
			internal static ExceptionHandler ExceptionHandler { get; }
			internal static Impl Impl { get; }
			[Preserve]
			internal static FirebaseApp App { get; }
	
			// Constructors
			static PlatformAccessor();
		}
	
		// Methods
		[Preserve]
		private static void Initialize();
		public static void Log(string message);
		public static void SetCustomKey(string key, string value);
		public static void SetUserId(string identifier);
		public static void LogException(Exception exception);
	}
}
