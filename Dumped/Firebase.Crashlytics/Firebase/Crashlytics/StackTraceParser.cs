/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 46: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	internal class StackTraceParser
	{
		// Fields
		private static readonly string FrameArgsRegex;
		private static readonly string FrameRegexWithoutFileInfo;
		private static readonly string FrameRegexWithFileInfo;
		private static readonly string MonoFilenameUnknownString;
		private static readonly string[] StringDelimiters;
	
		// Constructors
		public StackTraceParser();
		static StackTraceParser();
	
		// Methods
		public static Dictionary<string, string>[] ParseStackTraceString(string stackTrace);
		private static Dictionary<string, string> ParseFrameString(string regex, string frameString);
	}
}
