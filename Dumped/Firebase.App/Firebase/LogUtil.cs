/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Firebase.Platform;

// Image 43: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	internal sealed class LogUtil : IDisposable
	{
		// Fields
		private static LogUtil _instance;
		private static object InitializeLoggingLock;
		private bool _disposed;
		[CompilerGenerated]
		private static LogMessageDelegate __f__mg_cache0;
	
		// Nested types
		internal delegate void LogMessageDelegate(LogLevel log_level, string message);
	
		// Constructors
		static LogUtil();
		public LogUtil();
	
		// Methods
		public static void InitializeLogging();
		internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel);
		internal static void LogMessage(LogLevel logLevel, string message);
		[MonoPInvokeCallback]
		internal static void LogMessageFromCallback(LogLevel logLevel, string message);
		~LogUtil();
		public void Dispose();
		protected void Dispose(bool disposing);
	}
}
