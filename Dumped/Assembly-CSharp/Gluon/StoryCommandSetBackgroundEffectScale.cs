﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandSetBackgroundEffectScale : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public StoryCommandSetBackgroundEffectScale __4__this;
			public string effectId;
			public float x;
			public float y;
			public float fadeSec;
			public int ease;
			public float baseX;
			public float baseY;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public EffectObject effect;
	
			// Constructors
			public __c__DisplayClass1_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_1
		{
			// Fields
			public Vector3 baseScale;
			public Vector3 toScale;
			public __c__DisplayClass1_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass1_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_2
		{
			// Fields
			public Tweener tween;
			public __c__DisplayClass1_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass1_2();
	
			// Methods
			internal void _SetBackgroundEffectScale_b__0(float fade);
		}
	
		// Constructors
		public StoryCommandSetBackgroundEffectScale();
	
		// Methods
		public void Start(string effectId, float x, float y, float fadeSec = 0f, int ease = 1, float baseX = -1f, float baseY = -1f);
		private void SetBackgroundEffectScale(string effectId, float x, float y, float fadeSec = 0f, int ease = 1, float baseX = -1f, float baseY = -1f);
	}
}
