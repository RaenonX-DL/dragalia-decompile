/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandCharacterShakeVertical : IStoryCommand
	{
		// Fields
		private bool isVertical;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public StoryCharacter data;
			public bool isStart;
			public StoryCommandCharacterShakeVertical __4__this;
			public StoryImageManager.StrongType strongType;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandCharacterShakeVertical();
	
		// Methods
		public void Start(string charaId, int type, bool isStart);
	}
}
