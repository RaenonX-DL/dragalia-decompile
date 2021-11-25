using System;
using System.Collections;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPageScene : SceneBase
	{
		public enum State
		{
			None,
			MoveMapLoadWait,
			SkitMapLoadWait,
			MoveMapCreate,
			SkitMapCreate,
			MoveFadeIn,
			MoveNormal,
			MoveFadeOutToSkitRender,
			MoveFadeOutToSkitLoad,
			MoveFadeOutToSkit,
			MoveFadeOutToMoveRender,
			MoveFadeOutToMoveLoad,
			MoveFadeOutToMove,
			SkitFadeIn,
			SkitNormal,
			SkitFadeOutToMove,
			SkitFadeOutToMoveLoad,
			SkitFadeOutToMoveRender,
			SkitFadeOutToSkit,
			SkitFadeOutToSkitLoad,
			SkitFadeOutToSkitRender,
			JustRotate
		}

		public static bool isEcoMode;

		public static bool isLeaving;

		public static bool isShowedInformationByFirst;

		public static bool exists;

		public Camera mainCamera;

		public MyPageCamera myPageCamera;

		public PostEffect mainCameraPostEffect;

		public Camera uiCamera;

		public Camera renderCamera;

		public PostEffect renderCameraPostEffect;

		public MyPageMoveMap moveMap;

		public MyPageSkitMap skitMap;

		public MyPageUICanvas mainCanvas;

		public GameObject moveMapGroundRotationBase;

		public MyPage2dUICanvas main2dCanvas;

		public MyPageTalkCanvas talkCanvas;

		public MyPageObjectsSettings objectsSettings;

		public MyPageLookControl lookControl;

		public MyPageSoundControl soundControl;

		public MyPageMoveMapBgContent moveMapBgContent;

		public GameObject moveMapGroundBase;

		public GameObject moveMapPlayer;

		public GameObject moveMapNhaam;

		public GameObject moveMapExtraChara;

		public MyPageMapCharacters characters;

		public Color[] ambientColors;

		public float updateTime;

		public MyPageResourceNameList resourceNameList;

		public float rotationSpeed;

		public State state;

		public MyPageTutorial tutorial;

		public bool isMoveMapBgLoadedOnStart;

		public bool doMapLoop;

		public bool isSyncLoad;

		[SerializeField]
		private GameObject moveMapWalkRotationBase;

		[HideInInspector]
		public MyPageTransitionController transition;

		[HideInInspector]
		public MyPageMoveMapCharaPosSettings moveMapCharaPosSettings;

		[HideInInspector]
		public MyPageSkitMapCharaPosSettings skitMapCharaPosSettings;

		[HideInInspector]
		public MyPageMapPlaceCharacterSettings myPageMapPlaceCharacterSettings;

		[HideInInspector]
		public GameObject godRayObject;

		[HideInInspector]
		public MyPageBgmSyncSettings bgmSyncSettings;

		[HideInInspector]
		public MyPageBgmSyncSettings.Entry currBgmSyncSetting;

		[HideInInspector]
		public bool useDebugCharaId;

		[HideInInspector]
		public int[] debugCharaIds;

		[HideInInspector]
		public bool isMyPageInfoRequestDone;

		[HideInInspector]
		public bool isMyPageInfoRequestErrer;

		private CanvasGroup mainCanvasCanvasGroup;

		private RawImage fadeoutImage;

		private RenderTexture renderTexture;

		private Material[] godRayMaterials;

		private Vector3 baseRotation;

		private Quaternion initialGroundBaseLocalRotation;

		private Animator playerAnimator;

		private RuntimeAnimatorController playerRuntimeAnimator;

		private State startState;

		private bool isInitDone;

		private bool skipResourceUnload;

		private MyPageBgmSyncSettings.MapSetting mapSetting;

		private UnityEvent backKeyEvent;

		private float walkingSpeed;

		private TouchGuardObject mypageInfoTouchGuard;

		private GameObject waitShowAllPopupTouchGuard;

		public static string prefabDir;

		public const float animationLoopTime = 1.053f;

		public static string commonBgmLabel;

		public bool isUseMeshCollider;

		private const float rangeOfRay = 0.5f;

		private bool isWaitFadeOut;

		private Coroutine setupSkitMapTalkCanvasCoroutine;

		public static readonly string myPageMapPlaceCharacterSettingsPrefabPath;

		private static readonly string myPageInitializeTouchGuardPrefabPath;

		public static bool isOpenGuildPopupAfterEnterScene;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private IEnumerator SummonExchangeCorotine()
		{
			return null;
		}

		private IEnumerator CsSummonExchangeCoroutine()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public void CreateExchangeSummonPopup(SummonPointDataElement spde, UnityAction onPopupEnd)
		{
		}

		public void CsCreateExchangeSummonPopup(int summonId, int csPointTermMaxDate, UnityAction onPopupEnd)
		{
		}

		public void CreateAndroidBackKeyPopup()
		{
		}

		public void OnMyPageInfoSuccess(MypageInfoResponse response)
		{
		}

		private void OnMyPageInfoError(ErrorType errorType, int resultCode)
		{
		}

		private IEnumerator OnMyPageInfoSuccessCoroutine(int is_shop_notification)
		{
			return null;
		}

		public void ReloadOnError()
		{
		}

		public override void StartExitAnimation()
		{
		}

		private IEnumerator ExitAnimationCoroutine()
		{
			return null;
		}

		public void InitEcoMode()
		{
		}

		public void LoadMoveMapGroundScene(string sceneName)
		{
		}

		public void LoadMoveMapBuildingScene(string sceneName, bool isAdditive)
		{
		}

		public void LoadMoveMapWindmillScene(string sceneName)
		{
		}

		public void CreateMoveMap()
		{
		}

		private void SetUpMoveMapGroundSpeed()
		{
		}

		private bool ReplaceMoveMapGroundParent()
		{
			return default(bool);
		}

		private void ReplaceMoveMapBuildParent()
		{
		}

		private void OnSetupMoveMapPlayerComplete()
		{
		}

		private IEnumerator SetNhaamTransform(bool isWalkerEvent, float maincharaScale)
		{
			return null;
		}

		private void LoadCharacterAnimationCompleted(UnityEngine.Object controller)
		{
		}

		private void SetupMoveMapBird()
		{
		}

		private void SetupMoveMapWindmill()
		{
		}

		private void SetupMoveMapRotation()
		{
		}

		private IEnumerator ResetMoveMapCharaShaderCoroutine()
		{
			return null;
		}

		private void UnloadUnusedAssets()
		{
		}

		private IEnumerator UnloadUnusedAssetsCoroutine()
		{
			return null;
		}

		private void SetupPlayerAnimation()
		{
		}

		private IEnumerator SetupMoveMapTalkCanvasCoroutine()
		{
			return null;
		}

		private IEnumerator SetupGodRayCoroutine()
		{
			return null;
		}

		private void SetupMoveMapNhaam(Action onComplete)
		{
		}

		private void SetupMoveMapPlayer(Action onComplete)
		{
		}

		private void SetupMoveMapExtraChara(Action onComplete)
		{
		}

		private void TurnOffPlayerCollider()
		{
		}

		public void SetAmbientColor(int index, Color color)
		{
		}

		public void ResetMoveMapRotation()
		{
		}

		public void DestroyMoveMap()
		{
		}

		public void DestroySkitMap()
		{
		}

		public void LoadSkitMapScene(int skitMapIndex)
		{
		}

		public void CreateSkitMap()
		{
		}

		private IEnumerator ResetSkitmapCharaShaderCoroutine()
		{
			return null;
		}

		private void SetupSkitMapTalkCanvas()
		{
		}

		private IEnumerator SetupSkitMapTalkCanvasCoroutine()
		{
			return null;
		}

		private void SetupSkitMapTalkNormal()
		{
		}

		private void SetupSkitMapTalkEvent()
		{
		}

		private void EnableRenderCamera()
		{
		}

		private void Update()
		{
		}

		private void MoveMapLoadWait()
		{
		}

		private void SkitMapLoadWait()
		{
		}

		private void MoveMapCreate()
		{
		}

		private void SkitMapCreate()
		{
		}

		private void AdjustMoveMapBuildingRotation()
		{
		}

		private void JustRotate()
		{
		}

		private void MoveFadeIn()
		{
		}

		private void MoveNormal()
		{
		}

		private IEnumerator WaiteChangeStateMoveMapFadeOut()
		{
			return null;
		}

		private void AdjustPlayerHigh()
		{
		}

		private void MoveFadeOutToSkitRender()
		{
		}

		private void MoveFadeOutToSkitLoad()
		{
		}

		private void MoveFadeOutToSkit()
		{
		}

		private void MoveFadeOutToMoveRender()
		{
		}

		private void MoveFadeOutToMoveLoad()
		{
		}

		public void LoadMoveMapBg()
		{
		}

		private void LoadMoveMap()
		{
		}

		private void MoveFadeOutToMove()
		{
		}

		private void SkitFadeIn()
		{
		}

		private void SkitNormal()
		{
		}

		private IEnumerator WaiteChangeStateSkitMapFadeOut()
		{
			return null;
		}

		private void SkitFadeOutToMoveRender()
		{
		}

		private void SkitFadeOutToMoveLoad()
		{
		}

		private void SkitFadeOutToMove()
		{
		}

		private void SkitFadeOutToSkitRender()
		{
		}

		private void SkitFadeOutToSkitLoad()
		{
		}

		private void SkitFadeOutToSkit()
		{
		}

		public void OnTouchAreaTouched()
		{
		}

		public override void OnPopupOpened()
		{
		}

		public override void OnPopupClosed()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		public bool IsMoveMapOnGoing()
		{
			return default(bool);
		}

		private void CheckMeshCollider()
		{
		}

		public void ReloadObjectsSettings()
		{
		}
	}
}
