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
using Gluon.Master;
using Gluon.Mission.ListView;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillMainCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private MissionDrillDetailUI detail;
		[SerializeField]
		private MissionDrillStepProgressUI stepProgress;
		[SerializeField]
		private MissionDrillStepButton stepButton;
		[SerializeField]
		private ButtonWithSelectedImage receiveButtonSelectedImage;
		[SerializeField]
		private Badge receiveButtonBadge;
		[SerializeField]
		private Button receiveButton;
		[SerializeField]
		private GameObject nhaamSmallRoot;
		[SerializeField]
		private UnityEngine.UI.Text nhaamTalkText;
		[SerializeField]
		private float animationStartDelay;
		[SerializeField]
		private AnimationUITalkWindow talkWindowAnimation;
		private List<MissionTableViewData> missionTableViewDataList;
		private SkeletonGraphic nhaamSmallSkeletonGraphic;
		private DrillTalkElement currentTalk;
		private Action<DrillTalkElement> onPlayCompleteDirection;
		private const string nhaamSmallAnimationPath = "Prefabs/OutGame/MissionDrill/pf_TeacherNhaamSmall";
		private const string prefsKeyCompleteDirectionShown = "MissionDrillMainCanvas/CompleteDirectionShown_{0}";
		private const string prefsKeyMissionCompleteDirectionShown = "MissionDrillMainCanvas/LastDirectionShownMissionId_{0}";
		private const string prefsKeyStepUnlockDirectionShown = "MissionDrillMainCanvas/StepUnlockDirectionShown_{0}";
	
		// Nested types
		[CompilerGenerated]
		private sealed class _MissionCompleteAnimationCoroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MissionDrillMainCanvas __4__this;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MissionCompleteAnimationCoroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public MissionDrillGroupElement missionDrillGroup;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal bool _StartMissionCompleteDirection_b__1(MissionDrillDataElement e);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<MissionTableViewData, bool> __9__22_0;
			public static Func<MissionDrillDataElement, int> __9__22_2;
			public static Func<MissionTableViewData, bool> __9__30_0;
			public static Func<MissionTableViewData, bool> __9__30_2;
			public static Func<MissionTableViewData, bool> __9__34_0;
			public static Func<MissionDrillGroupElement, int> __9__43_0;
			public static Func<MissionTableViewData, bool> __9__43_2;
			public static Func<MissionDrillGroupElement, IEnumerable<MissionTableViewData>> __9__43_1;
			public static Action<ErrorType, int> __9__45_1;
			public static UnityAction __9__46_0;
			public static Action __9__47_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _StartMissionCompleteDirection_b__22_0(MissionTableViewData e);
			internal int _StartMissionCompleteDirection_b__22_2(MissionDrillDataElement e);
			internal bool _Setup_b__30_0(MissionTableViewData e);
			internal bool _Setup_b__30_2(MissionTableViewData e);
			internal bool _IsMissionCompleteDirectionRequired_b__34_0(MissionTableViewData e);
			internal int _GetReceivableMissionDataList_b__43_0(MissionDrillGroupElement e);
			internal IEnumerable<MissionTableViewData> _GetReceivableMissionDataList_b__43_1(MissionDrillGroupElement e);
			internal bool _GetReceivableMissionDataList_b__43_2(MissionTableViewData data);
			internal void _OnStepButtonClicked_b__45_1(ErrorType errorType, int resultCode);
			internal void _OnDorahaziButtonClicked_b__46_0();
			internal void _OnAllReceiveButtonClicked_b__47_1();
		}
	
		[CompilerGenerated]
		private sealed class _StartMissionCompleteDirection_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MissionDrillMainCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartMissionCompleteDirection_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartStepUnlockDirection_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MissionDrillMainCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartStepUnlockDirection_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartNextStepDirection_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MissionDrillMainCanvas __4__this;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartNextStepDirection_d__24(int __1__state);
	
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
			public int shownMissionId;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _Setup_b__1(MissionTableViewData e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public MissionTableViewData currentChallengingMissionViewData;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal bool _IsMissionCompleteDirectionRequired_b__1(MissionTableViewData e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public DrillTalkElement playTalk;
			public MissionDrillMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _PlayNhaamSmallEnterAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _PlayNhaamSmallEnterAnimation_b__0(TrackEntry _);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _PlayNhaamSmallExitAnimation_b__0(TrackEntry _);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public Action onCheckEnd;
			public UnityAction __9__2;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _DrillTutorialCoroutine_b__0();
			internal void _DrillTutorialCoroutine_b__1();
			internal void _DrillTutorialCoroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _DrillTutorialCoroutine_d__49 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action onCheckEnd;
			private __c__DisplayClass49_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DrillTutorialCoroutine_d__49(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MissionDrillMainCanvas();
	
		// Methods
		protected override void Awake();
		private void Start();
		private void StartAnimation();
		[IteratorStateMachine]
		private IEnumerator MissionCompleteAnimationCoroutine();
		[IteratorStateMachine]
		private IEnumerator StartMissionCompleteDirection();
		[IteratorStateMachine]
		private IEnumerator StartStepUnlockDirection();
		[IteratorStateMachine]
		private IEnumerator StartNextStepDirection();
		private void ShowNhaam();
		private bool IsNhaamCompleteDirectionRequired();
		private void ShownNhaamCompleteDirection();
		public void OnCompleteDirectionFinished();
		public void Initialize(Action<DrillTalkElement> onPlayComplete);
		public void Setup();
		private void UpdateReceiveButton();
		private int GetMissionCompleteDirectionShownMissionId(int groupId);
		private void SetMissionCompleteDirectionShownMissionId(int groupId, int missionId);
		private bool IsMissionCompleteDirectionRequired();
		private bool IsStepUnlockDirectionRequired();
		private void ShownStepUnlockDirection();
		private void PlayCompleteDirection(DrillTalkElement playTalk);
		public void PlayNhaamSmallTalk(bool isPlayEnter);
		private void PlayNhaamSmallTalk(DrillTalkElement playTalk, bool isPlayEnter);
		private void PlayNhaamSmallEnterAnimation(DrillTalkElement playTalk, bool isPlayEnter);
		private void PlayNhaamSmallEnterAnimation(Action onComplete = null);
		public void PlayNhaamSmallExitAnimation(Action onComplete = null);
		private List<MissionTableViewData> GetReceivableMissionDataList();
		public void OnMissionListButtonPressed();
		public void OnStepButtonClicked();
		public void OnDorahaziButtonClicked();
		public void OnAllReceiveButtonClicked();
		private void StartTutorialCheck(Action onCheckEnd);
		[IteratorStateMachine]
		private IEnumerator DrillTutorialCoroutine(Action onCheckEnd);
		private void PlayTalkWindowEnterAnimation();
		private void PlayTalkWindowExitAnimation();
		public void BackButtonPressed();
		private void EnableDebugMenu(bool enable);
		[CompilerGenerated]
		private bool _StartNextStepDirection_b__24_0();
		[CompilerGenerated]
		private bool _StartNextStepDirection_b__24_1();
		[CompilerGenerated]
		private void _OnStepButtonClicked_b__45_0(MissionUnlockDrillMissionGroupResponse res);
		[CompilerGenerated]
		private void _OnAllReceiveButtonClicked_b__47_0();
		[CompilerGenerated]
		private void _OnAllReceiveButtonClicked_b__47_2();
	}
}
