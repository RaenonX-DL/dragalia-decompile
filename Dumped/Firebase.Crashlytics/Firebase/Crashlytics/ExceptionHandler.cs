/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 49: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	internal class ExceptionHandler
	{
		// Fields
		private bool isRegistered;
	
		// Constructors
		public ExceptionHandler();
	
		// Methods
		internal void Register();
		internal void HandleException(object sender, UnhandledExceptionEventArgs eArgs);
		internal void HandleLog(string message, string stackTraceString, LogType type);
		private string[] getMessageParts(string message);
		internal virtual void LogException(LoggedException e);
	}
}
