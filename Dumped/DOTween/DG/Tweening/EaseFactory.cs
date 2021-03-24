/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening
{
	public class EaseFactory
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public float motionDelay;
			public EaseFunction customEase;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal float _StopMotion_b__0(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		// Constructors
		public EaseFactory();
	
		// Methods
		public static EaseFunction StopMotion(int motionFps, Ease? ease = default);
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve);
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase);
	}
}
