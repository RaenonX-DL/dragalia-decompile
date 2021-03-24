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
	public class AIScriptParser
	{
		// Fields
		private Dictionary<string, List<AIScriptContainer>> _scriptFunctions;
	
		// Constructors
		public AIScriptParser(AIScriptObject script);
	
		// Methods
		public List<AIScriptContainer> GetScriptFunction(string functionName);
		public bool IsScriptFunction(string functionName);
		private void Build(AIScriptObject script);
	}
}
