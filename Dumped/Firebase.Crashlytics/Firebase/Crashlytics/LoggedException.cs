/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 49: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	internal class LoggedException : Exception
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable]
		private string _Name_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private string _CustomStackTrace_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private Dictionary<string, string>[] _ParsedStackTrace_k__BackingField;
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string CustomStackTrace { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<string, string>[] ParsedStackTrace { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public LoggedException(string name, string message, string stackTrace);
	
		// Methods
		public static LoggedException FromException(Exception exception);
	}
}
