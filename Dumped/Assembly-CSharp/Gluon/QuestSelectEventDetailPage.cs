﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectEventDetailPage : PageBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private Transform contentTransfrom;
		[SerializeField]
		private float duration;
		[SerializeField]
		private QuestSelectEventShortCut questSelectEventShortCut;
		[SerializeField]
		private GameObject eventEndDiscription;
		public AnimationListOneCol listAnimation;
		[SerializeField]
		private TabBase questMultiTab;
		public QuestSupportCanvas.PlayType playType;
		[SerializeField]
		private GameObject questClearPartyButtonObj;
		private int baseQuestGroupId;
		protected NormalEventSelectScene questSelectScene;
		private QuestEventGroupElement groupElement;
		private List<QuestEventMenuElement> eventData;
		private QuestStoryClearReward storyReward;
		private Dictionary<int, float> scrollValueDic;
		private const string showWalkerInfoKey = "ShowWalkerHowToPlay";
		private bool isLoading;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Load_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Load_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<QuestEventMenuElement> __9__25_0;
			public static Func<bool> __9__30_0;
			public static Func<bool> __9__38_0;
			public static Comparison<QuestDataElement> __9__46_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadData_b__25_0(QuestEventMenuElement a, QuestEventMenuElement b);
			internal bool _StartEnterAnimationCo_b__30_0();
			internal bool _QuestWallCheck_b__38_0();
			internal int _OnClearPartyButtonPressed_b__46_0(QuestDataElement a, QuestDataElement b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public PointerEventHandler pointerEventHandler;
			public UnityAction callback;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _CreateList_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CreateList_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
			private int _childCount_5__2;
			private GameObject _prefab_5__3;
			private int _delayIndex_5__4;
			private int _i_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateList_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateCreateListCoroutine_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateCreateListCoroutine_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public QuestSelectEventDetailPage __4__this;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _StartEnterAnimationCo_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _StartEnterAnimationCo_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartEnterAnimationCo_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public EventInfoPopup infoPopup;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _OnPageEnterAnimationEnded_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public bool isNextCheckFlag;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _QuestWallCheck_b__4();
			internal bool _QuestWallCheck_b__1();
			internal bool _QuestWallCheck_b__2();
			internal bool _QuestWallCheck_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_1
		{
			// Fields
			public QuestFlashPopup questFlashPopup;
			public __c__DisplayClass38_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass38_1();
	
			// Methods
			internal void _QuestWallCheck_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_2
		{
			// Fields
			public QuestWallGetRewardPopup popup;
			public __c__DisplayClass38_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass38_2();
	
			// Methods
			internal void _QuestWallCheck_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_3
		{
			// Fields
			public CommonPopup commonPopup;
			public __c__DisplayClass38_0 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass38_3();
	
			// Methods
			internal void _QuestWallCheck_b__7();
		}
	
		[CompilerGenerated]
		private sealed class _QuestWallCheck_d__38 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
			private __c__DisplayClass38_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _QuestWallCheck_d__38(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public bool isNextCheckFlag;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _QuestSimpleEventCheck_b__2();
			internal bool _QuestSimpleEventCheck_b__0();
			internal void _QuestSimpleEventCheck_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _QuestSimpleEventCheck_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
			private __c__DisplayClass39_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _QuestSimpleEventCheck_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public QuestSelectEventDetailPage __4__this;
			public TouchGuardObject touchGuardObj;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _TutorialDragonBattle_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialDragonBattleCoroutine_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
			public TouchGuardObject guardObj;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialDragonBattleCoroutine_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public QuestSelectEventDetailPage __4__this;
			public TouchGuardObject touchGuardObj;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _TutorialInterceptionBattle_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialInterceptionBattleCoroutine_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventDetailPage __4__this;
			public TouchGuardObject guardObj;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialInterceptionBattleCoroutine_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public OtherUserClearPartyListPopup popup;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _OnClearPartyButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private struct _OnClearPartyButtonPressed_d__46 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestSelectEventDetailPage __4__this;
			private __c__DisplayClass46_0 __8__1;
			private int _questGroupId_5__2;
			private List<int> _questIdList_5__3;
			private TaskAwaiter<QuestSearchQuestClearPartyCharaResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public QuestSelectEventDetailPage();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
		private void Start();
		public override void OnPageBecomeActive(object data);
		public void OpenDefaultTab(int baseQuestGroupId);
		public void OnSelectedTab(int num);
		[IteratorStateMachine]
		private IEnumerator Load();
		public override bool IsLoading();
		public override void OnPageBecomeInActive();
		public void LoadData();
		[IteratorStateMachine]
		private IEnumerator CreateList();
		public void UpdateCreateList();
		[IteratorStateMachine]
		private IEnumerator UpdateCreateListCoroutine();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator StartEnterAnimationCo(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public bool ClickTargetQuestCell(int eventQuestId);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public void OnBackButtonTouched();
		public void OnMainQuestButtonTouched();
		public override void OnPageEnterAnimationEnded();
		[IteratorStateMachine]
		private IEnumerator QuestWallCheck();
		[IteratorStateMachine]
		private IEnumerator QuestSimpleEventCheck();
		private void TutorialMultiBattle();
		private void TutorialDragonBattle();
		[IteratorStateMachine]
		private IEnumerator TutorialDragonBattleCoroutine(TouchGuardObject guardObj);
		private void TutorialInterceptionBattle();
		[IteratorStateMachine]
		private IEnumerator TutorialInterceptionBattleCoroutine(TouchGuardObject guardObj);
		private void SetDispQuestClearPartyButton();
		public async void OnClearPartyButtonPressed();
		[CompilerGenerated]
		private void _TutorialMultiBattle_b__40_0();
		[CompilerGenerated]
		private void _TutorialDragonBattleCoroutine_b__42_0();
		[CompilerGenerated]
		private void _TutorialInterceptionBattleCoroutine_b__44_0();
	}
}
