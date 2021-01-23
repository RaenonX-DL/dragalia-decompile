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
	public class SimpleAnimationCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Type type;
		[HideInInspector]
		public int delayIndex;
		public bool autoExcuteInStart;
		[CompilerGenerated]
		private RectTransform _rectTransform_k__BackingField;
		protected float fadeinDuration;
		protected float fadeOutDuration;
		protected float moveDistance;
		protected float delayFactor;
		protected float delayFactorFadeOut;
		[CompilerGenerated]
		private CanvasGroup _canvasGroup_k__BackingField;
		protected Sequence animationSequence;
		[CompilerGenerated]
		private bool _isOnAnimation_k__BackingField;
	
		// Properties
		public RectTransform rectTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CanvasGroup canvasGroup { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isOnAnimation { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum Type
		{
			FadeInUpward = 0,
			None = 1
		}
	
		// Constructors
		public SimpleAnimationCell();
	
		// Methods
		protected virtual void Awake();
		private void Start();
		public void StartAnimation();
		public void SetFadeInDuration(float v);
		public void StartFadeInUpwardAnimation(int delayIndex);
		public void StartFadeOutDownwardAnimation(int delayIndex);
		public void SkipAnimation();
		public void SetAlpha(float alpha);
		[CompilerGenerated]
		private void _StartFadeInUpwardAnimation_b__26_0();
		[CompilerGenerated]
		private void _StartFadeInUpwardAnimation_b__26_1();
		[CompilerGenerated]
		private void _StartFadeOutDownwardAnimation_b__27_0();
		[CompilerGenerated]
		private void _StartFadeOutDownwardAnimation_b__27_1();
	}
}
