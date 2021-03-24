/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Core.Easing
{
	public static class EaseManager
	{
		// Fields
		private const float _PiOver2 = 1.5707964f;
		private const float _TwoPi = 6.2831855f;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static EaseFunction __9__4_0;
			public static EaseFunction __9__4_1;
			public static EaseFunction __9__4_2;
			public static EaseFunction __9__4_3;
			public static EaseFunction __9__4_4;
			public static EaseFunction __9__4_5;
			public static EaseFunction __9__4_6;
			public static EaseFunction __9__4_7;
			public static EaseFunction __9__4_8;
			public static EaseFunction __9__4_9;
			public static EaseFunction __9__4_10;
			public static EaseFunction __9__4_11;
			public static EaseFunction __9__4_12;
			public static EaseFunction __9__4_13;
			public static EaseFunction __9__4_14;
			public static EaseFunction __9__4_15;
			public static EaseFunction __9__4_16;
			public static EaseFunction __9__4_17;
			public static EaseFunction __9__4_18;
			public static EaseFunction __9__4_19;
			public static EaseFunction __9__4_20;
			public static EaseFunction __9__4_21;
			public static EaseFunction __9__4_22;
			public static EaseFunction __9__4_23;
			public static EaseFunction __9__4_24;
			public static EaseFunction __9__4_25;
			public static EaseFunction __9__4_26;
			public static EaseFunction __9__4_27;
			public static EaseFunction __9__4_28;
			public static EaseFunction __9__4_29;
			public static EaseFunction __9__4_30;
			public static EaseFunction __9__4_31;
			public static EaseFunction __9__4_32;
			public static EaseFunction __9__4_33;
			public static EaseFunction __9__4_34;
			public static EaseFunction __9__4_35;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal float _ToEaseFunction_b__4_0(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_1(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_2(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_3(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_4(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_5(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_6(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_7(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_8(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_9(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_10(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_11(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_12(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_13(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_14(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_15(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_16(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_17(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_18(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_19(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_20(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_21(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_22(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_23(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_24(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_25(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_26(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_27(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_28(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_29(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_30(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_31(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_32(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_33(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_34(float time, float duration, float overshootOrAmplitude, float period);
			internal float _ToEaseFunction_b__4_35(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		// Methods
		public static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period);
		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period);
		public static EaseFunction ToEaseFunction(Ease ease);
		internal static bool IsFlashEase(Ease ease);
	}
}
