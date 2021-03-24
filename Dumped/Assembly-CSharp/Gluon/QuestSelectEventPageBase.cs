/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectEventPageBase : PageBase
	{
		// Fields
		[SerializeField]
		protected PageViewBase pageView;
		[SerializeField]
		protected Transform contentTransform;
		[SerializeField]
		protected RectTransform maskRectTransform;
		[SerializeField]
		public AnimationListOneCol listAnimation;
		[SerializeField]
		protected float duration;
		private Vector2 maskDefaultSize;
		[SerializeField]
		private float autoMovePageInterval;
		private float totalTime;
		protected bool canAutoMovePage;
		protected bool isAnimating;
		protected bool isEnableTouchGuardOnAnimation;
		private bool _initialized;
		protected NormalEventSelectScene questSelectScene;
	
		// Properties
		public bool initialized { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public List<QuestSelectInstance.QuestEventData> recommendEventsData;
			public QuestSelectEventPageBase __4__this;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _InitPageView_b__0(GameObject go, int curIndex);
			internal void _InitPageView_b__1(int index);
		}
	
		[CompilerGenerated]
		private sealed class _WaitForPageViewInited_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventPageBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForPageViewInited_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectEventPageBase();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		protected void InitPageView(List<QuestSelectInstance.QuestEventData> recommendEventsData);
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator WaitForPageViewInited();
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		private void Update();
		[CompilerGenerated]
		private bool _WaitForPageViewInited_b__19_0();
		[CompilerGenerated]
		private void _WaitForPageViewInited_b__19_1();
		[CompilerGenerated]
		private void _StartExitAnimation_b__20_0();
	}
}
