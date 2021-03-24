/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Http;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallResultTopPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text uiQuestTitleEventText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text uiExpText;
		public UnityEngine.UI.Text uiCharaExpText;
		[Header]
		[SerializeField]
		public QRExpBar playerExpBar;
		public QRExpBar[] charaExpBarList;
		public CommonIcon[] charaIconList;
		public Transform[] charaListSortDecoTrans;
		[Header]
		[SerializeField]
		public GameObject[] uiCharaFaceImage;
		[Header]
		[SerializeField]
		public Image uiCheckMarkImage;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text uiManaText;
		public UnityEngine.UI.Text uiRupiText;
		[Header]
		[SerializeField]
		public Button uiFullCanvasButton;
		[Header]
		[SerializeField]
		public GameObject treasureTitleLine;
		public GameObject treasureListParent;
		[Header]
		[SerializeField]
		public Transform[] titlePartTrans;
		public Transform[] playerExpPartTrans;
		public Transform[] characterPartTrans;
		public Transform[] treasurePartTrans;
		public Transform[] buttonPartTrans;
		[Header]
		[SerializeField]
		public ScrollRect treasureScrollRect;
		[SerializeField]
		public CanvasGroup descriptionNodeCanvasGroup;
		[SerializeField]
		public UnityEngine.UI.Text descriptionText;
		[Header]
		[SerializeField]
		private float animationWaitSpeedModulus;
		[SerializeField]
		private float animationSlideInSpeedModulus;
		[SerializeField]
		private float animationDelay;
		[SerializeField]
		private float iconAnimationDelayTime;
		[SerializeField]
		private float viewRowScrollDuration;
		[SerializeField]
		public float descriptionNodeCanvasGroupFadeInTime;
		[SerializeField]
		public float descriptionNodeCanvasGroupFadeOutTime;
		[SerializeField]
		private Vector3 iconScale;
		[SerializeField]
		private float animationWaitTime;
		[SerializeField]
		private float popupDelayTime;
		[SerializeField]
		private float dropItemAppearTime;
		[SerializeField]
		private GameObject clearPartyObj;
		[SerializeField]
		private GameObject tresureNothingLine;
		[Header]
		[SerializeField]
		public PointerEventHandler retryButton;
		public PointerEventHandler nextButton;
		public UIAnimationPublisher buttonAnimationPublisher;
		[Header]
		[SerializeField]
		public AnimationData[] titleAnimationData;
		public AnimationData[] playerAnimationData;
		public AnimationData[] characterAnimationData;
		public AnimationData[] tresureAnimationData;
		public AnimationData[] buttonAnimationData;
		public bool bPlayerExpBarFinished;
		[CompilerGenerated]
		private QuestResultScene _sceneObj_k__BackingField;
		private float preservedDotweenTimeScale;
		private CommonIconListSortDeco[] charaListSortDeco;
		private int iconListSectionCount;
		private List<QRTreasureIcon> iconAnimationList;
		private Coroutine waitForTimerCoroutine;
		private bool clearPartyFlag;
		private bool bSkipButtonClicked;
		private bool bWaitTimerEnd;
		private bool isDialogClosed;
		private bool rareStopFlag;
		private bool isOnTopPageDone;
		private bool isOnPressNext;
		private bool isTopPageOut;
		private bool treasureEnd;
		private ButtonSound buttonSound;
		private float slideOutDistance;
		private Vector3[] titleSlideVector;
		private float tresureBaseHegiht;
		private int[] maxLevel;
		private Vector3[] defaultTitlePos;
		private Vector3[] defaultMissionPos;
		private Vector3[] defaultExpPos;
		private Vector3[] defaultCharaPos;
		private Vector3[] defaultTreasurePos;
		private Vector3[] defaultbuttonPos;
		private Sequence bottomButtonAnimSeq;
		private FlRoot headerFlash;
		private FlRoot nextItemFlash;
		private FlRoot getItemFlash;
		private FlRoot effectFlash;
		private const float outAnimRatio = 0.6f;
		private const float headerCharacterOutTime = 0.18f;
		private const float waitTime = 0.033333335f;
		private const float time = 0.5f;
		private const string seRising = "SE_OUT_COMMON_0010";
		private const string seRupee = "SE_OUT_COMMON_0025";
		private const string seCharaSlideIn = "SE_OUT_COMMON_0033";
		private const string seCharaSlideOut = "SE_OUT_COMMON_0034";
		private const float difficultTextHeight = 30f;
		private const float titleTextHeight = 50f;
		private const int nextButtonIndex = 1;
		private const int retryButtonIndex = 0;
		private readonly Vector3 buttonSlideVector;
	
		// Properties
		public QuestResultScene sceneObj { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public struct FlPlaneSortingInfo
		{
			// Fields
			public string targetNamePhrase;
			public int sortingOffset;
	
			// Constructors
			public FlPlaneSortingInfo(string name, int offset);
		}
	
		[Serializable]
		public struct AnimationData
		{
			// Fields
			public float duration;
			public Ease easing;
			public float delay;
			public float returnX;
			public float returnFrame;
			public Ease returnEasing;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public FlPlane plane;
	
			// Constructors
			public __c__DisplayClass94_0();
	
			// Methods
			internal void _InitByData_b__0(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public AudioPlayback apb;
			public QuestWallResultTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass95_0();
	
			// Methods
			internal void _DoQuestResultAnimation_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_1
		{
			// Fields
			public AudioPlayback apb;
			public QuestWallResultTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass95_1();
	
			// Methods
			internal void _DoQuestResultAnimation_b__9();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_2
		{
			// Fields
			public QuestResultModel.FirstClearModel.FirstClearItemInfo firstClearChara;
			public QuestWallResultTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass95_2();
	
			// Methods
			internal void _DoQuestResultAnimation_b__16();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_3
		{
			// Fields
			public QuestWallContinuityCheckPopup popup;
			public QuestWallResultTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass95_3();
	
			// Methods
			internal void _DoQuestResultAnimation_b__22();
			internal void _DoQuestResultAnimation_b__23();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<float> __9__95_0;
			public static Action __9__142_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _DoQuestResultAnimation_b__95_0(float time);
			internal void _GoToIngame_b__142_0();
		}
	
		[CompilerGenerated]
		private sealed class _DoQuestResultAnimation_d__95 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestWallResultTopPage __4__this;
			private __c__DisplayClass95_2 __8__1;
			private __c__DisplayClass95_3 __8__2;
			private Sequence _upSeq_5__2;
			private Sequence _charaExpSeq_5__3;
			private QuestWallModel _model_5__4;
			private Sequence _treasureSeq_5__5;
			private DragonDataDictionary _dragonDataDic_5__6;
			private WeaponBodyDictionary _weaponDataDic_5__7;
			private AbilityCrestDictionary _amuletDataDic_5__8;
			private QuestWallModel _firstClearModel_5__9;
			private int _columnCount_5__10;
			private int _dispRowCount_5__11;
			private int _dispMaxCount_5__12;
			private bool _isScrollStart_5__13;
			private bool _isNeedToScroll_5__14;
			private int _treasureIconCount_5__15;
			private int _materialIconCount_5__16;
			private Vector3 _baseAnchoredPosition_5__17;
			private float _waitDuration_5__18;
			private int _treasureRow_5__19;
			private int _scrollRow_5__20;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoQuestResultAnimation_d__95(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_0
		{
			// Fields
			public QuestWallResultTopPage __4__this;
			public Transform buttonTrans;
			public Vector3 defaultButtonPos;
	
			// Constructors
			public __c__DisplayClass100_0();
	
			// Methods
			internal void _ButtonSlideOut_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_0
		{
			// Fields
			public Action onComplete;
			public QuestWallResultTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass107_0();
	
			// Methods
			internal void _MoveOut_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForTimerCoroutine_d__121 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestWallResultTopPage __4__this;
			public float waitTime;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForTimerCoroutine_d__121(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _IconStartAnimation_d__124 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public List<QRTreasureIcon> list;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _IconStartAnimation_d__124(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnExpPlayerBarFinishCorutine_d__126 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AudioPlayback apb;
			public QuestWallResultTopPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnExpPlayerBarFinishCorutine_d__126(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass128_0
		{
			// Fields
			public QuestWallResultTopPage __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass128_0();
	
			// Methods
			internal void _CreateDuplicateConfirmPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass129_0
		{
			// Fields
			public QuestWallResultTopPage __4__this;
			public Action action;
	
			// Constructors
			public __c__DisplayClass129_0();
	
			// Methods
			internal void _DoPageOutAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass140_0
		{
			// Fields
			public QuestWallContinuityCheckPopup popup;
			public QuestWallResultTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass140_0();
	
			// Methods
			internal void _OnNextBattleButton_b__0();
			internal void _OnNextBattleButton_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass145_0
		{
			// Fields
			public UnityAction onSucceed;
	
			// Constructors
			public __c__DisplayClass145_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass145_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass145_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass145_1();
	
			// Methods
			internal void _CheckPartyPower_b__0();
			internal void _CheckPartyPower_b__1();
		}
	
		// Constructors
		public QuestWallResultTopPage();
	
		// Methods
		private void Start();
		public void InitByData();
		[IteratorStateMachine]
		private IEnumerator DoQuestResultAnimation();
		private void OnDestroy();
		public void OnPressClearParty();
		public void SlideNextAndRetryButtons(bool isOut, bool withNextButton, bool withRetryButton);
		private Sequence ButtonSlideIn(Transform buttonTrans, AnimationData buttonAnimationData, Vector3 defaultButtonPos);
		private void ButtonSlideOut(Transform buttonTrans, Vector3 defaultButtonPos, float delay);
		private void InitButton(Transform buttonTrans, Vector3 defaultButtonPos);
		public void OnPressSkip();
		public void OnPressNext();
		private void RequestSaveClearParty();
		private void ApiOnSuccess(WallSetWallClearPartyResponse res);
		private void ApiOnError(ErrorType errorType, int resultCode);
		public void MoveOut(Transform trans, float distance, Action onComplete);
		private void OnQuestResultDone();
		public void CreateFirstClearCharaDragonPopup(QuestResultModel.FirstClearModel.FirstClearItemInfo info, Action onOKOrClose = null, Action onCancel = null);
		public void CreateFirstClearItemPopup(List<QuestResultModel.FirstClearModel.FirstClearItemInfo> info, Action onOKOrClose = null, Action onCancel = null);
		public void CreateBonusItemPopup(Action onOKOrClose = null, Action onCancel = null);
		private void CreateDropItem();
		private void SetBackKey(UnityAction action);
		private void SetButtonSoundAction(PointerEventHandler eventHandler);
		private void AddTreasureIcon(QuestResultModel.TopPageModel.RewardItemInfo item, float animationDelay, float animationDelayStep, Transform parentTransform);
		private void AddTreasureIconOneByOne(QuestResultModel.TopPageModel.RewardItemInfo item, float animationDelay, float animationDelayStep, Transform parentTransform);
		public bool SkipChecker();
		public void ScrollToItem(Transform target);
		public void ScrollToItem(Transform baseTrans, Transform targetTrans, float waitDuration, float scrollDuration);
		public void ScrollToItem(Vector3 baseAnchoredPosition, Vector3 targetAnchoredPosition, float waitDuration, float scrollDuration);
		[IteratorStateMachine]
		private IEnumerator WaitForTimerCoroutine(float waitTime);
		private void StartWaitTimerForSkip(float waitTime);
		private void StopWaitTimerForSkip();
		[IteratorStateMachine]
		private IEnumerator IconStartAnimation(List<QRTreasureIcon> list);
		private void OnExpPlayerBarFinish(AudioPlayback apb);
		[IteratorStateMachine]
		private IEnumerator OnExpPlayerBarFinishCorutine(AudioPlayback apb);
		private void NextRarePopupFlagOff();
		private void CreateDuplicateConfirmPopup(string title, string text);
		private Sequence DoPageOutAnimation(bool includingTitleAndButton, bool isMovingToEventPage, Action action = null);
		private void SetMotionPlayIn();
		private void SetMotionPlayOut(Action action);
		public void SetMotionPlaySkip();
		public void NextButtonSlideIn();
		private void Visible(Transform trans, float alpha);
		private FlashPlayer SetupFlash(string path, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true, Canvas targetCanvas = null, int canvasSortingOrder = 0, bool isAddPlaneCountToCanvasOrder = false);
		private FlashPlayer SetupFlashEachLayer(string path, FlPlaneSortingInfo[] flPlaneSortingInfos, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true);
		public void CameraDepth(int depth);
		private int Digit(int num);
		private int MaxValue(int digit);
		public void OnNextBattleButton();
		public void OnNextBattleConfirmPopupOk();
		private void GoToIngame();
		public void SetNextButtonCallback(UnityAction callback);
		public void OnBeforeLeaving();
		private void CheckPartyPower(UnityAction onSucceed);
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_5();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_6();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_8();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_10();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_11();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_12();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_13();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_1(bool enable);
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_2();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_14();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_15();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_19();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_17();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_18();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_20();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_21();
		[CompilerGenerated]
		private void _DoQuestResultAnimation_b__95_3();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_4();
		[CompilerGenerated]
		private bool _DoQuestResultAnimation_b__95_24();
		[CompilerGenerated]
		private void _OnQuestResultDone_b__108_0();
		[CompilerGenerated]
		private void _CreateDropItem_b__112_1();
		[CompilerGenerated]
		private void _CreateDropItem_b__112_0();
		[CompilerGenerated]
		private void _SetMotionPlayIn_b__130_0();
		[CompilerGenerated]
		private void _SetMotionPlayIn_b__130_1();
	}
}
