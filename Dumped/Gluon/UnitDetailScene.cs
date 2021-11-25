using System;
using System.Collections;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class UnitDetailScene : SceneBase
	{
		public enum ViewingMode
		{
			Main,
			View2D,
			View3D
		}

		public ViewingMode viewingMode;

		public bool isSwitchDragon;

		public int created3DModelId;

		[SerializeField]
		[Header("MainPanelAttach")]
		public Transform mainPanelAttach;

		[SerializeField]
		[Header("UnitModel")]
		public GameObject unitModelNode;

		public GameObject unitModelNodeBase;

		public GameObject unitViewModelNode;

		public GameObject unitModelCenterNode;

		public Camera render3dCamera;

		[HideInInspector]
		public UnitDetailCanvas detailCanvas;

		[HideInInspector]
		public AlbumDetailCanvas albumDetailCanvas;

		[HideInInspector]
		public Viewer2DCanvas viewer2DCanvas;

		[HideInInspector]
		public Viewer3DCanvas viewer3DCanvas;

		[SerializeField]
		[Header("ViewerSettings")]
		public UnitDetailCanvasSetting canvasSetting;

		public Vector3 detailModelPos;

		public float detailModelZoom;

		public float viewerMaxZoom;

		public float viewerMinZoom;

		public float viewer2DMaxZoom;

		public float viewer2DMinZoom;

		public float viewerRotateSpeed;

		public float viewerZoomSpeed;

		[SerializeField]
		[Header("BG")]
		public Canvas bgCanvas;

		[SerializeField]
		private GameObject modelBgAttachPoint;

		public UnitDetailUnitShaderSettings unitShaderSettings;

		[SerializeField]
		[Header("Flash")]
		public Transform flashAttachNode;

		private Vector3 initFlashCameraPosition;

		[HideInInspector]
		public Camera flashCamera;

		[HideInInspector]
		public bool isFavoriteButtonPressed;

		[HideInInspector]
		public bool isFromAlbumToUnitDetailGrowth;

		public const string prefabDir = "Prefabs/OutGame/UnitDetail/";

		public const string switchEffectFlashPath = "Prefabs/OutGame/UnitDetail/pf_transform_effect";

		public const string mainPanelPrefabPath = "Prefabs/OutGame/UnitDetail/DetailCanvas";

		public const string albumMainPanelPrefabPath = "Prefabs/OutGame/UnitDetail/AlbumDetailCanvas";

		private BaseCanvasContents baseCanvasContents;

		private const float backButonOffsetY = 6f;

		private UnitDetailModel.UnitDetailType detailType;

		private Vector3 initialRenderCameraLocalPosition;

		private bool wasHeaderGOOff;

		private bool wasFooterGOOff;

		private float prevFogStart;

		private float prevFogEnd;

		public BackButton backButton;

		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;

		public SceneRichShaderData _beforeSceneRichShaderData;

		private UnitDetailModelBg modelBg;

		private const float particleFadeOutDuration = 0.3f;

		private const float particleFadeInDuration = 0.6f;

		public BaseCanvasContents BaseCanvasContents => null;

		public static void GoUnitDetailScene([Optional] Action onFinished)
		{
		}

		private void Awake()
		{
		}

		public void ResetFlashCameraPosition()
		{
		}

		public void SetBGGrayMode(bool isGray)
		{
		}

		private void Start()
		{
		}

		public void OnChangedBackgroundShaderParameter()
		{
		}

		public void ToggleSwitchSubButton(bool value)
		{
		}

		public void EnableFullScreenButton(bool value)
		{
		}

		public CanvasGroup GetModelViewImageCanvasGroup()
		{
			return null;
		}

		private void InitDetailScene()
		{
		}

		private void OnDestroy()
		{
		}

		public void BackButtonPressed()
		{
		}

		private IEnumerator DelayUnloadOptionalScene(float seconds = 0.1f)
		{
			return null;
		}

		private void UnloadOptionalScene()
		{
		}

		public void DetailCanvasBackButtonPressed()
		{
		}

		public static GameObject LoadWeapon(int baseId, int variationId)
		{
			return null;
		}

		public void SetupInitPos()
		{
		}

		private void SetupInitPosDragon(int dragonId)
		{
		}

		private int GetDoragonTypeIndex(DragonDataElement dde)
		{
			return default(int);
		}

		public void SetupViewerModeParameters()
		{
		}

		private void SetupViewerModeParametersDragon(int id)
		{
		}

		public void SetupModelViewImage(bool enableAlphaBlend, bool kickAnimation = false)
		{
		}

		public void ViewerButtonPressed()
		{
		}

		public void SwitchViewModeButtonPressed()
		{
		}

		public void SwitchTo2DButtonPressed()
		{
		}

		public void SwitchTo3DButtonPressed()
		{
		}

		private void MainPageSwitchTo3DMode()
		{
		}

		private void MainPageSwitchTo2DMode()
		{
		}

		public void SetRenderCameraOffset(UnitDetailModel.UnitDetailType detailType, int masterId)
		{
		}

		public void SetRenderCameraFieldOfView(UnitDetailModel.UnitDetailType detailType, int masterId)
		{
		}

		private void SetRenderCameraFieldOfViewDragon(int id)
		{
		}

		private void SetModelBgTransform(UnitDetailModel.UnitDetailType detailType)
		{
		}

		public void ResetViewPosition(bool resetWeapon)
		{
		}

		public bool CanNextCreate3DModel()
		{
			return default(bool);
		}

		public bool IsChangeDragonCharacter()
		{
			return default(bool);
		}
	}
}
