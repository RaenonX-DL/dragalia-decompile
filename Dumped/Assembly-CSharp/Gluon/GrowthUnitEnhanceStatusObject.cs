/*
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
	public class GrowthUnitEnhanceStatusObject : MonoBehaviour
	{
		// Fields
		public GrowthUnitEnhanceStatusController controller;
		private RectTransform rectTransform;
		private CanvasGroup canvasGroup;
		private const float duration = 0.5f;
		private const float imageWidth = 484f;
		private const float imageY = -59.5f;
		private Color32 darkColor;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__9_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _StartShowingAnimation_b__9_1();
		}
	
		// Constructors
		public GrowthUnitEnhanceStatusObject();
	
		// Methods
		private void Awake();
		public void SetAlpha(float value);
		public void StartShowingAnimation(int direction);
		public void StartHidingAnimation(int direction);
		private void OnAlphaAnimationUpdate(float value);
		private void OnPositionAnimationUpdate(float value);
		private void OnPositionAnimationComplete();
		[CompilerGenerated]
		private void _StartShowingAnimation_b__9_0(float value);
		[CompilerGenerated]
		private void _StartShowingAnimation_b__9_2(float value);
		[CompilerGenerated]
		private void _StartShowingAnimation_b__9_3();
		[CompilerGenerated]
		private void _StartHidingAnimation_b__10_0(float value);
		[CompilerGenerated]
		private void _StartHidingAnimation_b__10_1(float value);
		[CompilerGenerated]
		private void _StartHidingAnimation_b__10_2();
	}
}
