/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SharpJson
{
	internal class Lexer
	{
		// Fields
		[CompilerGenerated]
		private int _lineNumber_k__BackingField;
		[CompilerGenerated]
		private bool _parseNumbersAsFloat_k__BackingField;
		private char[] json;
		private int index;
		private bool success;
		private char[] stringBuffer;
	
		// Properties
		public bool hasError { get; }
		public int lineNumber { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool parseNumbersAsFloat { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum Token
		{
			None = 0,
			Null = 1,
			True = 2,
			False = 3,
			Colon = 4,
			Comma = 5,
			String = 6,
			Number = 7,
			CurlyOpen = 8,
			CurlyClose = 9,
			SquaredOpen = 10,
			SquaredClose = 11
		}
	
		// Constructors
		public Lexer(string text);
	
		// Methods
		public void Reset();
		public string ParseString();
		private string GetNumberString();
		public float ParseFloatNumber();
		public double ParseDoubleNumber();
		private int GetLastIndexOfNumber(int index);
		private void SkipWhiteSpaces();
		public Token LookAhead();
		public Token NextToken();
		private static Token NextToken(char[] json, ref int index);
	}
}
