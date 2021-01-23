/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening
{
	public static class DOVirtual
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public float val;
			public TweenCallback<float> onVirtualUpdate;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal float _Float_b__0();
			internal void _Float_b__1(float x);
			internal void _Float_b__2();
		}
	
		// Methods
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate);
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType);
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot);
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period);
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve);
		public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true);
	}
}
