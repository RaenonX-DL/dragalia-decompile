/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AIScriptLoader
	{
		// Fields
		private const string scriptPath = "AIScript/";
		private const string scriptDirectoryPath = "Assets/_GluonResources/AIScriptWork/";
		private const string outputDirectoryPath = "Assets/_GluonResources/Resources/AIScript/";
		private const string outputSyntaxLogName = "Gluon/Action/Enabled Output SyntaxLog";
		private Dictionary<string, AIScriptParser> _dict;
	
		// Constructors
		public AIScriptLoader();
	
		// Methods
		public AIScriptParser Load(string scriptFile);
		private void Clear();
	}
}
