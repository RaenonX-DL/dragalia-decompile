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
	public class StoryCommandNextScript : IStoryCommand
	{
		// Nested types
		public enum ScriptType
		{
			Main = 1,
			Event = 2,
			Chara = 3,
			Dragon = 4,
			Castle = 5,
			Tutorial = 6
		}
	
		// Constructors
		public StoryCommandNextScript();
	
		// Methods
		public void Start(string scriptName, int type = 1);
		public override bool Update();
		public string[] GetResourceNames(string scriptName, int type = 1);
	}
}
