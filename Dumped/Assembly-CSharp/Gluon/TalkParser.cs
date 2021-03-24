/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TalkParser
	{
		// Fields
		private static TalkParser _instance;
		private string[] RewordStr;
		private Dictionary<string, string> _rewordDict;
	
		// Properties
		public static TalkParser Instance { get; }
	
		// Nested types
		public enum Reword
		{
			BreakPlayer = 0
		}
	
		// Constructors
		public TalkParser();
	
		// Methods
		public static void Release();
		public void SetReword(Reword parser, string str);
		public string Parser(string str);
	}
}
