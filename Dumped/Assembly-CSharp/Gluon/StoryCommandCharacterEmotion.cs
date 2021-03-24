/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandCharacterEmotion : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCharacter data;
			public int emotionId;
			public int faceNum;
			public Vector2 offset;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandCharacterEmotion();
	
		// Methods
		public void Start(string charaId, int emotionId, int faceNum = 0, float offset_x = 0f, float offset_y = 0f);
	}
}
