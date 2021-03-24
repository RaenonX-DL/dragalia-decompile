/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class TweenUtil
	{
		// Fields
		private static bool isInitialize;
		private static List<Tweener> inGameTweenerList;
	
		// Nested types
		public struct ColorModulusArgs
		{
			// Fields
			public SpriteRenderer image;
			public MaterialPropertyBlock propertyBlock;
			public int propertyId;
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static DOGetter<float> __9__2_0;
			public static DOSetter<float> __9__2_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal float _Init_b__2_0();
			internal void _Init_b__2_1(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public float from;
			public Action<float> callback;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal float _ValueTo_b__0();
			internal void _ValueTo_b__1(float v);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public Vector4 from;
			public Action<Vector4> callback;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal Vector4 _ValueTo_b__0();
			internal void _ValueTo_b__1(Vector4 v);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Vector3 from;
			public Action<Vector3> callback;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal Vector3 _ValueTo_b__0();
			internal void _ValueTo_b__1(Vector3 v);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public CanvasGroup canvasgroup;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _AlphaTo_b__0(float a);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public CanvasGroup canvasgroup;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _AlphaTo_b__0(float a);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public Image image;
			public bool isAtlas;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _ColorModulusTo_b__0(float ev);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public ColorModulusArgs args;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _ColorModulusTo_b__0(float ev);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public ColorModulusArgs args;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _ColorModulusTo_b__0(Vector4 ev);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public int initialValue;
			public UnityEngine.UI.Text text;
			public int digits;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal int _DOTextInt_b__0();
			internal void _DOTextInt_b__1(int it);
		}
	
		// Constructors
		static TweenUtil();
	
		// Methods
		public static void Init(bool isInGame);
		public static void SetDefaultTimeScaleIndependent(bool timeIndependent);
		public static Tweener ValueTo(float from, float to, float duration, Action<float> callback = null);
		public static Tweener ValueTo(Vector4 from, Vector4 to, float duration, Action<Vector4> callback = null);
		public static Tweener ValueTo(Vector3 from, Vector3 to, float duration, Action<Vector3> callback = null);
		public static Sequence ValueTo(float from, float to, float duration, float delay, Action<float> callback = null);
		public static Tweener AlphaTo(CanvasGroup canvasgroup, float from, float to, float duration);
		public static Sequence AlphaTo(CanvasGroup canvasgroup, float from, float to, float duration, float delay);
		public static Tweener Wait(float duration, Action<float> callback = null);
		public static Tweener ColorModulusTo(Image image, float from, float to, float duration, bool useCurrentFromValue, bool isAtlas);
		public static Tweener DoExposure(ColorModulusArgs args, float fromEvBy255, float toEvBy255, float duration, bool isAtlas);
		public static Tweener ColorModulusTo(ColorModulusArgs args, float from, float to, float duration, bool isAtlas);
		public static void SetColorModulus(ColorModulusArgs args, float ev);
		public static Tweener DoExposure(ColorModulusArgs args, Vector4 fromEvBy255, Vector4 toEvBy255, float duration);
		public static Tweener ColorModulusTo(ColorModulusArgs args, Vector4 from, Vector4 to, float duration);
		public static void SetColorModulus(ColorModulusArgs args, Vector4 ev);
		public static Tweener DOTextInt(UnityEngine.UI.Text text, int initialValue, int finalValue, float duration, int digits);
		public static string GetFormatText(int it, int digits);
		public static void ReleaseInGameTweeners();
	
		// Extension methods
		public static Tweener ForInGame(this Tweener tweener);
	}
}
