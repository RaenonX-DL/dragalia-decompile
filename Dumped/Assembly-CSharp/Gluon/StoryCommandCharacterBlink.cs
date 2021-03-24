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
	public class StoryCommandCharacterBlink : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCharacter data;
			public float sec;
			public float minAlpha;
			public float maxAlpha;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandCharacterBlink();
	
		// Methods
		public void Start(string charaId, float sec, float minAlpha = 0f, float maxAlpha = 1f);
	}
}
