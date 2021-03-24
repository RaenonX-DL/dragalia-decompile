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
	public class StoryCommandMessagePosition : IStoryCommand
	{
		// Nested types
		private enum Type
		{
			MessageWindow = 0,
			ChapterIntroduction = 1
		}
	
		// Constructors
		public StoryCommandMessagePosition();
	
		// Methods
		public void Start(params float[] pos);
	}
}
