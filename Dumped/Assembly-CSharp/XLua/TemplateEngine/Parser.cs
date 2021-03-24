/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua.TemplateEngine
{
	public class Parser
	{
		// Fields
		[CompilerGenerated]
		private static string _RegexString_k__BackingField;
	
		// Properties
		public static string RegexString { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<Capture, __f__AnonymousType0<TokenType, string, int>> __9__7_0;
			public static Func<Capture, __f__AnonymousType0<TokenType, string, int>> __9__7_1;
			public static Func<Capture, __f__AnonymousType0<TokenType, string, int>> __9__7_2;
			public static Func<__f__AnonymousType0<TokenType, string, int>, int> __9__7_3;
			public static Func<__f__AnonymousType0<TokenType, string, int>, Chunk> __9__7_4;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal __f__AnonymousType0<TokenType, string, int> _Parse_b__7_0(Capture p);
			internal __f__AnonymousType0<TokenType, string, int> _Parse_b__7_1(Capture p);
			internal __f__AnonymousType0<TokenType, string, int> _Parse_b__7_2(Capture p);
			internal int _Parse_b__7_3(__f__AnonymousType0<TokenType, string, int> p);
			internal Chunk _Parse_b__7_4(__f__AnonymousType0<TokenType, string, int> m);
		}
	
		// Constructors
		static Parser();
		public Parser();
	
		// Methods
		private static string EscapeString(string input);
		private static string GetRegexString();
		public static List<Chunk> Parse(string snippet);
	}
}
