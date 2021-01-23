/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandSetCameraDistortion : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCommandSetCameraDistortion __4__this;
			public int cameraType;
			public bool enable;
	
			// Constructors
			public __c__DisplayClass0_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_1
		{
			// Fields
			public EffectObject effect;
			public __c__DisplayClass0_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass0_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_2
		{
			// Fields
			public Tweener tween;
			public __c__DisplayClass0_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass0_2();
	
			// Methods
			internal void _Start_b__0(float fade);
		}
	
		// Constructors
		public StoryCommandSetCameraDistortion();
	
		// Methods
		public void Start(int cameraType, bool enable, string effectId = "");
		private void SetCameraDistortion(int cameraType, bool enable);
	}
}
