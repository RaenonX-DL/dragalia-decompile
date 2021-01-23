/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Util
{
	internal static class Json
	{
		// Nested types
		private sealed class Parser : IDisposable
		{
			// Fields
			private StringReader json;
			[CompilerGenerated]
			private static Dictionary<string, int> __f__switch_map1;
	
			// Properties
			private char PeekChar { get; }
			private char NextChar { get; }
			private string NextWord { get; }
			private TOKEN NextToken { get; }
	
			// Nested types
			private enum TOKEN
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}
	
			// Constructors
			private Parser(string jsonString);
	
			// Methods
			public static bool IsWordBreak(char c);
			public static object Parse(string jsonString);
			public void Dispose();
			private Dictionary<string, object> ParseObject();
			private List<object> ParseArray();
			private object ParseValue();
			private object ParseByToken(TOKEN token);
			private string ParseString();
			private object ParseNumber();
			private void EatWhitespace();
		}
	
		private sealed class Serializer
		{
			// Fields
			private StringBuilder builder;
	
			// Constructors
			private Serializer();
	
			// Methods
			public static string Serialize(object obj);
			private void SerializeValue(object value);
			private void SerializeObject(IDictionary obj);
			private void SerializeArray(IList anArray);
			private void SerializeString(string str);
			private void SerializeOther(object value);
		}
	
		// Methods
		public static object Deserialize(string json);
		public static string Serialize(object json);
	}
}
