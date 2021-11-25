using System;
using System.Collections;
using System.Collections.Generic;
using CriWare;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PlaySummon : MonoBehaviour, IPlaySummonInterface
	{
		public enum BGMJumpToLocation
		{
			None,
			Rewind,
			Hook
		}

		private static PlaySummon instance;

		private const float originalCameraFov = 60f;

		private const string stageBGSceneName = "SummonBGScene";

		private const string stageBGScenePath = "Scene/OutGame/SummonBGScene/SummonBGScene";

		private const int rSPFXTrigger = 8;

		private const int srSPFXTrigger = 9;

		private const int ssrSPFXTrigger = 10;

		private const int stopSPFXTrigger = 1;

		private const float shot1StoneScale = 2.4f;

		private const float shot2StoneScale = 1.5f;

		private const float shot2AmuletScale = 1f;

		private const float darkBGColorPower = 0.3f;

		private const float overExposureBGColorPower = 4f;

		private Sequence bgExposureSequence;

		private const string amuletRarity5hot2CameraName = "Rarity5";

		public Camera mainCamera;

		private Animator cameraAnimator;

		private GameObject cameraAnimationParent;

		[SerializeField]
		[Header("StageRate")]
		private float[] rStageRates;

		[SerializeField]
		private float[] srStageRates;

		[SerializeField]
		private float[] ssrStageRates;

		[SerializeField]
		[Header("WhiteOutEffect")]
		private Image whiteOutImage;

		private Tweener whiteOutTweener;

		[HideInInspector]
		public SummonScene scene;

		[HideInInspector]
		public Transform node3d;

		[SerializeField]
		[Header("BGM")]
		private float bgmWaitTime;

		public Button skipButton;

		private bool isSkip;

		private bool isNextPressed;

		private bool isTimerEnd;

		private IEnumerator checkCharaAppealEndCoroutine;

		private Coroutine shot2WaitCoroutine;

		private List<SummonResultItemData> resultItems;

		private const string resultDummyWeaponPathTemplate = "Weapon/model/w{0}_01";

		private const string resultDummyWeaponPathTemplateSaya = "Weapon/model/w{0}_02";

		private int[] resultDummyWeaponIdList;

		private const string cutinSEName = "SE_SUMMON_0014";

		private const string cutinRSEName = "SE_SUMMON_0030";

		private const string cutinSRSEName = "SE_SUMMON_0031";

		private const string cutinSSRSEName = "SE_SUMMON_0034";

		private const string cutinSSRAdventSEName = "SE_SUMMON_0032";

		private const string charaSSRSlashSEName = "SE_SUMMON_0033";

		private const string moonGetSEName = "SE_SUMMON_0036";

		private const string amuletAdventSEName = "SE_SUMMON_0038";

		private const string dragonStoneBreakSEName = "SE_SUMMON_0042";

		private const string dragonSSRUniverseSEName = "SE_SUMMON_0043";

		private Coroutine shot2AdventSECoroutine;

		private Coroutine shot2CutinSECoroutine;

		private Coroutine shot2CutinEffectCoroutine;

		private Coroutine shot2CutinTextureOffsetCoroutine;

		private Coroutine shot2SwitchToWeaponModelCoroutine;

		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;

		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;

		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;

		private Camera oldFlashCamera;

		[HideInInspector]
		public Camera sceneResultFlashCamera;

		private AudioPlayback bgmAudioPlayer;

		private CriAtomExPlayback bgmAudioPlayback;

		private AudioPlayback unitVoiceAudio;

		private long bgmBeatBeginingPos;

		private long bgmBeatInterval;

		private const long bgmBeatSecondPartBeginingPos = 1314L;

		private const long bgmBeatSecondPartInterval = 375L;

		private Action onBGMSyncSkipReady;

		private bool isSyncBGMForSkipDone;

		private bool isWaitingForShot2SkipPoint;

		private const float shot2BGMSyncWhiteOutTime = 0.25f;

		private BGMJumpToLocation bgmJumpToLocation;

		private bool isShot1SkipForBGMTransition;

		public static PlaySummon Instance => null;

		Transform IPlaySummonInterface.node3d => null;

		FlashPlayerManager IPlaySummonInterface.flashPlayerManager => null;

		CameraClearFlags IPlaySummonInterface.oldFlashCameraClearFlags
		{
			get
			{
				return default(CameraClearFlags);
			}
			set
			{
			}
		}

		RenderTexture IPlaySummonInterface.charaWeaponRenderTexture => null;

		public bool IsBoxSummon => default(bool);

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private PlaySummon()
		{
		}

		static PlaySummon()
		{
		}

		private void StartNowLoading(bool showGauge)
		{
		}

		private void TerminateNowLoading()
		{
		}

		public void OnBoxSummonEvent(BoxSummonEventId eid)
		{
		}

		private IEnumerator LoadBackgroundCoroutine()
		{
			return null;
		}

		private IEnumerator PreloadAllAnimations(bool isResult)
		{
			return null;
		}

		private void OnAllAsyncLoadPrepared()
		{
		}

		private void ProphetSetup()
		{
		}

		private void FafnirSetup()
		{
		}

		private void FallItemSetup()
		{
		}

		private void FallItemScaleSetup()
		{
		}

		private void CameraInitialize()
		{
		}

		private void PlayCutin(int index)
		{
		}

		private void DisableFafnir()
		{
		}

		private IEnumerator PlayAdventSECoroutine(int i)
		{
			return null;
		}

		private IEnumerator PlayCutinSECoroutine(int i)
		{
			return null;
		}

		private IEnumerator PlayCutinEffectCoroutine(int i)
		{
			return null;
		}

		private IEnumerator PlayCutinOuterTextureOffsetCoroutine(int i)
		{
			return null;
		}

		private IEnumerator SwitchToWeaponModelCoroutine(int phase)
		{
			return null;
		}

		private void KickSPFXEffectTriggerByRarity(GameObject go, Rarity rarity, int offset = 0)
		{
		}

		private IEnumerator KickSPFXEffectTriggerByRarityCoroutine(GameObject go, Rarity rarity, int offSet)
		{
			return null;
		}

		public void SetVisibleDropItem(bool isVisible)
		{
		}

		public void DroppingObjectDestory()
		{
		}

		private void ResetCameraPositionInStage()
		{
		}

		private void ResetCamera(bool bIsDragon = false)
		{
		}

		public void StartWhiteOutEffect(float inTime, float outTime)
		{
		}

		private IEnumerator CheckCharaAppealEndCoroutine(int index)
		{
			return null;
		}

		private IEnumerator Shot2ObjectDisableTimer(float time)
		{
			return null;
		}

		private void StopShot2ObjectDisableTimer()
		{
		}

		public bool IsPlayCameraAnimation()
		{
			return default(bool);
		}

		private void SyncBGMForSkip(Action onSkipReady)
		{
		}

		private void OnTransitionToNextPart()
		{
		}

		private long QueryNextSkipPoint(Action onSkipReady)
		{
			return default(long);
		}

		private void OnEverySkipPoint()
		{
		}

		private void ClearSyncBGMFlag()
		{
		}

		private long GetCurrentBGMPosition()
		{
			return default(long);
		}

		private void StartWaitSyncBGMForSkip()
		{
		}

		public void OnStageViewInstantiated()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SchedulePostEffect(SummonPostEffectSettingsBase.SettingSetType type)
		{
		}

		public void TerminatePostEffect(SummonPostEffectSettingsBase.SettingSetType type)
		{
		}

		private IEnumerator SummonStageFlow()
		{
			return null;
		}

		private IEnumerator SummonStageFlowFirst()
		{
			return null;
		}

		private IEnumerator SummonStageFlowSecond()
		{
			return null;
		}

		public void OnShot1WeaponDropped(int index, EffectObject playingEffect)
		{
		}

		private void SetWeaponVisibilityState(int index, bool useWeaponModel, bool isMainWeapon, bool visible)
		{
		}

		private void SetWeaponBindArmState(int index, bool useWeaponModel, bool isMainWeapon, bool rightArm)
		{
		}

		private void ResetStatue()
		{
		}

		public IEnumerator CharactorAppeal(int index)
		{
			return null;
		}

		public void CharactorAppealDragonNewType(int index)
		{
		}

		private void OnFinalize()
		{
		}

		public void DetachChildrenToStageNode(Transform t, bool forceDeactivate)
		{
		}

		public bool OnInitialize()
		{
			return default(bool);
		}

		public bool OnFadeIn()
		{
			return default(bool);
		}

		public void OnNextButton()
		{
		}

		public void OnSkipButton()
		{
		}

		public static void AdjustCharacterColorPower(int index, float power)
		{
		}

		public static void AdjustBGColorPower(float power)
		{
		}

		public Transform ActivateModelAtIndexForResult(int index)
		{
			return null;
		}

		private IEnumerator ShowMoonForResultCoroutine(GameObject modelObject, Rarity rarity)
		{
			return null;
		}

		private void LoadRichObject(GameObject rootObject, string path)
		{
		}
	}
}
