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
	public class StoryCommandSetCharacterLipSynch : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCommandSetCharacterLipSynch __4__this;
			public string charaId;
			public float intervalMin;
			public float intervalMax;
			public float lipSynchingTime;
			public int maxLipSynchFrame;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandSetCharacterLipSynch();
	
		// Methods
		public void Start(string charaId, float intervalMin = 0.06666667f, float intervalMax = 0.06666667f, float lipSynchingTime = 0.1f, int maxLipSynchFrame = 2);
		private void SetCharacterLipSynch(string charaId, float intervalMin, float intervalMax, float lipSynchingTime, int maxLipSynchFrame);
	}
}
