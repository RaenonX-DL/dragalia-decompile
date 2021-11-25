using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class BoxSummonAnimScene : MonoBehaviour, IPlaySummonInterface
	{
		public class PickupItemInfo
		{
			public int index;

			public int priority;

			public PickupItemInfo()
			{
			}

			public PickupItemInfo(int index, int priority)
			{
			}
		}

		public enum BoxSummonPlayPhase
		{
			None,
			Loading,
			FistCut,
			SkipFirstCut,
			DropItem,
			ItemDemo,
			SkipItemDemo,
			ItemDemoFinished,
			ToResult
		}

		private class CombinedMasterElement
		{
			public CharaDataElement charaMasterData;

			public DragonDataElement dragonMasterData;

			public WeaponBodyElement weaponMasterData;

			public SummonModel.StageEffectType GetStageEffectType()
			{
				return default(SummonModel.StageEffectType);
			}
		}

		private enum ItemFallKind
		{
			Normal,
			Ssr,
			Nof
		}

		[SerializeField]
		private GameObject stage3dNode;

		[SerializeField]
		private SummonPostEffectSetting postEffectSetting;

		[SerializeField]
		private SummonPostFilmSetting postFilmSetting;

		[SerializeField]
		private GameObject postEffectCameraGO;

		[SerializeField]
		private Transform camera3DParent;

		[HideInInspector]
		public Transform node3d;

		private Coroutine _execCoroutine;

		public bool isExitStarted;

		private const float originalCameraFov = 60f;

		private const int rSPFXTrigger = 8;

		private const int srSPFXTrigger = 9;

		private const int ssrSPFXTrigger = 10;

		private const int stopSPFXTrigger = 1;

		public Camera mainCamera;

		private Animator cameraAnimator;

		private GameObject cameraAnimationParent;

		private Camera storedMainCamera;

		public Camera shot2CharaWeaponCamera;

		private bool isEnableScreenTapped;

		private bool isEnableSkipTapped;

		private bool isFadingOut;

		private List<PickupItemInfo> pickupItemIndexList;

		private Vector3 resultFlashCameraInitPosition;

		private BoxSummonPlayPhase playPhase;

		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;

		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;

		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;

		private BoxSummonAnimPage parentPage;

		private static readonly string SE_ITEM_FALL;

		private static readonly string SE_RARE_ITEM_GET;

		private const float darkBGColorPower = 0.3f;

		private List<SummonResultItemData> resultItems;

		private FlashPlayer[] itemFallFlashPlayers;

		private bool isTimerEnd;

		private IEnumerator checkCharaAppealEndCoroutine;

		private Coroutine shot2WaitCoroutine;

		private Coroutine shot2CutinSECoroutine;

		private Coroutine shot2CutinEffectCoroutine;

		private Coroutine shot2AdventSECoroutine;

		private const float charaCutinSETime = 1.8666667f;

		private const float charaCutinRaritySETime = 2.8f;

		private const float dragonCutinSETime = 2.2666667f;

		private const float dragonCutinRaritySETime = 3.2f;

		private const float moonCutinRaritySETime = 1.7f;

		private const string cutinSEName = "SE_SUMMON_0014";

		private const string cutinRSEName = "SE_SUMMON_0015";

		private const string cutinSRSEName = "SE_SUMMON_0016";

		private const string cutinSSRSEName = "SE_SUMMON_0017";

		private const float shot1StoneScale = 2.4f;

		private const float shot2StoneScale = 1.5f;

		private static readonly Vector2[] iconPosition1;

		private static readonly Vector2[] iconPosition2;

		private static readonly Vector2[] iconPosition3;

		private static readonly Vector2[] iconPosition4;

		private static readonly Vector2[] iconPosition5;

		private static readonly Vector2[] iconPosition6;

		private static readonly Vector2[] iconPosition7;

		private static readonly Vector2[] iconPosition8;

		private static readonly Vector2[] iconPosition9;

		public static readonly Vector2[] iconPosition10;

		public static readonly Vector2[][] iconPositions;

		Transform IPlaySummonInterface.node3d => null;

		public Camera OverlayUICamera => null;

		public bool isScreenTapped
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSkipTapped
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

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

		public void Start()
		{
		}

		public void OnDestroy()
		{
		}

		public void Init()
		{
		}

		public void StartLoading(BoxSummonAnimPage page, bool show3DModel, Action loadEndCallback)
		{
		}

		private IEnumerator LoadResource(Action loadEndCallback)
		{
			return null;
		}

		private void OnAllAsyncLoadPrepared()
		{
		}

		public void StartAnimation(Action animEndCallback, bool isNextAnimation = false)
		{
		}

		private IEnumerator PlaySummonAnimation(Action animEndCallback, bool isNextAnimation = false)
		{
			return null;
		}

		private void CameraInitialize()
		{
		}

		private void ResetCameraPositionInStage()
		{
		}

		private void RemoveTouchGuard()
		{
		}

		private IEnumerator Shot2ObjectDisableTimer(float time)
		{
			return null;
		}

		private void StopShot2ObjectDisableTimer()
		{
		}

		public void TerminatePostEffect(SummonPostEffectSettingsBase.SettingSetType type)
		{
		}

		private IEnumerator PlayCutinSECoroutine(int i)
		{
			return null;
		}

		private IEnumerator PlayCutinEffectCoroutine(int i)
		{
			return null;
		}

		public void CharactorAppeal(int index)
		{
		}

		private IEnumerator CheckCharaAppealEndCoroutine(int index)
		{
			return null;
		}

		private void PlayCutin(int index)
		{
		}

		private IEnumerator PlayAdventSECoroutine(int i)
		{
			return null;
		}

		private IEnumerator SummonStageFlow()
		{
			return null;
		}

		private IEnumerator StartNextStageAnimation()
		{
			return null;
		}

		private IEnumerator StartDragonShowingUp()
		{
			return null;
		}

		private void FallItemSetup()
		{
		}

		private void Reset()
		{
		}

		public void OnFinalize()
		{
		}

		private void ResetCamera(bool bIsDragon = false)
		{
		}

		private void ProphetSetup()
		{
		}

		public void SchedulePostEffect(SummonPostEffectSettingsBase.SettingSetType type)
		{
		}

		private void KickSPFXEffectTriggerByRarity(GameObject go, Rarity rarity, int offset = 0)
		{
		}

		private IEnumerator KickSPFXEffectTriggerByRarityCoroutine(GameObject go, Rarity rarity, int offSet)
		{
			return null;
		}

		public bool IsPlayCameraAnimation()
		{
			return default(bool);
		}

		void IPlaySummonInterface.StartWhiteOutEffect(float inTime, float outTime)
		{
		}

		public void OnBoxSummonEvent(BoxSummonEventId eid)
		{
		}

		public void SkipFirstCut()
		{
		}

		public void StartItemFall()
		{
		}

		public void DestroyItemFallFlashPlayers()
		{
		}

		public void ShowItemFallFlashPlayers(bool toShow)
		{
		}

		private void SetupEtoECamera()
		{
		}

		private void ResetEtoECamera()
		{
		}

		private void ExitItemFall()
		{
		}

		private IEnumerator ItemFallCoroutine()
		{
			return null;
		}

		private FlashPlayer GetItemFallFlashPlayer(int index)
		{
			return null;
		}

		public void ClearAll()
		{
		}

		public void DestroyStage3DNodeChildren()
		{
		}

		private void GoToResult(bool isFadingOut)
		{
		}

		private void DestroyChildren(Transform t)
		{
		}

		public bool OnScreenTapped()
		{
			return default(bool);
		}

		private void SetEnableScreenTapped(bool f)
		{
		}

		private IEnumerator SkipFirstDemoCoroutine()
		{
			return null;
		}

		public void SetEnableSkipTapped(bool f)
		{
		}

		public void SkipAniamtion(bool needFadeOut)
		{
		}

		private IEnumerator SkipCoroutine(bool needFadeOut)
		{
			return null;
		}

		public void SetupStageRenderCamera(bool isEnable, [Optional] RenderTexture shot2CharaWeaponRenderTexture)
		{
		}
	}
}
