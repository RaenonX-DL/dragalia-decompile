/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSupportPage : PageBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private GameObject mainCamera;
		[SerializeField]
		private QuestSupportCanvas questSupportCanvas;
		[SerializeField]
		private QuestSupportList questSupportList;
		[SerializeField]
		private QuestElementFilter questElementFilter;
		private readonly int supportListUpdateIntervalSec;
		private bool isFromQuestPrepare;
		private Action onPageBecomeActive;
		private Action<bool> onEnterAnimation;
		private Action onExitAnimation;
		private Action onPageEnterAnimationEnded;
		private Action onBackButtonPressed;
		private int questId;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public bool isSupportEnable;
			public QuestSupportPage __4__this;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _OnPageBecomeActive_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__20_0;
			public static Action __9__25_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _TutorialStep_1_1_SupportSelect_b__20_0();
			internal void _OnError_b__25_0();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialStep_1_1_SupportSelect_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialStep_1_1_SupportSelect_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitSupportListOpenAnimationCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSupportPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitSupportListOpenAnimationCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSupportPage();
	
		// Methods
		protected override void Awake();
		public void Initialize(Action onPageBecomeActive, Action<bool> onEnterAnimation, Action onExitAnimation, Action onPageEnterAnimationEnded, Action onBackButtonPressed);
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override void OnPageEnterAnimationEnded();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		private void StartTutorial();
		[IteratorStateMachine]
		private IEnumerator TutorialStep_1_1_SupportSelect();
		private void LoadAndOpenSupportUserList();
		private void GetSupportList();
		private void GetDataOnSuccess(QuestGetSupportUserListResponse res);
		[IteratorStateMachine]
		private IEnumerator WaitSupportListOpenAnimationCoroutine();
		public void OnError(ErrorType errorType, int resultCode);
		public void BackButtonPressed();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		private void CellButtonPressed();
		private void GotoPrepareScene();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _StartTutorial_b__19_0();
		[CompilerGenerated]
		private bool _WaitSupportListOpenAnimationCoroutine_b__24_0();
		[CompilerGenerated]
		private bool _WaitSupportListOpenAnimationCoroutine_b__24_1();
	}
}
