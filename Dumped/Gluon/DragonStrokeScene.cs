using System;
using System.Collections;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class DragonStrokeScene : SceneBase
	{
		[SerializeField]
		[Header("HttpGreenLight")]
		public GameObject httpGreenLight;

		[SerializeField]
		[Header("Camera")]
		public GameObject cameraRoot;

		public Camera mainCamera;

		public Camera renderTargetCamera;

		public Vector3 defaultCameraPosition;

		public Vector3 defaultCameraRotation;

		[SerializeField]
		[Header("CameraSettings")]
		public Vector3 contactCameraPosition;

		public Vector3 contactCameraRotation;

		public Vector3 actionCameraPosition;

		public Vector3 actionCameraRotation;

		public Vector3 noDragonCameraPosition;

		public Vector3 noDragonCameraRotation;

		private const float noDragonCameraDistance = 14f;

		public Vector3 firstCameraPosition;

		public Vector3 firstCameraRotation;

		public Vector3 animCameraLastPos;

		public Vector3 animCameraLastPos2;

		public float cameraMoveTime;

		[SerializeField]
		[Header("Node")]
		public Transform uiTopNode;

		public Transform world3DNode;

		public Transform dragonNode;

		public Transform effectNode;

		public Transform godrayNode;

		[SerializeField]
		[Header("Gyro")]
		public GyroControl gyroControl;

		public PettingUnitShaderSettings unitShaderSettings;

		private const float fadeTime = 0.5f;

		private const float defaultWhiteInTime = 1f;

		private const int tutorialDragonId = 20040301;

		private DateTime recoverGetTime;

		public const string prefabPath = "Prefabs/OutGame/DragonContact/";

		public const string animationPath = "Animations/OutGame/DragonContact/";

		public const string dragonAssetPath = "DragonContact/Setting";

		public const string cameraAssetPath = "DragonContact/CameraSetting/";

		public const int dragonRandomSelectRange = 5;

		private readonly string mainCanvasPath;

		private DragonStrokeMain strokeMain;

		private readonly string main2dCanvasPath;

		public DragonStroke2DCanvas main2dCanvas;

		private Coroutine loadBGCoroutine;

		private bool wasMultiTouchEnabled;

		private TouchGuardObject sceneEnterTouchGuardObject;

		public static string GetMotionFilePath(int dragonID, int decoModelId = -1)
		{
			return null;
		}

		public static string GetContactAssetPath(int dragonID)
		{
			return null;
		}

		public DateTime GetRecoverGetTime()
		{
			return default(DateTime);
		}

		public void ResetRecoverGetTime()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private IEnumerator WatiUntilSceneLoadedCorotine()
		{
			return null;
		}

		private IEnumerator WatiUntilSceneLoadedCorotine2D()
		{
			return null;
		}

		private void OnTryLeavingThroughMenu(UnityAction onCheckDone)
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private IEnumerator LoadBGCoroutine()
		{
			return null;
		}

		private void OnInitReadyRequestHttp()
		{
		}

		private IEnumerator OnEnterScene()
		{
			return null;
		}

		public void OnChangedBackgroundShaderParameter()
		{
		}

		private void LoadCommonResources()
		{
		}

		public void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void StartExitAnimation()
		{
		}

		public void OnPushBackButton()
		{
		}

		public static string GetDragonStageInfo()
		{
			return null;
		}

		private void ApiDragonGetContactDataRequest()
		{
		}

		private void ApiOnSuccess(DragonGetContactDataResponse res)
		{
		}

		private void OnErrorDragonGetContactDataRequest(ErrorType errorType, int resultCode)
		{
		}

		public void ApiDragonPresentRequest(int dragonID, int itemID)
		{
		}

		private void ApiOnSuccess(DragonSendGiftResponse res)
		{
		}

		private void OnErrorDragonPresentRequest(ErrorType errorType, int resultCode)
		{
		}

		public override void OnPresentReceived()
		{
		}

		public static int DecideDragonID()
		{
			return default(int);
		}

		private void StartTutorial()
		{
		}

		private IEnumerator DragonContactTutorialCoroutine()
		{
			return null;
		}
	}
}
