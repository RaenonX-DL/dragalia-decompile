/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 47: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	public class JsonWriter
	{
		// Fields
		private static NumberFormatInfo number_format;
		private WriterContext context;
		private Stack<WriterContext> ctx_stack;
		private bool has_reached_end;
		private char[] hex_seq;
		private int indentation;
		private int indent_value;
		private StringBuilder inst_string_builder;
		private bool pretty_print;
		private bool validate;
		private TextWriter writer;
	
		// Properties
		public TextWriter TextWriter { get; }
		public bool Validate { get; set; }
	
		// Constructors
		static JsonWriter();
		public JsonWriter();
		public JsonWriter(TextWriter writer);
	
		// Methods
		private void DoValidation(Condition cond);
		private void Init();
		private static void IntToHex(int n, char[] hex);
		private void Indent();
		private void Put(string str);
		private void PutNewline();
		private void PutNewline(bool add_comma);
		private void PutString(string str);
		private void Unindent();
		public override string ToString();
		public void Reset();
		public void Write(bool boolean);
		public void Write(decimal number);
		public void Write(double number);
		public void Write(int number);
		public void Write(long number);
		public void Write(string str);
		[CLSCompliant]
		public void Write(ulong number);
		public void WriteArrayEnd();
		public void WriteArrayStart();
		public void WriteObjectEnd();
		public void WriteObjectStart();
		public void WritePropertyName(string property_name);
	}
}
