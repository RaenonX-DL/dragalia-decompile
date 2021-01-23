/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonPanelAnimation : MonoBehaviour
	{
		// Nested types
		public enum DirectionEnum
		{
			x = 0,
			y = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public Transform t;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _DoPartExitToLeftAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Transform t;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _DoPartExitToBottomAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _DoFlashingAnimation_b__0();
		}
	
		// Constructors
		public CommonPanelAnimation();
	
		// Methods
		public static Sequence DoPanelFadeInUpwardAnimation(Transform t, float yDiff, float delay = 0f, float baseDuration = 0.5f);
		public static Sequence DoPanelFadeOutUpwardAnimation(Transform t, float yDiff, float delay = 0f, float baseDuration = 0.5f);
		public static Sequence DoPartExitToLeftAnimation(Transform t, float delay = 0f, float distance = 0f);
		public static Sequence DoPartExitToBottomAnimation(Transform t, float delay = 0f, float distance = 0f);
		public static Sequence DoFlashingAnimation(Transform t);
		public static Sequence FadeOutAnimation(Transform t, float diff, float delay = 0f, float baseDuration = 0.5f, DirectionEnum direction = DirectionEnum.y, Ease ease = Ease.OutCubic);
		public static Sequence FadeInAnimation(Transform t, float diff, float delay = 0f, float baseDuration = 0.5f, DirectionEnum direction = DirectionEnum.y, Ease ease = Ease.OutCubic);
		public static Sequence FadeInAnimationXY(Transform t, Vector2 pos, Vector2 nextPos, float delay = 0f, float baseDuration = 0.5f, float nextBaseDuration = 0.5f, Ease ease = Ease.OutCubic, Ease nextEase = Ease.OutCubic);
	}
}
