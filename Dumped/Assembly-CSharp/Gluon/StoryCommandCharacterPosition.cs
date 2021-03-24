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
	public class StoryCommandCharacterPosition : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCommandCharacterPosition __4__this;
			public string charaId;
	
			// Constructors
			public __c__DisplayClass0_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_1
		{
			// Fields
			public Vector2 position;
			public __c__DisplayClass0_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass0_1();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandCharacterPosition();
	
		// Methods
		public void Start(string charaId, int valueX = 0, int valueY = 0);
		private void SetPosition(string charaId, Vector2 position);
	}
}
