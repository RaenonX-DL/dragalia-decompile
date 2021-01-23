/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailScene : SceneBase
	{
		// Fields
		public ViewingMode viewingMode;
		public bool isSwitchDragon;
		public int created3DModelId;
		[Header]
		[SerializeField]
		public Transform mainPanelAttach;
		[Header]
		[SerializeField]
		public GameObject unitModelNode;
		public GameObject unitModelNodeBase;
		public GameObject unitViewModelNode;
		public GameObject unitModelCenterNode;
		public Camera render3dCamera;
		[HideInInspector]
		public UnitDetailCanvas detailCanvas;
		[HideInInspector]
		public Viewer2DCanvas viewer2DCanvas;
		[HideInInspector]
		public Viewer3DCanvas viewer3DCanvas;
		[Header]
		[SerializeField]
		public UnitDetailCanvasSetting canvasSetting;
		public Vector3 detailModelPos;
		public float detailModelZoom;
		public float viewerMaxZoom;
		public float viewerMinZoom;
		public float viewer2DMaxZoom;
		public float viewer2DMinZoom;
		public float viewerRotateSpeed;
		public float viewerZoomSpeed;
		[Header]
		[SerializeField]
		public Canvas bgCanvas;
		public UnitDetailUnitShaderSettings unitShaderSettings;
		[Header]
		[SerializeField]
		public Transform flashAttachNode;
		private Vector3 initFlashCameraPosition;
		[HideInInspector]
		public Camera flashCamera;
		public const string prefabDir = "Prefabs/OutGame/UnitDetail/";
		public const string switchEffectFlashPath = "Prefabs/OutGame/UnitDetail/pf_transform_effect";
		public const string mainPanelPrefabPath = "Prefabs/OutGame/UnitDetail/DetailCanvas";
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
	
		// Nested types
		public enum ViewingMode
		{
			Main = 0,
			View2D = 1,
			View3D = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public Action onFinished;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _GoUnitDetailScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public UnitDetailScene __4__this;
			public float fogStart;
			public float fogEnd;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _BackButtonPressed_b__0();
			internal void _BackButtonPressed_b__1(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_1
		{
			// Fields
			public SimpleAnimationButton simpleAnimation;
			public bool oldStopState;
			public __c__DisplayClass49_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass49_1();
	
			// Methods
			internal void _BackButtonPressed_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__49_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _BackButtonPressed_b__49_2();
		}
	
		// Constructors
		public UnitDetailScene();
	
		// Methods
		public static void GoUnitDetailScene(Action onFinished = null);
		private void Awake();
		public void ResetFlashCameraPosition();
		public void SetBGGrayMode(bool isGray);
		private void Start();
		public void OnChangedBackgroundShaderParameter();
		private void InitDetailScene();
		private void OnDestroy();
		public void BackButtonPressed();
		public void DetailCanvasBackButtonPressed();
		public static GameObject LoadWeapon(int baseId, int variationId);
		public void SetupInitPos();
		private void SetupInitPosDragon(int dragonId);
		private int GetDoragonTypeIndex(DragonDataElement dde);
		public void SetupViewerModeParameters();
		private void SetupViewerModeParametersDragon(int id);
		public void SetupModelViewImage(bool enableAlphaBlend, bool kickAnimation = false);
		public void ViewerButtonPressed();
		public void SwitchViewModeButtonPressed();
		public void SwitchTo2DButtonPressed();
		public void SwitchTo3DButtonPressed();
		private void MainPageSwitchTo3DMode();
		private void MainPageSwitchTo2DMode();
		public void SetRenderCameraOffset(UnitDetailModel.UnitDetailType detailType, int masterId);
		public void SetRenderCameraFieldOfView(UnitDetailModel.UnitDetailType detailType, int masterId);
		private void SetRenderCameraFieldOfViewDragon(int id);
		public void ResetViewPosition(bool resetWeapon);
		public bool CanNextCreate3DModel();
		public bool IsChangeDragonCharacter();
		[CompilerGenerated]
		private void _DetailCanvasBackButtonPressed_b__50_0();
		[CompilerGenerated]
		private void _DetailCanvasBackButtonPressed_b__50_1();
	}
}
