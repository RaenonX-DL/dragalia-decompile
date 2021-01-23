/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 47: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	public class JsonReader
	{
		// Fields
		private static IDictionary<int, IDictionary<int, int[]>> parse_table;
		private Stack<int> automaton_stack;
		private int current_input;
		private int current_symbol;
		private bool end_of_json;
		private bool end_of_input;
		private Lexer lexer;
		private bool parser_in_string;
		private bool parser_return;
		private bool read_started;
		private TextReader reader;
		private bool reader_is_owned;
		private bool skip_non_members;
		private object token_value;
		private JsonToken token;
	
		// Properties
		public bool SkipNonMembers { get; }
		public JsonToken Token { get; }
		public object Value { get; }
	
		// Constructors
		static JsonReader();
		public JsonReader(string json_text);
		private JsonReader(TextReader reader, bool owned);
	
		// Methods
		private static void PopulateParseTable();
		private static void TableAddCol(ParserToken row, int col, params int[] symbols);
		private static void TableAddRow(ParserToken rule);
		private void ProcessNumber(string number);
		private void ProcessSymbol();
		private bool ReadToken();
		public void Close();
		public bool Read();
	}
}
