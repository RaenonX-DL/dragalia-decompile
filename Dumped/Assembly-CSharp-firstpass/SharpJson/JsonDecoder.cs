/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SharpJson
{
	public class JsonDecoder
	{
		// Fields
		[CompilerGenerated]
		private string _errorMessage_k__BackingField;
		[CompilerGenerated]
		private bool _parseNumbersAsFloat_k__BackingField;
		private Lexer lexer;
	
		// Properties
		public string errorMessage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool parseNumbersAsFloat { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public JsonDecoder();
	
		// Methods
		public object Decode(string text);
		public static object DecodeText(string text);
		private IDictionary<string, object> ParseObject();
		private IList<object> ParseArray();
		private object ParseValue();
		private void TriggerError(string message);
		private T EvalLexer<T>(T value);
	}
}
