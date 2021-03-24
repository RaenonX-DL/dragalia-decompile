/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ArithmeticOperations
	{
		// Fields
		private const string DECIMAL = "[\\+\\-]?\\d+(?:\\.\\d+)?";
		public const int SIGNIFICANT_DIGIT = 16;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public Func<string, string> toVal;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal string _EvaluateVariable_b__0(Match m);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<Match, string> __9__6_0;
			public static Func<Match, string> __9__7_0;
			public static Func<Match, string> __9__8_0;
			public static Func<Match, string> __9__11_0;
			public static Func<Match, string> __9__12_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _OperatorOrganize_b__6_0(Match baseMatch);
			internal string _BracketsOrganize_b__7_0(Match baseMatch);
			internal string _CalculationBrackets_b__8_0(Match baseMatch);
			internal string _MultiDiv_b__11_0(Match baseMatch);
			internal string _AddSub_b__12_0(Match baseMatch);
		}
	
		// Methods
		public static bool Calculate(string text, Func<string, string> toVal, out int result);
		public static bool Calculate(string text, Func<string, string> toVal, out float result);
		public static bool Calculate(string text, Func<string, string> toVal, out string result);
		private static string EvaluateVariable(string text, Func<string, string> toVal);
		private static string OperatorOrganize(string calcStr);
		private static string BracketsOrganize(string calcStr);
		private static string CalculationBrackets(string calcStr);
		private static string NormalCalculation(string calcStr);
		private static string CalculationBase(string calcStr, string pattern, Func<Match, string> callback, Match argMatch = null);
		private static string MultiDiv(string calcStr);
		private static string AddSub(string calcStr);
	
		// Extension methods
		public static string ToStringWithDigit(this double value, int digit);
		public static double ToDouble(this string str);
	}
}
