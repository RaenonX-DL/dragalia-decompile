/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandBackgroundEnableShader : IStoryCommand
	{
		// Fields
		private string[] callFuncNames;
	
		// Nested types
		private enum ShaderFuncs
		{
			Front1 = 0,
			Front2 = 1,
			Back1 = 2,
			Back2 = 3
		}
	
		// Constructors
		public StoryCommandBackgroundEnableShader();
	
		// Methods
		public void Start(string bgId, params bool[] enables);
	}
}
