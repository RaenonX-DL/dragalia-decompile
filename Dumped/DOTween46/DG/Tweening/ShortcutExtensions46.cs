/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

// Image 45: DOTween46.dll - Assembly: DOTween46, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening
{
	public static class ShortcutExtensions46
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public CanvasGroup target;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal float _DOFade_b__0();
			internal void _DOFade_b__1(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public Graphic target;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal Color _DOFade_b__0();
			internal void _DOFade_b__1(Color x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Image target;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal Color _DOColor_b__0();
			internal void _DOColor_b__1(Color x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public Image target;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal Color _DOFade_b__0();
			internal void _DOFade_b__1(Color x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public RectTransform target;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal Vector2 _DOAnchorPos_b__0();
			internal void _DOAnchorPos_b__1(Vector2 x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public RectTransform target;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal Vector2 _DOAnchorPosX_b__0();
			internal void _DOAnchorPosX_b__1(Vector2 x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public RectTransform target;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal Vector2 _DOAnchorPosY_b__0();
			internal void _DOAnchorPosY_b__1(Vector2 x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public RectTransform target;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal Vector3 _DOAnchorPos3D_b__0();
			internal void _DOAnchorPos3D_b__1(Vector3 x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public RectTransform target;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal Vector2 _DOSizeDelta_b__0();
			internal void _DOSizeDelta_b__1(Vector2 x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public ScrollRect target;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal float _DOHorizontalNormalizedPos_b__0();
			internal void _DOHorizontalNormalizedPos_b__1(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public UnityEngine.UI.Text target;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal Color _DOColor_b__0();
			internal void _DOColor_b__1(Color x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public UnityEngine.UI.Text target;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal Color _DOFade_b__0();
			internal void _DOFade_b__1(Color x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public UnityEngine.UI.Text target;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal string _DOText_b__0();
			internal void _DOText_b__1(string x);
		}
	
		// Extension methods
		public static Tweener DOFade(this CanvasGroup target, float endValue, float duration);
		public static Tweener DOFade(this Graphic target, float endValue, float duration);
		public static Tweener DOColor(this Image target, Color endValue, float duration);
		public static Tweener DOFade(this Image target, float endValue, float duration);
		public static Tweener DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false);
		public static Tweener DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false);
		public static Tweener DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false);
		public static Tweener DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false);
		public static Tweener DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false);
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false);
		public static Tweener DOColor(this UnityEngine.UI.Text target, Color endValue, float duration);
		public static Tweener DOFade(this UnityEngine.UI.Text target, float endValue, float duration);
		public static Tweener DOText(this UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null);
	}
}
