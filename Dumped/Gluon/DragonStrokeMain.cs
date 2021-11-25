using System;
using System.Collections;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DragonStrokeMain : MonoBehaviour
	{
		public enum walkerVoiceType
		{
			Start,
			Wait,
			Touch,
			GetGift,
			FinishStroke
		}

		private enum ContactMode
		{
			None = -1,
			Idle,
			Joy,
			Hate,
			PlusWait,
			Happy,
			PresentSelect,
			PresentReturn
		}

		[HideInInspector]
		public DragonStrokeScene scene;

		[HideInInspector]
		public Canvas mainCanvas;

		private PettingCamera pettingCamera;

		[SerializeField]
		[Header("UI")]
		public ContactReliabilitySlider uiFriendlyGauge;

		public GameObject uiFriendlyIcon;

		public Text uiFriendlyLevel;

		public GameObject uiFriendlyGaugeNowMaxParent;

		public Text uiFriendlyAddedValText;

		public RectTransform uiSafeZone;

		public GameObject emptyDragonMessageGO;

		public GameObject topPanel;

		[SerializeField]
		[Header("Shop")]
		public ContactShopPanel shopPanel;

		public GameObject bottomMainPanel;

		[SerializeField]
		[Header("UI")]
		public PettingBalloon balloon;

		[HideInInspector]
		public BackButton uiBackButton;

		public Button uiChangeButton;

		public Button uiPresentButton;

		public GameObject uiFlyingHeartIcon;

		public Text uiDragonNameText;

		public Button uiBackGroundButton;

		public GameObject pettingBadge;

		[SerializeField]
		[Header("Effect")]
		public TweenSequenceVisualizer gaugeKiraEffectRunner;

		public TweenSequenceVisualizer giftKiraEffectRunner;

		public TweenSequenceVisualizer angryKiraEffectRunner;

		public TweenSequenceVisualizer happyKiraEffectRunner;

		[SerializeField]
		[Header("Parameters")]
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

		[SerializeField]
		[Header("Effects")]
		public Color tapFirstColor;

		public GameObject rootTapEffect;

		public ContactHeartControl[] heartEffects;

		private int usingSingleHeartIndex;

		private const int totalSingleHeartCount = 3;

		public FlashPlayerManager flashPlayerManager;

		public ContactFlashHeartControl[] heartFlashPlayers;

		public Transform heartAttachPoint;

		[SerializeField]
		[Header("Publishers")]
		public AnimationUIAutoPublisher buttonInOutPublisher;

		[Header("Flashå\u0090\u0091ã\u0081\u0091ã\u0082«ã\u0083¡ã\u0083©ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
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

		private ButtonPressedMark backButtonMark => null;

		private bool isBackButtonOut
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void OnDebugPettingCountFullButtonPressed()
		{
		}

		public void OnDebugPettingShopResetButtonPressed()
		{
		}

		public void OnDebugReliabilitySetButtonPressed(int typeVal)
		{
		}

		public void OnDebugWindowButtonPressed()
		{
		}

		private void Awake()
		{
		}

		private void OnInitAsyncLoadFinished()
		{
		}

		public void SetBadge()
		{
		}

		public void InitReset()
		{
		}

		public void ReadyStart()
		{
		}

		public void StartExitAnimation()
		{
		}

		private void CreateFlashCamera()
		{
		}

		public void PlayGiftSentEffect()
		{
		}

		public void FadeInGodRay()
		{
		}

		public void Update()
		{
		}

		public void ChangeBackButtonToFort()
		{
		}

		private void ChangeBackButtonFromPresent()
		{
		}

		public void StartRandomMessage(bool ignoreDelay)
		{
		}

		private void OnDisable()
		{
		}

		public bool LoadDragon(int a_dragonID, bool enableEffect = true)
		{
			return default(bool);
		}

		public void StartGreetingMessage(int a_dragonID)
		{
		}

		public void StopMessage()
		{
		}

		private void PutInButtonAndReturnToIdle()
		{
		}

		private void AutoProcessLevelUpReward()
		{
		}

		private void AutoProcessGiftAndReward()
		{
		}

		private IEnumerator PlayLevelUp(bool fromPetting, int targetLevel, int heartCount, Action onDone, ContactMessage.ContactMessageData message, int carry)
		{
			return null;
		}

		private IEnumerator PlayPlainHappy()
		{
			return null;
		}

		private IEnumerator PlayGiftReturn(Action onDone, ContactMessage.ContactMessageData message)
		{
			return null;
		}

		private IEnumerator PlayOnReceivePresentReturn()
		{
			return null;
		}

		public void OnBeforeSendGift()
		{
		}

		public void OnGiftSent(bool favorite)
		{
		}

		public void OnPresentReceived()
		{
		}

		public void OnPushPresentButton()
		{
		}

		public void OnReturnFromShop()
		{
		}

		public void OnPushBackGroundButton()
		{
		}

		private IEnumerator ForceRegisterBackKeyCoroutine()
		{
			return null;
		}

		public void OnPushBackButton()
		{
		}

		public void OnPushChangeButton()
		{
		}

		public void PutOutButton(bool includeBackButton = true)
		{
		}

		public void PutInButton()
		{
		}

		private IEnumerator TouchGuardInAnimation(GameObject gameObject)
		{
			return null;
		}

		public void SetEmotionEffectParentLocation(int index, Vector2 pos)
		{
		}

		public void DisplayHeartEmotion(int heartCount, int carry, int targetLevel, Action onTargetHitByAnyHeart)
		{
		}

		public void DisplayEmotionIcon(ContactMessage.ContactEmotion contactEmotion)
		{
		}

		public void DisableEmotionIcon()
		{
		}

		private bool CheckOnlineFriendlyLevelGauge()
		{
			return default(bool);
		}

		private void ShowFriendlyAddedVal(int added)
		{
		}

		private void InitLeaveTimer()
		{
		}

		private float CalcUiGaugeValue(float curValue, float maxValue, bool isReciprocal = false)
		{
			return default(float);
		}

		public void SetSkipButton(bool isActive, [Optional] Action action)
		{
		}

		public void OnSkipButton()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetupWalkerEvent()
		{
		}

		private void SetStrokeCube()
		{
		}

		private void OnBeginStroke()
		{
		}

		private void OnEndStroke()
		{
		}

		private IEnumerator WaitHappyMotion(Action onFinishHappy)
		{
			return null;
		}

		public bool IsSelectWalkerUnit()
		{
			return default(bool);
		}

		public void PlayWalkerVoice(walkerVoiceType voiceType, [Optional] Action onVoiceDone)
		{
		}
	}
}
