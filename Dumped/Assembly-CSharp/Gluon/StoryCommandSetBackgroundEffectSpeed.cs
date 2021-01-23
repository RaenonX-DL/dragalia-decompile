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
	public class StoryCommandSetBackgroundEffectSpeed : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCommandSetBackgroundEffectSpeed __4__this;
			public string effectId;
			public float value;
			public float fadeSec;
			public int ease;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public float value;
	
			// Constructors
			public __c__DisplayClass1_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_1
		{
			// Fields
			public EffectObject effect;
			public __c__DisplayClass1_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass1_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_2
		{
			// Fields
			public Tweener tween;
			public float baseValue;
			public __c__DisplayClass1_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass1_2();
	
			// Methods
			internal void _SetBackgroundEffectSpeed_b__0(float fade);
		}
	
		// Constructors
		public StoryCommandSetBackgroundEffectSpeed();
	
		// Methods
		public void Start(string effectId, float value, float fadeSec = 0f, int ease = 1);
		private void SetBackgroundEffectSpeed(string effectId, float value, float fadeSec = 0f, int ease = 1);
	}
}
