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
	public class StoryCommandSetCharacterEyeBlink : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCommandSetCharacterEyeBlink __4__this;
			public string charaId;
			public float intervalMin;
			public float intervalMax;
			public float eyeBlinkingTime;
			public int maxEyeBlinkFrame;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandSetCharacterEyeBlink();
	
		// Methods
		public void Start(string charaId, float intervalMin = 2f, float intervalMax = 5f, float eyeBlinkingTime = 0.05f, int maxEyeBlinkFrame = 2);
		private void SetCharacterEyeBlink(string charaId, float intervalMin, float intervalMax, float eyeBlinkingTime, int eyeBlinkCutNum);
	}
}
