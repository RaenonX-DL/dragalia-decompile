/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.OurUtils
{
	public class Logger
	{
		// Fields
		private static bool debugLogEnabled;
		private static bool warningLogEnabled;
	
		// Properties
		public static bool DebugLogEnabled { get; set; }
		public static bool WarningLogEnabled { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _d_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _w_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _e_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__12_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ToLogMessage_b__12_0();
		}
	
		// Constructors
		public Logger();
		static Logger();
	
		// Methods
		public static void d(string msg);
		public static void w(string msg);
		public static void e(string msg);
		public static string describe(byte[] b);
		private static string ToLogMessage(string prefix, string logType, string msg);
	}
}
