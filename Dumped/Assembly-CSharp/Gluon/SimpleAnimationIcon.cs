/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleAnimationIcon : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Type type;
		[HideInInspector]
		public int delayIndex;
		private RectTransform rectTransform;
		private const float expandRate = 1.15f;
		private const float expandDuration = 0.26666668f;
		private const float bounceDuration = 0.13333334f;
		private const float fadeInDuration = 0.5f;
		private CanvasGroup canvasGroup;
	
		// Nested types
		public enum Type
		{
			ExpandWithDelay = 0,
			Expand = 1,
			FadeIn = 2,
			None = 3
		}
	
		// Constructors
		public SimpleAnimationIcon();
	
		// Methods
		private void Awake();
		private void Start();
		public void StartAnimation();
		public static float GetDelayTimeByAnimationType(int index, Type animType);
		protected void StartExpandAnimation(float delay);
		public void SkipAnimation();
		protected void StartFadeInAnimation(float delay);
		[CompilerGenerated]
		private void _StartExpandAnimation_b__13_0(float value);
		[CompilerGenerated]
		private void _StartExpandAnimation_b__13_1();
		[CompilerGenerated]
		private void _StartExpandAnimation_b__13_2(float value);
		[CompilerGenerated]
		private void _StartFadeInAnimation_b__15_0(float value);
	}
}
