using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	public class AlbumSummonPlay : MonoBehaviour, IPlaySummonInterface
	{
		public enum BoxSummonPlayPhase
		{
			None,
			Loading,
			FistCut,
			DropItem,
			ItemDemo,
			ItemDemoFinished,
			ToResult
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

		[SerializeField]
		private Camera mainCamera;

		[SerializeField]
		private Camera shot2CharaWeaponCamera;

		[HideInInspector]
		public Transform node3d;

		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;

		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;

		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;

		private const float charaCutinBGMTime = 1f;

		private Coroutine shot2CutinBGMCoroutine;

		private Coroutine shot2CutinSECoroutine;

		private Coroutine shot2CutinEffectCoroutine;

		private Coroutine shot2AdventSECoroutine;

		private Coroutine shot2CutinTextureOffsetCoroutine;

		private Coroutine shot2WaitCoroutine;

		private Coroutine _execCoroutine;

		private IEnumerator checkCharaAppealEndCoroutine;

		private const int rSPFXTrigger = 8;

		private const int srSPFXTrigger = 9;

		private const int ssrSPFXTrigger = 10;

		private const int stopSPFXTrigger = 1;

		private const float originalCameraFov = 60f;

		private const float shot1StoneScale = 2.4f;

		private const float shot2StoneScale = 1.5f;

		private const float darkBGColorPower = 0.3f;

		private bool isTimerEnd;

		private Camera flashCamera;

		private List<SummonResultItemData> resultItems;

		private AlbumSummonCanvas parentPage;

		private Vector3 resultFlashCameraInitPosition;

		private Animator cameraAnimator;

		private GameObject cameraAnimationParent;

		private Camera storedMainCamera;

		private bool isEnableScreenTapped;

		private BoxSummonPlayPhase playPhase;

		private SummonUnitShaderSettings unitShaderSettings;

		private AudioPlayback bgmAudioPlayer;

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

		FlashPlayerManager IPlaySummonInterface.flashPlayerManager => null;

		Transform IPlaySummonInterface.node3d => null;

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

		public void StartLoading(AlbumSummonCanvas page, Camera camera, Action loadEndCallback)
		{
		}

		private IEnumerator LoadResource(Action loadEndCallback)
		{
			return null;
		}

		public IEnumerator LoadSummonBgScene()
		{
			return null;
		}

		public void UnloadSummonBgScene()
		{
		}

		private void OnAllAsyncLoadPrepared()
		{
		}

		public void StartAnimation()
		{
		}

		private IEnumerator PlaySummonAnimation()
		{
			return null;
		}

		private void CameraInitialize()
		{
		}

		private void ResetCameraPositionInStage()
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

		private IEnumerator PlayBgmCorutine()
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

		private IEnumerator StartNextStageAnimation()
		{
			return null;
		}

		private IEnumerator StartUnitShowingUp()
		{
			return null;
		}

		private void SetWeaponVisibilityState(int index, bool useWeaponModel, bool isMainWeapon, bool visible)
		{
		}

		private void SetWeaponBindArmState(int index, bool useWeaponModel, bool isMainWeapon, bool rightArm)
		{
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

		public void ResetCamera()
		{
		}

		private void SetupEtoECamera()
		{
		}

		public void ClearAll()
		{
		}

		private void GoToResult()
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

		public void SetupStageRenderCamera(bool isEnable, [Optional] RenderTexture shot2CharaWeaponRenderTexture)
		{
		}
	}
}
