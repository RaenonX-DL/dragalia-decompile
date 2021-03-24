/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		public AlbumDetailCanvas albumDetailCanvas;
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
		[SerializeField]
		private GameObject modelBgAttachPoint;
		public UnitDetailUnitShaderSettings unitShaderSettings;
		[Header]
		[SerializeField]
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
	
		// Properties
		public BaseCanvasContents BaseCanvasContents { get; }
	
		// Nested types
		public enum ViewingMode
		{
			Main = 0,
			View2D = 1,
			View3D = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public Action onFinished;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _GoUnitDetailScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public UnitDetailScene __4__this;
			public float fogStart;
			public float fogEnd;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _BackButtonPressed_b__0();
			internal void _BackButtonPressed_b__1();
			internal void _BackButtonPressed_b__2(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_1
		{
			// Fields
			public SimpleAnimationButton simpleAnimation;
			public bool oldStopState;
			public __c__DisplayClass62_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass62_1();
	
			// Methods
			internal void _BackButtonPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_2
		{
			// Fields
			public SimpleAnimationButton simpleAnimation;
			public bool oldStopState;
			public __c__DisplayClass62_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass62_2();
	
			// Methods
			internal void _BackButtonPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_3
		{
			// Fields
			public TouchGuardObject unitDetailSceneExitTouchGuard;
			public __c__DisplayClass62_0 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass62_3();
	
			// Methods
			internal void _BackButtonPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_4
		{
			// Fields
			public TouchGuardObject unitDetailSceneExitTouchGuard;
			public __c__DisplayClass62_0 CS___8__locals4;
	
			// Constructors
			public __c__DisplayClass62_4();
	
			// Methods
			internal void _BackButtonPressed_b__6();
		}
	
		[CompilerGenerated]
		private sealed class _DelayUnloadOptionalScene_d__63 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnitDetailScene __4__this;
			public float seconds;
			private TouchGuardObject _delayUnloadOptionalSceneTouchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayUnloadOptionalScene_d__63(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
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
		public void ToggleSwitchSubButton(bool value);
		public void EnableFullScreenButton(bool value);
		public CanvasGroup GetModelViewImageCanvasGroup();
		private void InitDetailScene();
		private void OnDestroy();
		public void BackButtonPressed();
		[IteratorStateMachine]
		private IEnumerator DelayUnloadOptionalScene(float seconds = 0.1f);
		private void UnloadOptionalScene();
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
		private void SetModelBgTransform(UnitDetailModel.UnitDetailType detailType);
		public void ResetViewPosition(bool resetWeapon);
		public bool CanNextCreate3DModel();
		public bool IsChangeDragonCharacter();
		[CompilerGenerated]
		private void _DetailCanvasBackButtonPressed_b__65_0();
		[CompilerGenerated]
		private void _DetailCanvasBackButtonPressed_b__65_1();
	}
}
