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
	public class StoryCommandCharacterActionManual : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public bool isNewAct;
			public float moveSec;
			public int moveEase;
			public float scaleSec;
			public int scaleEase;
			public float rotateSec;
			public int rotateEase;
			public float rotate;
			public float fadeSec;
			public int fadeEase;
			public float fade;
	
			// Constructors
			public __c__DisplayClass0_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_1
		{
			// Fields
			public StoryCharacter data;
			public Vector2 moveValue;
			public Vector3 scaleValue;
			public __c__DisplayClass0_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass0_1();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandCharacterActionManual();
	
		// Methods
		public void Start(string charaId, bool isNewAct, float moveSec, float moveX, float moveY, int moveEase, float scaleSec = 0f, float scaleX = 0f, float scaleY = 0f, int scaleEase = 0, float rotateSec = 0f, float rotate = 0f, int rotateEase = 0, float fadeSec = 0f, float fade = 0f, int fadeEase = 0);
	}
}
