/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QREventResultBase : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected RectTransform topInfoTrans;
		[SerializeField]
		protected RectTransform gotRewardTrans;
		[SerializeField]
		protected RectTransform charaTrans;
		[SerializeField]
		protected RectTransform seriTrans;
		[SerializeField]
		protected UIAnimationPublisher publisher;
		[SerializeField]
		protected Image commonIconEffectImage;
		protected float enterDuration;
		protected float exitDuration;
		protected float moveUpDuration;
		protected float moveUpDistance;
		private float commonIconEffectDuration;
		public float overshootOrAmplitudeCustom;
		private CustomEaseFunction _easeFunction;
		protected Color bonusTextColor;
		[CompilerGenerated]
		private int _bonusValue_k__BackingField;
		protected QuestResultTopPage resultTop;
		private bool isButtonSlidedIn;
		[SerializeField]
		private Image seriArrowImage;
		private Vector3 arrowInitPos;
		private Tweener arrowTweener;
	
		// Properties
		public CustomEaseFunction easeFunction { get; }
		public int bonusValue { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public UnityAction onComplete;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _StartExitAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public UnityAction onComplete;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _MoveAndFade_b__1();
			internal void _MoveAndFade_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public CircleOutline outline;
			public Color oldColor;
			public UnityEngine.UI.Text nowGetMedal;
			public Vector3 oldScale;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _PlayGotRewardNumberAnimation_b__0(float value);
			internal void _PlayGotRewardNumberAnimation_b__1(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public OutGameBgChara bgCharacter;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal bool _WaitForPlayDifferenceImages_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForPlayDifferenceImages_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public OutGameBgChara bgCharacter;
			private __c__DisplayClass33_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForPlayDifferenceImages_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public Color imageColor;
			public QREventResultBase __4__this;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _ShowCommonIconEffectAnimation_b__0();
		}
	
		// Constructors
		public QREventResultBase();
	
		// Methods
		protected virtual void Start();
		private void OnDestroy();
		public virtual void StartEnterAnimation(bool isFadeInOutAnimation, UnityAction onComplete);
		public virtual void StartExitAnimation(bool isFadeInOutAnimation, UnityAction onComplete);
		protected void MoveAndFade(RectTransform trans, bool isEnter, UnityAction onComplete = null, float delay = 0f);
		protected void PlayGotRewardNumberAnimation(UnityEngine.UI.Text nowGetMedal, TweenCallback onComplete);
		protected void SlideInBottomButtons();
		protected void SetVisiblePageIcon(bool visible);
		[IteratorStateMachine]
		protected IEnumerator WaitForPlayDifferenceImages(OutGameBgChara bgCharacter);
		protected void ShowCommonIconEffectAnimation();
		[CompilerGenerated]
		private void _SetVisiblePageIcon_b__32_0(float fade);
	}
}
