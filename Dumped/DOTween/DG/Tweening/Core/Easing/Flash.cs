﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Core.Easing
{
	public static class Flash
	{
		// Methods
		public static float Ease(float time, float duration, float overshootOrAmplitude, float period);
		public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period);
		public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period);
		public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period);
		private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res);
	}
}
