﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandCharacterFace : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCommandCharacterFace __4__this;
			public string charaId;
			public int faceId;
			public int faceNum;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandCharacterFace();
	
		// Methods
		public void Start(string charaId, int faceId, int faceNum = 0);
		private void SetCharacterFace(string charaId, int faceId, int faceNum);
		public string[] GetResourceNames(string charaId, int faceId, int faceNum = 0);
	}
}
