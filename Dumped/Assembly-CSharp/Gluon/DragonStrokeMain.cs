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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonStrokeMain : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public DragonStrokeScene scene;
		[HideInInspector]
		public Canvas mainCanvas;
		private PettingCamera pettingCamera;
		[Header]
		[SerializeField]
		public ContactReliabilitySlider uiFriendlyGauge;
		public GameObject uiFriendlyIcon;
		public UnityEngine.UI.Text uiFriendlyLevel;
		public GameObject uiFriendlyGaugeNowMaxParent;
		public UnityEngine.UI.Text uiFriendlyAddedValText;
		public RectTransform uiSafeZone;
		public GameObject emptyDragonMessageGO;
		public GameObject topPanel;
		[Header]
		[SerializeField]
		public ContactShopPanel shopPanel;
		public GameObject bottomMainPanel;
		[Header]
		[SerializeField]
		public PettingBalloon balloon;
		[HideInInspector]
		public BackButton uiBackButton;
		public Button uiChangeButton;
		public Button uiPresentButton;
		public GameObject uiFlyingHeartIcon;
		public UnityEngine.UI.Text uiDragonNameText;
		public Button uiBackGroundButton;
		public GameObject pettingBadge;
		[Header]
		[SerializeField]
		public TweenSequenceVisualizer gaugeKiraEffectRunner;
		public TweenSequenceVisualizer giftKiraEffectRunner;
		public TweenSequenceVisualizer angryKiraEffectRunner;
		public TweenSequenceVisualizer happyKiraEffectRunner;
		[Header]
		[SerializeField]
		public int paramFriendlyLevel;
		public int paramFriendlyLevelMax;
		public int paramGiftReturnTalkWaitTime;
		public int paramHappyTalkWaitTime;
		private bool flagFriendlyLevelUp;
		public int paramJoyGaugeUpValue;
		public float joyGaugeUpSpeed;
		public float joyGaugeDownSpeed;
		public int paramFriendlyGaugeUpValue;
		public float friendlyGaugeUpSpeed;
		public float friendlyGaugeDownSpeed;
		[Header]
		[SerializeField]
		public Color tapFirstColor;
		public GameObject rootTapEffect;
		public ContactHeartControl[] heartEffects;
		private int usingSingleHeartIndex;
		private const int totalSingleHeartCount = 3;
		public FlashPlayerManager flashPlayerManager;
		public ContactFlashHeartControl[] heartFlashPlayers;
		public Transform heartAttachPoint;
		[Header]
		[SerializeField]
		public AnimationUIAutoPublisher buttonInOutPublisher;
		[Header]
		public Vector3 flashCameraPos;
		public Vector3 flashCameraRot;
		public Vector2 flashNearFarClip;
		public GameObject skipButtonObj;
		[HideInInspector]
		public Action skipAction;
		public const string strokeEffectName = "EFF_DRG_21012801_002";
		private EffectObject strokeEffect;
		private int walkerSkillLevelBefore;
		private bool isStroke;
		private bool isHappy;
		private bool isPlayngWalkerVoice;
		private ButtonPressedMark _backButtonMark;
		private const float buttonMoveTime = 0.5f;
		private ContactDragon dragonObj;
		private GameObject strokeCube;
		public const string prefabPath = "Prefabs/OutGame/DragonContact/";
		public const string animationPath = "Animations/OutGame/DragonContact/";
		private ContactFlashEffect flashEffectFriendlyUp;
		private const string flashEffectFriendlyUpPath = "Prefabs/OutGame/DragonContact/FlashEffect/pf_dragon_stroke_reliability_up";
		private ContactGodRay godray;
		private float godrayDelayTime;
		private float godrayBrightTime;
		private string voiceLoadName;
		private string voiceStoryLoadName;
		private Vector2 defaultPositionBackButton;
		private int oldFriendlyTotalValue;
		private Sequence addedValSequence;
		private bool wasLastGiftFavorite;
		private bool isSwitchAndShopButtonOut;
		private bool _isBackButtonOut;
		private bool isTargetLevelHitByAnyHeart;
		private Camera flashCamera;
		private GameObject flashCameraObj;
		private Transform flashCameraTrans;
		private TweenSequenceVisualizer[] emotionEffectRunners;
		private ContactFlashEffect flashEffectReturnGift;
		private float nextLeaveTimer;
		private float leaveTimer;
		private const string giftReturnSE = "SE_DC_0010";
		private ContactMode contactMode;
	
		// Properties
		private ButtonPressedMark backButtonMark { get; }
		private bool isBackButtonOut { get; set; }
	
		// Nested types
		public enum walkerVoiceType
		{
			Start = 0,
			Wait = 1,
			Touch = 2,
			GetGift = 3,
			FinishStroke = 4
		}
	
		private enum ContactMode
		{
			None = -1,
			Idle = 0,
			Joy = 1,
			Hate = 2,
			PlusWait = 3,
			Happy = 4,
			PresentSelect = 5,
			PresentReturn = 6
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0
		{
			// Fields
			public UnitStoryRewardPopup popup;
			public DragonStrokeMain __4__this;
	
			// Constructors
			public __c__DisplayClass99_0();
	
			// Methods
			internal void _InitReset_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _PlayLevelUp_d__117 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool fromPetting;
			public DragonStrokeMain __4__this;
			public int heartCount;
			public int carry;
			public int targetLevel;
			public ContactMessage.ContactMessageData message;
			public Action onDone;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayLevelUp_d__117(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayPlainHappy_d__118 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeMain __4__this;
			private TouchGuardObject _touchGuard_5__2;
			private ContactMessage.ContactMessageData _msg_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayPlainHappy_d__118(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayGiftReturn_d__119 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ContactMessage.ContactMessageData message;
			public DragonStrokeMain __4__this;
			public Action onDone;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayGiftReturn_d__119(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayOnReceivePresentReturn_d__120 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeMain __4__this;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayOnReceivePresentReturn_d__120(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ForceRegisterBackKeyCoroutine_d__127 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeMain __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ForceRegisterBackKeyCoroutine_d__127(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _TouchGuardInAnimation_d__132 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GameObject gameObject;
			private BaseCanvas _baseCanvas_5__2;
			private PointerEventHandler _pointerEventHandler_5__3;
			private TouchGuardObject _touchGuard_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TouchGuardInAnimation_d__132(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitHappyMotion_d__148 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeMain __4__this;
			public Action onFinishHappy;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitHappyMotion_d__148(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass150_0
		{
			// Fields
			public DragonStrokeMain __4__this;
			public Action onVoiceDone;
	
			// Constructors
			public __c__DisplayClass150_0();
	
			// Methods
			internal void _PlayWalkerVoice_b__0();
		}
	
		// Constructors
		public DragonStrokeMain();
	
		// Methods
		public void OnDebugPettingCountFullButtonPressed();
		public void OnDebugPettingShopResetButtonPressed();
		public void OnDebugReliabilitySetButtonPressed(int typeVal);
		public void OnDebugWindowButtonPressed();
		private void Awake();
		private void OnInitAsyncLoadFinished();
		public void SetBadge();
		public void InitReset();
		public void ReadyStart();
		public void StartExitAnimation();
		private void CreateFlashCamera();
		public void PlayGiftSentEffect();
		public void FadeInGodRay();
		public void Update();
		public void ChangeBackButtonToFort();
		private void ChangeBackButtonFromPresent();
		public void StartRandomMessage(bool ignoreDelay);
		private void OnDisable();
		public bool LoadDragon(int a_dragonID, bool enableEffect = true);
		public void StartGreetingMessage(int a_dragonID);
		public void StopMessage();
		private void PutInButtonAndReturnToIdle();
		private void AutoProcessLevelUpReward();
		private void AutoProcessGiftAndReward();
		private void CheckWalkerEventReward();
		[IteratorStateMachine]
		private IEnumerator PlayLevelUp(bool fromPetting, int targetLevel, int heartCount, Action onDone, ContactMessage.ContactMessageData message, int carry);
		[IteratorStateMachine]
		private IEnumerator PlayPlainHappy();
		[IteratorStateMachine]
		private IEnumerator PlayGiftReturn(Action onDone, ContactMessage.ContactMessageData message);
		[IteratorStateMachine]
		private IEnumerator PlayOnReceivePresentReturn();
		public void OnBeforeSendGift();
		public void OnGiftSent(bool favorite);
		public void OnPresentReceived();
		public void OnPushPresentButton();
		public void OnReturnFromShop();
		public void OnPushBackGroundButton();
		[IteratorStateMachine]
		private IEnumerator ForceRegisterBackKeyCoroutine();
		public void OnPushBackButton();
		public void OnPushChangeButton();
		public void PutOutButton(bool includeBackButton = true);
		public void PutInButton();
		[IteratorStateMachine]
		private IEnumerator TouchGuardInAnimation(GameObject gameObject);
		public void SetEmotionEffectParentLocation(int index, Vector2 pos);
		public void DisplayHeartEmotion(int heartCount, int carry, int targetLevel, Action onTargetHitByAnyHeart);
		public void DisplayEmotionIcon(ContactMessage.ContactEmotion contactEmotion);
		public void DisableEmotionIcon();
		private bool CheckOnlineFriendlyLevelGauge();
		private void ShowFriendlyAddedVal(int added);
		private void InitLeaveTimer();
		private float CalcUiGaugeValue(float curValue, float maxValue, bool isReciprocal = false);
		public void SetSkipButton(bool isActive, Action action = null);
		public void OnSkipButton();
		private void OnDestroy();
		private void SetupWalkerEvent();
		private void SetStrokeCube();
		private void OnBeginStroke();
		private void OnEndStroke();
		[IteratorStateMachine]
		private IEnumerator WaitHappyMotion(Action onFinishHappy);
		public bool IsSelectWalkerUnit();
		public void PlayWalkerVoice(walkerVoiceType voiceType, Action onVoiceDone = null);
		[CompilerGenerated]
		private void _AutoProcessLevelUpReward_b__114_0();
		[CompilerGenerated]
		private void _AutoProcessGiftAndReward_b__115_0();
		[CompilerGenerated]
		private void _AutoProcessGiftAndReward_b__115_1();
		[CompilerGenerated]
		private void _PlayLevelUp_b__117_0();
		[CompilerGenerated]
		private bool _PlayLevelUp_b__117_1();
		[CompilerGenerated]
		private bool _PlayLevelUp_b__117_2();
		[CompilerGenerated]
		private void _PlayLevelUp_b__117_5();
		[CompilerGenerated]
		private void _PlayLevelUp_b__117_3();
		[CompilerGenerated]
		private bool _PlayLevelUp_b__117_4();
		[CompilerGenerated]
		private bool _PlayPlainHappy_b__118_0();
		[CompilerGenerated]
		private void _PlayPlainHappy_b__118_1();
		[CompilerGenerated]
		private bool _PlayPlainHappy_b__118_2();
		[CompilerGenerated]
		private void _PlayGiftReturn_b__119_0();
		[CompilerGenerated]
		private bool _PlayGiftReturn_b__119_1();
		[CompilerGenerated]
		private void _PlayOnReceivePresentReturn_b__120_0();
		[CompilerGenerated]
		private void _PlayOnReceivePresentReturn_b__120_1();
		[CompilerGenerated]
		private bool _PlayOnReceivePresentReturn_b__120_2();
		[CompilerGenerated]
		private void _OnReturnFromShop_b__125_0();
		[CompilerGenerated]
		private void _OnPushChangeButton_b__129_0(int id);
		[CompilerGenerated]
		private void _OnPushChangeButton_b__129_1();
		[CompilerGenerated]
		private void _DisplayHeartEmotion_b__134_0(int carriedVal);
		[CompilerGenerated]
		private void _ShowFriendlyAddedVal_b__138_0();
		[CompilerGenerated]
		private void _SetStrokeCube_b__145_0();
		[CompilerGenerated]
		private void _OnEndStroke_b__147_0();
		[CompilerGenerated]
		private bool _WaitHappyMotion_b__148_0();
	}
}
