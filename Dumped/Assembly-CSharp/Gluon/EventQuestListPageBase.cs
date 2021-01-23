/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestListPageBase : EventQuestPageBase, ICustomMessage
	{
		// Fields
		public EventListCtrl eventListCtrl;
		[SerializeField]
		private float statusDelayTime;
		[SerializeField]
		private float statusExitDelayTime;
		[SerializeField]
		private GameObject buttonsParent;
		[Header]
		[SerializeField]
		private Transform subPageContent;
		[SerializeField]
		private GameObject subPage;
		[SerializeField]
		private GameObject mainPage;
		[SerializeField]
		private UIAnimationPublisher subPageSwitchPublisher;
		[SerializeField]
		private UIAnimationPublisher mainPageSwitchPublisher;
		[SerializeField]
		private AnimationListOneCol subPageListAnimation;
		private const float waitSubPageChangeTime = 0.3f;
		private bool isInSubPage;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ReturnToMainPageCoroutine_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventQuestListPageBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReturnToMainPageCoroutine_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GoSubPageCoroutine_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventQuestListPageBase __4__this;
			public List<QuestEventMenuElement> cellData;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoSubPageCoroutine_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForHideButtons_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public EventQuestListPageBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForHideButtons_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public bool hideStatusInfo;
			public EventQuestListPageBase __4__this;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _StartExitAnimation_b__0();
		}
	
		// Constructors
		public EventQuestListPageBase();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override void OnPageEnterAnimationEnded();
		public void ReturnToMainPage();
		[IteratorStateMachine]
		private IEnumerator ReturnToMainPageCoroutine();
		public void GoSubPage(List<QuestEventMenuElement> cellData);
		[IteratorStateMachine]
		private IEnumerator GoSubPageCoroutine(List<QuestEventMenuElement> cellData);
		public void StartSubPageEnterAnimation(float delayTime = 0f);
		public void StartSubPageExitAnimation(float delayTime = 0f);
		private void SetBackKey(UnityAction action);
		public void OnBackButtonTouched();
		[IteratorStateMachine]
		private IEnumerator WaitForHideButtons(float delay);
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _ReturnToMainPageCoroutine_b__16_0();
		[CompilerGenerated]
		private void _GoSubPageCoroutine_b__18_0();
	}
}
