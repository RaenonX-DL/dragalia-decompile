/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 50: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	internal class Lexer
	{
		// Fields
		private static int[] fsm_return_table;
		private static StateHandler[] fsm_handler_table;
		private bool allow_comments;
		private bool allow_single_quoted_strings;
		private bool end_of_input;
		private FsmContext fsm_context;
		private int input_buffer;
		private int input_char;
		private TextReader reader;
		private int state;
		private StringBuilder string_buffer;
		private string string_value;
		private int token;
		private int unichar;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache0;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache1;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache2;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache3;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache4;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache5;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache6;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache7;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache8;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache9;
		[CompilerGenerated]
		private static StateHandler __f__mg_cacheA;
		[CompilerGenerated]
		private static StateHandler __f__mg_cacheB;
		[CompilerGenerated]
		private static StateHandler __f__mg_cacheC;
		[CompilerGenerated]
		private static StateHandler __f__mg_cacheD;
		[CompilerGenerated]
		private static StateHandler __f__mg_cacheE;
		[CompilerGenerated]
		private static StateHandler __f__mg_cacheF;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache10;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache11;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache12;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache13;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache14;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache15;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache16;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache17;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache18;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache19;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache1A;
		[CompilerGenerated]
		private static StateHandler __f__mg_cache1B;
	
		// Properties
		public bool EndOfInput { get; }
		public int Token { get; }
		public string StringValue { get; }
	
		// Nested types
		private delegate bool StateHandler(FsmContext ctx);
	
		// Constructors
		static Lexer();
		public Lexer(TextReader reader);
	
		// Methods
		private static int HexValue(int digit);
		private static void PopulateFsmTables();
		private static char ProcessEscChar(int esc_char);
		private static bool State1(FsmContext ctx);
		private static bool State2(FsmContext ctx);
		private static bool State3(FsmContext ctx);
		private static bool State4(FsmContext ctx);
		private static bool State5(FsmContext ctx);
		private static bool State6(FsmContext ctx);
		private static bool State7(FsmContext ctx);
		private static bool State8(FsmContext ctx);
		private static bool State9(FsmContext ctx);
		private static bool State10(FsmContext ctx);
		private static bool State11(FsmContext ctx);
		private static bool State12(FsmContext ctx);
		private static bool State13(FsmContext ctx);
		private static bool State14(FsmContext ctx);
		private static bool State15(FsmContext ctx);
		private static bool State16(FsmContext ctx);
		private static bool State17(FsmContext ctx);
		private static bool State18(FsmContext ctx);
		private static bool State19(FsmContext ctx);
		private static bool State20(FsmContext ctx);
		private static bool State21(FsmContext ctx);
		private static bool State22(FsmContext ctx);
		private static bool State23(FsmContext ctx);
		private static bool State24(FsmContext ctx);
		private static bool State25(FsmContext ctx);
		private static bool State26(FsmContext ctx);
		private static bool State27(FsmContext ctx);
		private static bool State28(FsmContext ctx);
		private bool GetChar();
		private int NextChar();
		public bool NextToken();
		private void UngetChar();
	}
}
