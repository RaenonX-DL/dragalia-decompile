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
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultTopPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text uiQuestChapterText;
		public UnityEngine.UI.Text uiQuestTitleText;
		public UnityEngine.UI.Text uiQuestTitleEventText;
		public Image uiQuestLevelImage;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text[] uiMissionText;
		public Image[] uiMissionOnImage;
		public Image[] uiMissionOffImage;
		public Transform[] uiMissionBase;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text uiExpText;
		public UnityEngine.UI.Text uiCharaExpText;
		[Header]
		[SerializeField]
		public QRExpBar playerExpBar;
		public UnityEngine.UI.Text playerNewLevel;
		public UnityEngine.UI.Text playerNewLevelValue;
		public QRExpBar[] charaExpBarList;
		public CommonIcon[] charaIconList;
		public Transform[] charaListSortDecoTrans;
		private CommonIconListSortDeco[] charaListSortDeco;
		[Header]
		[SerializeField]
		public GameObject[] uiCharaFaceImage;
		[Header]
		[SerializeField]
		public Button uiCheckMarkButton;
		public Image uiCheckMarkImage;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text uiManaText;
		public UnityEngine.UI.Text uiManaRateText;
		public UnityEngine.UI.Text uiRupiText;
		public UnityEngine.UI.Text uiRupiRateText;
		public UnityEngine.UI.Text uiDropRateText;
		[Header]
		[SerializeField]
		public Button uiFullCanvasButton;
		[Header]
		[SerializeField]
		public GameObject treasureTitleLine;
		public GameObject treasureListParent;
		[Header]
		[SerializeField]
		public GameObject rebornSection;
		public GameObject rebornListParent;
		public GameObject rebornHeartGO;
		[Header]
		[SerializeField]
		public Button tapToNextButton;
		public Transform[] titlePartTrans;
		public Transform[] missionPartTrans;
		public Transform[] playerExpPartTrans;
		public Transform[] characterPartTrans;
		public Transform[] treasurePartTrans;
		public Transform[] buttonPartTrans;
		public Transform battleRoyalTopTrans;
		public Transform battleRoyalCenterTrans;
		[SerializeField]
		private Transform[] bestTotalDamageTransList;
		[Header]
		[SerializeField]
		public ScrollRect treasureScrollRect;
		[Header]
		[SerializeField]
		public GameObject newClearTimeIcon;
		public UnityEngine.UI.Text clearTimeText;
		private const int clearTimeMax = 5999;
		[Header]
		[SerializeField]
		private Transform multiRebattlePageNode;
		private const string multiRebattlePagePath = "Prefabs/OutGame/QuestResult/QRMultiRebattlePage";
		private QuestResultMultiRebattlePage multiRebattlePage;
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
		private float preservedDotweenTimeScale;
		[SerializeField]
		private Vector3 iconScale;
		[SerializeField]
		private float animationWaitTime;
		[SerializeField]
		private float popupDelayTime;
		[SerializeField]
		private float dropItemAppearTime;
		[SerializeField]
		private float battleRoyalFlashWaitTime;
		[SerializeField]
		private Sprite[] difficultyAtlasImage;
		[SerializeField]
		private GameObject clearPartyObj;
		[SerializeField]
		private QuestResultLvUpEffect levupEffect;
		[Header]
		[SerializeField]
		private Transform rankingParent;
		[Header]
		[SerializeField]
		private QuestResultRankingCell rankingCell;
		private QuestResultRankingPage questResultRankingPage;
		[SerializeField]
		private GameObject tresureNothingLine;
		[CompilerGenerated]
		private QuestResultScene _sceneObj_k__BackingField;
		public bool bPlayerExpBarFinished;
		private int iconListSectionCount;
		private int useCharaCount;
		private List<QRTreasureIcon> iconAnimationList;
		private Coroutine waitForTimerCoroutine;
		private bool clearPartyFlag;
		private bool bSkipButtonClicked;
		private bool bWaitTimerEnd;
		private bool isDialogClosed;
		private bool rareStopFlag;
		private bool isEventFlag;
		private bool raidFriendshipEffectFlag;
		private bool randomEventMedalEffectFlag;
		private bool buildEventEffectFlag;
		private bool earnEventEffectFlag;
		private bool isOnTopPageDone;
		private bool isOnPressNext;
		private bool isTopPageOut;
		private bool treasureEnd;
		private const string seRising = "SE_OUT_COMMON_0010";
		private const string seMissionGet = "SE_OUT_COMMON_0021";
		private const string sePlayerRankUp = "SE_OUT_COMMON_0022";
		private const string seCharaLevelUp = "SE_OUT_COMMON_0024";
		private const string seRupee = "SE_OUT_COMMON_0025";
		private const string seItemSwitch = "SE_OUT_COMMON_0026";
		private const string seCharaSlideIn = "SE_OUT_COMMON_0033";
		private const string seCharaSlideOut = "SE_OUT_COMMON_0034";
		private const string seClear = "SE_OUT_COMMON_0054";
		private const float time = 0.5f;
		private const int initialValue = 99999999;
		private DateTime rebattleStartTime;
		private GameObject eventCharaPrefab;
		private GameObject randomEventResultPrefab;
		private GameObject buildEventResultPrefab;
		public const float waitTime = 0.033333335f;
		private const float HeaderAnimationOutTime = 0.6333333f;
		private FlashPlayer flashGaugeBurst;
		private FlashPlayer[] flashCharaExplvup;
		private FlashPlayer[] flashMission;
		private FlashPlayer headerChara;
		private FlRoot battleRoyalRankFlash;
		private ButtonSound buttonSound;
		private float slideOutDistance;
		private Vector3[] titleSlideVector;
		public float missionFlashDelay;
		private QuestSkipTicketConfirmPopup questSkipTicketConfirmPopup;
		private QuestResultRetryPopup questResultRetryPopup;
		private QuestResultRetryConfirmPopup questResultRetryConfirmPopup;
		private EventQuestConditionPopup conditionPopup;
		private QuestSkipTicketClearFlashPopup clearFlashPopup;
		public PointerEventHandler retryButton;
		public PointerEventHandler nextButton;
		private float tresureBaseHegiht;
		private const float outAnimRatio = 1f;
		private float headerCharacterOutTime;
		[Header]
		[SerializeField]
		public AnimationData[] titleAnimationData;
		public AnimationData[] missionAnimationData;
		public AnimationData[] rebornAnimationData;
		public AnimationData[] playerAnimationData;
		public AnimationData[] characterAnimationData;
		public AnimationData[] tresureAnimationData;
		public AnimationData[] buttonAnimationData;
		public AnimationData battleRoyalAnimationData;
		public AnimationData battleRoyalCenterAnimationData;
		[SerializeField]
		private AnimationData bestTotalDamageTopAnimationData;
		public UIAnimationPublisher buttonAnimationPublisher;
		private Vector2 defaultheaderCharaPosition;
		private UnityEvent backKeyEvent;
		private int[] maxLevel;
		private Vector3[] defaultTitlePos;
		private Vector3[] defaultMissionPos;
		private Vector3[] defaultExpPos;
		private Vector3[] defaultCharaPos;
		private Vector3[] defaultTreasurePos;
		private Vector3[] defaultbuttonPos;
		private Vector3 defaultRebornPos;
		private Vector3 defaultBattleRoyalTopPos;
		private Vector3 defaultBattleRoyalCenterPos;
		private Vector3[] defaultBestTotalDamagePosList;
		private QREventCharaResult eventChara;
		private QRRandomEventReward randomEventResult;
		private QRBuildEventResult buildEventResult;
		private QuestResultEarnEventBonus questResultEarnEventBonus;
		private QuestResultRanking ranking;
		private QuestResultRankingEffect rankingEffect;
		private const float difficultTextHeight = 30f;
		private const float titleTextHeight = 50f;
		private readonly Vector3 buttonSlideVector;
		private const int nextButtonIndex = 1;
		private const int retryButtonIndex = 0;
		[CompilerGenerated]
		private bool _canRetry_k__BackingField;
		private Sequence bottomButtonAnimSeq;
	
		// Properties
		public QuestResultScene sceneObj { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isTopPageSkip { get; set; }
		public bool canRetry { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public struct FlPlaneSortingInfo
		{
			// Fields
			public string targetNamePhrase;
			public int sortingOffset;
	
			// Constructors
			public FlPlaneSortingInfo(string name, int offset);
		}
	
		private enum EnumStete
		{
			InitWait = 0,
			Prepare = 1,
			GoQuest = 2,
			Exit = 3
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
		private sealed class __c__DisplayClass177_0
		{
			// Fields
			public QuestResultTopPage __4__this;
			public Transform buttonTrans;
			public Vector3 defaultButtonPos;
	
			// Constructors
			public __c__DisplayClass177_0();
	
			// Methods
			internal void _ButtonSlideOut_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass188_0
		{
			// Fields
			public Action onComplete;
			public QuestResultTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass188_0();
	
			// Methods
			internal void _MoveOut_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass197_0
		{
			// Fields
			public QREventRewardPopup popup;
			public Action onCloseCallback;
	
			// Constructors
			public __c__DisplayClass197_0();
	
			// Methods
			internal void _CreateTimeAttackRankingTierRewardPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CreateTimeAttackRankingTierRewardPopup_d__197 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action onCloseCallback;
			public QuestResultTopPage __4__this;
			private __c__DisplayClass197_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateTimeAttackRankingTierRewardPopup_d__197(int __1__state);
	
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
			public static Func<KeyValuePair<float, List<QuestResultModel.TopPageModel.RewardItemInfo>>, float> __9__206_0;
			public static TweenCallback __9__218_14;
			public static Action<float> __9__218_27;
			public static Func<RankingTierRewardElement, bool> __9__218_6;
			public static TweenCallback __9__228_0;
			public static Func<bool> __9__261_0;
			public static Func<bool> __9__261_1;
			public static Func<bool> __9__261_2;
			public static Action __9__261_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal float _SetUpTreasurePanel_b__206_0(KeyValuePair<float, List<QuestResultModel.TopPageModel.RewardItemInfo>> value);
			internal void _DoQuestResultAnimation_b__218_14();
			internal void _DoQuestResultAnimation_b__218_27(float time);
			internal bool _DoQuestResultAnimation_b__218_6(RankingTierRewardElement tierReward);
			internal void _DoPartEnterAnimationMission_b__228_0();
			internal bool _CheckDisconnectType_b__261_0();
			internal bool _CheckDisconnectType_b__261_1();
			internal bool _CheckDisconnectType_b__261_2();
			internal void _CheckDisconnectType_b__261_3();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForTimerCoroutine_d__214 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultTopPage __4__this;
			public float waitTime;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForTimerCoroutine_d__214(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_0
		{
			// Fields
			public QuestResultTopPage __4__this;
			public int finishedBarCount;
			public Action __9__22;
			public Action<int> __9__23;
			public Action<int> __9__24;
			public Action<int> __9__25;
			public Action<int> __9__26;
			public Func<bool> __9__29;
			public Func<bool> __9__30;
			public Func<bool> __9__31;
			public Action __9__39;
			public Action __9__37;
			public Func<bool> __9__38;
			public Action __9__40;
			public Func<bool> __9__41;
			public Action __9__46;
	
			// Constructors
			public __c__DisplayClass218_0();
	
			// Methods
			internal void _DoQuestResultAnimation_b__12();
			internal bool _DoQuestResultAnimation_b__10();
			internal bool _DoQuestResultAnimation_b__11();
			internal void _DoQuestResultAnimation_b__17();
			internal void _DoQuestResultAnimation_b__19();
			internal void _DoQuestResultAnimation_b__21();
			internal void _DoQuestResultAnimation_b__22();
			internal void _DoQuestResultAnimation_b__23(int level);
			internal void _DoQuestResultAnimation_b__24(int level);
			internal void _DoQuestResultAnimation_b__25(int level);
			internal void _DoQuestResultAnimation_b__26(int level);
			internal bool _DoQuestResultAnimation_b__28();
			internal bool _DoQuestResultAnimation_b__29();
			internal bool _DoQuestResultAnimation_b__30();
			internal bool _DoQuestResultAnimation_b__31();
			internal bool _DoQuestResultAnimation_b__32();
			internal void _DoQuestResultAnimation_b__0(bool enable);
			internal bool _DoQuestResultAnimation_b__1();
			internal void _DoQuestResultAnimation_b__34();
			internal bool _DoQuestResultAnimation_b__35();
			internal void _DoQuestResultAnimation_b__39();
			internal void _DoQuestResultAnimation_b__37();
			internal bool _DoQuestResultAnimation_b__38();
			internal void _DoQuestResultAnimation_b__40();
			internal bool _DoQuestResultAnimation_b__41();
			internal void _DoQuestResultAnimation_b__2();
			internal bool _DoQuestResultAnimation_b__3();
			internal void _DoQuestResultAnimation_b__4();
			internal bool _DoQuestResultAnimation_b__5();
			internal void _DoQuestResultAnimation_b__42();
			internal bool _DoQuestResultAnimation_b__43();
			internal void _DoQuestResultAnimation_b__44(TimeAttackRankingReceiveTierRewardResponse res);
			internal void _DoQuestResultAnimation_b__46();
			internal bool _DoQuestResultAnimation_b__45();
			internal void _DoQuestResultAnimation_b__7();
			internal bool _DoQuestResultAnimation_b__8();
			internal void _DoQuestResultAnimation_b__48();
			internal bool _DoQuestResultAnimation_b__49();
			internal void _DoQuestResultAnimation_b__9();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_1
		{
			// Fields
			public int index;
			public __c__DisplayClass218_0 CS___8__locals1;
			public Action __9__15;
	
			// Constructors
			public __c__DisplayClass218_1();
	
			// Methods
			internal void _DoQuestResultAnimation_b__13();
			internal void _DoQuestResultAnimation_b__15();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_2
		{
			// Fields
			public bool isRankingStartAnimationEnd;
	
			// Constructors
			public __c__DisplayClass218_2();
	
			// Methods
			internal void _DoQuestResultAnimation_b__16();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_3
		{
			// Fields
			public AudioPlayback apb;
			public __c__DisplayClass218_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass218_3();
	
			// Methods
			internal void _DoQuestResultAnimation_b__18();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_4
		{
			// Fields
			public AudioPlayback apb;
			public __c__DisplayClass218_0 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass218_4();
	
			// Methods
			internal void _DoQuestResultAnimation_b__20();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_5
		{
			// Fields
			public QuestResultRaidBoostPopup popup;
	
			// Constructors
			public __c__DisplayClass218_5();
	
			// Methods
			internal bool _DoQuestResultAnimation_b__33();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_6
		{
			// Fields
			public QuestResultModel.FirstClearModel.FirstClearItemInfo firstClearChara;
			public __c__DisplayClass218_0 CS___8__locals4;
	
			// Constructors
			public __c__DisplayClass218_6();
	
			// Methods
			internal void _DoQuestResultAnimation_b__36();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_7
		{
			// Fields
			public WeeklyBonusSelectPopup popup;
	
			// Constructors
			public __c__DisplayClass218_7();
	
			// Methods
			internal bool _DoQuestResultAnimation_b__47();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass218_8
		{
			// Fields
			public QuestResultShowExtraBattlePopup showExtraBattlePopup;
	
			// Constructors
			public __c__DisplayClass218_8();
	
			// Methods
			internal bool _DoQuestResultAnimation_b__50();
		}
	
		[CompilerGenerated]
		private sealed class _DoQuestResultAnimation_d__218 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultTopPage __4__this;
			private __c__DisplayClass218_0 __8__1;
			private __c__DisplayClass218_2 __8__2;
			private __c__DisplayClass218_5 __8__3;
			private __c__DisplayClass218_6 __8__4;
			private bool _isPlayExpBarAnimation_5__2;
			private AudioPlayback _charaApb_5__3;
			private QuestResultModel.TopPageModel _model_5__4;
			private Sequence _treasureSeq_5__5;
			private DragonDataDictionary _dragonDataDic_5__6;
			private WeaponBodyDictionary _weaponDataDic_5__7;
			private AbilityCrestDictionary _amuletDataDic_5__8;
			private QuestResultModel.FirstClearModel _firstClearModel_5__9;
			private Sequence _upSeq_5__10;
			private int _i_5__11;
			private int _dispRowCount_5__12;
			private int _dispMaxCount_5__13;
			private bool _isScrollStart_5__14;
			private bool _isNeedToScroll_5__15;
			private int _treasureIconCount_5__16;
			private int _materialIconCount_5__17;
			private Vector3 _baseAnchoredPosition_5__18;
			private float _waitDuration_5__19;
			private int _treasureRow_5__20;
			private int _scrollRow_5__21;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoQuestResultAnimation_d__218(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _IconStartAnimation_d__219 : IEnumerator<object>
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
			public _IconStartAnimation_d__219(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnExpPlayerBarFinishCorutine_d__222 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AudioPlayback apb;
			public QuestResultTopPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnExpPlayerBarFinishCorutine_d__222(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass227_0
		{
			// Fields
			public QuestResultTopPage __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass227_0();
	
			// Methods
			internal void _CreateDuplicateConfirmPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass228_0
		{
			// Fields
			public int index;
			public QuestResultTopPage __4__this;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass228_0();
	
			// Methods
			internal void _DoPartEnterAnimationMission_b__1();
			internal void _DoPartEnterAnimationMission_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass247_0
		{
			// Fields
			public int questId;
			public QuestResultTopPage __4__this;
			public QuestDataElement questData;
			public Action<bool> __9__2;
	
			// Constructors
			public __c__DisplayClass247_0();
	
			// Methods
			internal void _OnRetryButton_b__0();
			internal void _OnRetryButton_b__1();
			internal void _OnRetryButton_b__2(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass248_0
		{
			// Fields
			public int questId;
			public int eventId;
	
			// Constructors
			public __c__DisplayClass248_0();
	
			// Methods
			internal void _OnRandomRetry_b__0(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass248_1
		{
			// Fields
			public EventQuestConditionPopup conditionPopup;
	
			// Constructors
			public __c__DisplayClass248_1();
	
			// Methods
			internal void _OnRandomRetry_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass253_0
		{
			// Fields
			public QuestResultTopPage __4__this;
			public int playCount;
	
			// Constructors
			public __c__DisplayClass253_0();
	
			// Methods
			internal void _OnSkipConfirmPopupOk_b__0(bool isRecoverStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass260_0
		{
			// Fields
			public EnumStete matchingState;
	
			// Constructors
			public __c__DisplayClass260_0();
	
			// Methods
			internal void _GoToIngame_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _GoToIngame_d__260 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass260_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToIngame_d__260(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _CheckDisconnectType_d__261 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass262_0
		{
			// Fields
			public Action exitSceneAction;
	
			// Constructors
			public __c__DisplayClass262_0();
	
			// Methods
			internal void _PopupMatchingError_b__0(MultiPlayError.ErrorType error);
			internal void _PopupMatchingError_b__1(MultiPlayError.ErrorType error);
		}
	
		[CompilerGenerated]
		private sealed class _UpdateReBattleCountDown_d__271 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultTopPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateReBattleCountDown_d__271(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestResultTopPage();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public ValueTuple<bool, bool> CheckStageFlags();
		public void OnPressClearParty();
		public void SlideNextAndRetryButtons(bool isOut, bool withNextButton, bool withRetryButton);
		private Sequence ButtonSlideIn(Transform buttonTrans, AnimationData buttonAnimationData, Vector3 defaultButtonPos);
		private void ButtonSlideOut(Transform buttonTrans, Vector3 defaultButtonPos, float delay);
		private void InitButton(Transform buttonTrans, Vector3 defaultButtonPos);
		public void OnPressSkip();
		private bool ShouldRaiseRaidBoostGetPU();
		public void OnPressNext();
		private void RequestSaveClearParty();
		private void RequestSaveClearPartySingle();
		private void ApiOnSuccess(QuestSetQuestClearPartyResponse res);
		private void RequestSaveClearPartyMulti();
		private void ApiOnSuccess(QuestSetQuestClearPartyMultiResponse res);
		private void ApiOnError(ErrorType errorType, int resultCode);
		public void MoveOut(Transform trans, float distance, Action onComplete);
		private void OnQuestResultDone();
		private void OnSkipTicketContinues();
		private Sequence SetRebornHeart();
		private void OnRebattlePageDone();
		public void CreateFirstClearCharaDragonPopup(QuestResultModel.FirstClearModel.FirstClearItemInfo info, Action onOKOrClose = null, Action onCancel = null);
		public void CreateFirstClearItemPopup(Action onOKOrClose = null, Action onCancel = null);
		public void CreateBonusItemPopup(Action onOKOrClose = null, Action onCancel = null);
		public void CreateBattleRoyalCycleRewardPopup(Action onOKOrClose = null, Action onCancel = null);
		[IteratorStateMachine]
		private IEnumerator CreateTimeAttackRankingTierRewardPopup(Action onCloseCallback = null);
		public void CreateCarryBonusPopup(Action onOKOrClose = null, Action onCancel = null);
		public void CreateEventCharaResultPopup();
		public void InitByData();
		private bool CanRetry();
		private void CreateDropItem();
		private void Start();
		private void SetBackKey(UnityAction action);
		private void SetButtonSoundAction(PointerEventHandler eventHandler);
		private void SetUpTreasurePanel();
		private void AddTreasureIconOneByOne(QuestResultModel.TopPageModel.RewardItemInfo item, float animationDelay, float animationDelayStep, Transform parentTransform, int row);
		public void HeaderFlashVisible();
		public void HeaderFlashInvisible();
		public bool SkipChecker();
		public void ScrollToItem(Transform target);
		public void ScrollToItem(Transform baseTrans, Transform targetTrans, float waitDuration, float scrollDuration);
		public void ScrollToItem(Vector3 baseAnchoredPosition, Vector3 targetAnchoredPosition, float waitDuration, float scrollDuration);
		[IteratorStateMachine]
		private IEnumerator WaitForTimerCoroutine(float waitTime);
		private void StartWaitTimerForSkip(float waitTime);
		private void StopWaitTimerForSkip();
		private bool IsClearPartyCheckEnable(int selectQuestId);
		[IteratorStateMachine]
		private IEnumerator DoQuestResultAnimation();
		[IteratorStateMachine]
		private IEnumerator IconStartAnimation(List<QRTreasureIcon> list);
		private bool IsNextQuestExtraBattle(int curQuestId, out QuestEventMenuElement eventMenuElement);
		private void OnExpPlayerBarFinish(AudioPlayback apb);
		[IteratorStateMachine]
		private IEnumerator OnExpPlayerBarFinishCorutine(AudioPlayback apb);
		private void NextRarePopupFlagOff();
		private void CheckRandomEventReward(QuestResultModel.TopPageModel model);
		private void CreateBuildEventReward(QuestResultModel.TopPageModel model);
		private void CreateEarnEventReward(QuestResultModel.TopPageModel model);
		private void CreateDuplicateConfirmPopup(string title, string text);
		private Sequence DoPartEnterAnimationMission();
		private void FlashMissionPlay(int index);
		private void SetFlashMissionCallback(int index, Action callback, FlMotionActionTypes type = FlMotionActionTypes.End);
		private void DisableMission(int no);
		private void SetClearMission(int index, QuestResultModel.TopPageModel.MissionClearInfo info);
		private void OnFinishMissionFlash(int no);
		private void DoCharaLevelUpAnimation(int index, int level);
		public void OnPlayerLevelUpDone();
		public void OnPlayerLevelup(int level);
		private void LevupAnimation(int level);
		private Sequence DoPageOutAnimation(bool includingTitleAndButton, bool isMovingToEventPage);
		private void InitQuestResultTop();
		public void NextButtonSlideIn();
		private void Visible(Transform trans, float alpha);
		private FlashPlayer SetupFlash(string path, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true, Canvas targetCanvas = null, int canvasSortingOrder = 0, bool isAddPlaneCountToCanvasOrder = false);
		private FlashPlayer SetupFlashEachLayer(string path, FlPlaneSortingInfo[] flPlaneSortingInfos, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true);
		public void CameraDepth(int depth);
		private int Digit(int num);
		private int MaxValue(int digit);
		public void OnRetryButton();
		private void OnRandomRetry();
		public void CreateRetryConfirmPopup();
		public void OnRetryConfirmPopupOk();
		public void OnRetryConfirmPopupCancel();
		public void CreateSkipTicketPopup();
		public void OnSkipConfirmPopupOk();
		public void SkipTicektApi(int playCount);
		private void onSkipSuccess();
		private void OnSkipTicket();
		private void onSkipError();
		private void CloseEventQuestConditionPopup();
		public void OnSkipConfirmPopupCancel();
		[IteratorStateMachine]
		public static IEnumerator GoToIngame();
		private static async void CheckDisconnectType();
		public static void PopupMatchingError(Action exitSceneAction = null);
		public void SetNextAndRetryActive(bool enable);
		public void SetNextAndRetryActive(bool enableNext, bool enableRetry);
		public void ResetRetryButton();
		public void ResetRestryButtonNotFlag();
		public void SetNextButtonCallback(UnityAction callback);
		public void SetRetryButtonCallback(UnityAction callback);
		public void OnBeforeLeaving();
		private static void Disconnect();
		[IteratorStateMachine]
		private IEnumerator UpdateReBattleCountDown();
		private bool IsNomalMultiQuest();
		[CompilerGenerated]
		private void _OnQuestResultDone_b__189_0();
		[CompilerGenerated]
		private void _OnQuestResultDone_b__189_2();
		[CompilerGenerated]
		private void _OnQuestResultDone_b__189_1();
		[CompilerGenerated]
		private void _CreateEventCharaResultPopup_b__199_0();
		[CompilerGenerated]
		private void _InitByData_b__200_0(int toLevel);
		[CompilerGenerated]
		private void _InitByData_b__200_1(int toLevel);
		[CompilerGenerated]
		private void _CreateDropItem_b__202_1();
		[CompilerGenerated]
		private void _CreateDropItem_b__202_0();
		[CompilerGenerated]
		private void _CheckRandomEventReward_b__224_0();
		[CompilerGenerated]
		private void _CreateBuildEventReward_b__225_0();
		[CompilerGenerated]
		private void _CreateEarnEventReward_b__226_0();
		[CompilerGenerated]
		private void _LevupAnimation_b__237_0();
		[CompilerGenerated]
		private void _DoPageOutAnimation_b__238_0();
	}
}
