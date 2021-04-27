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
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CombatQuestMapPage : EventQuestPageBase
	{
		// Fields
		[Header]
		[SerializeField]
		private Image bgImage;
		[SerializeField]
		private Image fadeImage;
		[SerializeField]
		private Image bgPlane;
		[SerializeField]
		private AnimationUIBg bgAnimation;
		[SerializeField]
		private UIAnimationPublisher mainPublisher;
		[SerializeField]
		private AnimationUIBg bgPlaneAnimation;
		[Header]
		[SerializeField]
		private Transform buttonParentNode;
		[SerializeField]
		private CombatQuestMapObjectButton objectButton;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		[Header]
		[SerializeField]
		private Vector2 namPos;
		[SerializeField]
		private Vector2 namScale;
		[SerializeField]
		private GameObject nhaamParent;
		private FlashPlayer twinkleFlash;
		private FlashPlayer moveFlash;
		[Header]
		[SerializeField]
		private Transform compleatFlashParent;
		private FlashPlayer compleatFlash;
		private List<CombatLandmarkInfo> landmarkList;
		private CanvasGroup bgCanvasGroup;
		private static float locSizeScale;
		private bool isGetLocationReward;
		private int getLocationRewardId;
		private int nhaamIndex;
		private const int storyLocationId = 1;
	
		// Nested types
		public class CombatLandmarkInfo
		{
			// Fields
			public CombatEventLocationElement locationElement;
			public CombatQuestMapObjectButton landmmark;
	
			// Constructors
			public CombatLandmarkInfo(CombatEventLocationElement locationElement, CombatQuestMapObjectButton landmmark);
		}
	
		[CompilerGenerated]
		private sealed class _EnterAnimationCoroutine_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CombatQuestMapPage __4__this;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnterAnimationCoroutine_d__37(int __1__state);
	
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
			public bool isCompleatAnimationFinish;
			public CombatEventLocationElement location;
			public CombatQuestMapPage __4__this;
			public bool isClosePopup;
			public CombatEventLocationElement nextLocation;
			public CombatQuestMapObjectButton landmark;
			public int nextLocationId;
			public TouchGuardObject touchGuard2;
			public Action __9__6;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _StartLocationClearEvent_b__0();
			internal bool _StartLocationClearEvent_b__1();
			internal void _StartLocationClearEvent_b__2();
			internal void _StartLocationClearEvent_b__6();
			internal bool _StartLocationClearEvent_b__3(CombatLandmarkInfo x);
			internal bool _StartLocationClearEvent_b__4();
			internal void _StartLocationClearEvent_b__5();
		}
	
		[CompilerGenerated]
		private sealed class _StartLocationClearEvent_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CombatQuestMapPage __4__this;
			public int locationId;
			private __c__DisplayClass41_0 __8__1;
			private TouchGuardObject _touchGuard1_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartLocationClearEvent_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _RequestCombatEventReceiveEventLocationReward_b__0(CombatEventReceiveEventLocationRewardResponse response);
		}
	
		// Constructors
		public CombatQuestMapPage();
		static CombatQuestMapPage();
	
		// Methods
		protected override void Awake();
		private void LoadObjects();
		private bool IsEventEnded();
		private static List<CombatEventLocationElement> GetLocations(int eventId);
		public static QuestUtil.QuestState GetLocationState(bool isEventEnded, int locationId);
		private void OnMiniCharaTouched(int masterIndex);
		private void TakeScreenshot();
		public void OnBackFromQuestList();
		public override void OnPageBecomeActive(object data);
		private void Start();
		private void LateUpdate();
		public void OnBackButtonTouched();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator EnterAnimationCoroutine();
		private void CheckLocationReward();
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		[IteratorStateMachine]
		private IEnumerator StartLocationClearEvent(int locationId);
		public static void RequestCombatEventReceiveEventLocationReward(int locationId, Action onCompleted, Action<ErrorType, int> onError = null);
		private void GoQuestDetailListPage(CombatEventLocationElement loc);
		public void NhaamMove(int pointerIndex);
		public void InitializeNhaam(int sortOrder);
		public void PlayNhaamAnimation();
		public void SetSortingOrder(int sortOrder);
		private void PlayCompleatFlash(Action onAnimationEnded = null);
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _OnBackFromQuestList_b__31_0();
	}
}
