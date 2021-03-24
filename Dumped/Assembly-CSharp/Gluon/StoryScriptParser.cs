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
	public class StoryScriptParser
	{
		// Fields
		private StoryFunction currentFunction;
		private StoryScript storyScript;
		private int numIf;
		private int numEndIf;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<string, bool> __9__7_1;
			public static Func<string, bool> __9__7_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _ParseCommand_b__7_1(string w);
			internal bool _ParseCommand_b__7_0(string w);
		}
	
		// Constructors
		public StoryScriptParser();
	
		// Methods
		public StoryScript Parse(string text, string filename);
		private string ParseComment(string line, ref bool isComment);
		private void ParseLine(string line, int row);
		private void ParseCommand(string line, int row, ref int current, List<StoryCommand> commandList);
	}
}
