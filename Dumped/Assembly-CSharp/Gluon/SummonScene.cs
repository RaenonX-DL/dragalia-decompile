/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonScene : SceneBase
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject world3dRoot;
		[SerializeField]
		private GameObject canvasRoot;
		[Header]
		[SerializeField]
		public EdgeToEdgeFrame edgeToEdgeFrame;
		[Header]
		[SerializeField]
		private GameObject httpGreenLight;
		[Header]
		[SerializeField]
		public GameObject topNode;
		public GameObject stageResultNode;
		public GameObject stage3dNode;
		public GameObject resultOutOfCanvasNode;
		[Header]
		[SerializeField]
		public Canvas canvas;
		[Header]
		[SerializeField]
		public Transform cameraParent;
		public Transform cameraParentDragon;
		[Header]
		[SerializeField]
		public SummonPostEffectSetting postEffectSetting;
		public SummonPostFilmSetting postFilmSetting;
		[Header]
		[SerializeField]
		public Camera bg3dCamera;
		public Camera character3dCamera;
		public Camera shot2CharaWeaponCamera;
		[Header]
		[SerializeField]
		public Camera mainUIStageCamera;
		public GameObject postEffectCameraGO;
		[Header]
		[SerializeField]
		public Camera resultFlashCamera;
		private Vector3 resultFlashCameraInitPosition;
		public SummonUnitShaderSettings unitShaderSettings;
		public KeepStableToTransform bg3dCameraKeepComponent;
		private bool initEnterSceneDone;
		private bool isTutorialRequired;
		public bool isExitStarted;
		private int uiCameraCullingMask;
		private SummonTop topView;
		private bool firstEnterScene;
		private bool fadeOutPrepare;
		private CameraAndImageEffectPlayer mainUIStageCameraEnable;
		private CameraAndImageEffectPlayer charaCameraEnable;
		private CameraAndImageEffectPlayer postEffectFlashCameraEnable;
		private CameraAndImageEffectPlayer shot2CharaWeaponFlashCameraEnable;
		private CameraAndImageEffectPlayer bg3DCameaEnable;
		private CameraAndImageEffectPlayer resultFlashCameraEnable;
		[CompilerGenerated]
		private SummonResult _resultView_k__BackingField;
		[HideInInspector]
		public UnityEvent onBeforeStartExitAnimation;
	
		// Properties
		public SummonResult resultView { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public struct CameraAndImageEffectPlayer
		{
			// Fields
			public bool camera;
			public bool imageEffectPlayer;
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__41_0;
			public static Action __9__57_1;
			public static UnityAction __9__59_2;
			public static UnityAction __9__60_2;
			public static Action __9__60_1;
			public static Action __9__63_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__41_0();
			internal void _Tutorial_1_1_SummonIn_b__57_1();
			internal void _Tutorial_1_1_SummonDone_b__59_2();
			internal void _Tutorial_SummonExchangeStart_b__60_1();
			internal void _Tutorial_SummonExchangeStart_b__60_2();
			internal void _RequestDrawSummon_b__63_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_SummonIn_d__57 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_SummonIn_d__57(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_SelectSummonIn_d__58 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_SelectSummonIn_d__58(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _Tutorial_1_1_SummonDone_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_SummonDone_d__59 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_SummonDone_d__59(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_SummonExchangeStart_d__60 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_SummonExchangeStart_d__60(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadResultView_d__66 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadResultView_d__66(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SummonScene();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		public void ResetResultFlashCameraToInitPosition();
		public void SetMainUIStageCameraCullMask(bool toNothing);
		private void OnPrevSceneExitDone();
		private void OnInitReadyRequestHttp();
		private void OnEnterScene();
		public void OnChangedBackgroundShaderParameter();
		public void RequestSummonTop();
		private void OnRequestSummonTopSuccess(SummonGetSummonListResponse res);
		private void OnRequestSummonTopSuccessCallback();
		private void LoadTopBGView();
		private void SetupCameraForTopView();
		private void SetupCameraForStage();
		private void LoadTopView();
		private void SetupTutorialState();
		private void StartTutorial();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_SummonIn();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_SelectSummonIn();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_SummonDone();
		[IteratorStateMachine]
		private IEnumerator Tutorial_SummonExchangeStart();
		public void OnSummonButton(SummonTopItemData.ButtonType buttonType, int summonId);
		public void OnDrawSummonButtonClicked(SummonTopItemData.ButtonType buttonType, int summonId, bool paidStone, int useMultiSingleTicketCount);
		public void RequestDrawSummon(bool paidStone);
		public void OnRequestSummonRequestSuccess(SummonRequestResponse res);
		public void Tutorial(int id);
		[IteratorStateMachine]
		private IEnumerator LoadResultView();
		private void LoadStageView();
		public void OnStageDone();
		private void DestroyChildren(Transform t);
		public override void StartExitAnimation();
		public override void OnBeforeLeaving();
		public void OnDestroy();
		public override void OnPopupOpened();
		public override void OnPopupClosed();
		public void SetupResultRenderCamera(bool isEnable, RenderTexture bgRenderTexture = null, RenderTexture charaRenderTexture = null);
		public void SetupStageRenderCamera(bool isEnable, RenderTexture shot2CharaWeaponRenderTexture = null);
		public override void OnPresentReceived();
		public void SetOffCamera();
		public void SetOnCamera();
		public void SaveOffCamera(Camera camera, out CameraAndImageEffectPlayer player);
		public void LoadCamera(Camera camera, CameraAndImageEffectPlayer player);
		[CompilerGenerated]
		private void _Start_b__41_1();
		[CompilerGenerated]
		private void _Tutorial_1_1_SummonIn_b__57_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_SelectSummonIn_b__58_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_SummonDone_b__59_0();
		[CompilerGenerated]
		private void _Tutorial_SummonExchangeStart_b__60_0();
		[CompilerGenerated]
		private void _OnSummonButton_b__61_0();
		[CompilerGenerated]
		private void _RequestDrawSummon_b__63_1(ErrorType errorType, int errorCode);
		[CompilerGenerated]
		private void _OnRequestSummonRequestSuccess_b__64_0();
		[CompilerGenerated]
		private void _Tutorial_b__65_0();
		[CompilerGenerated]
		private void _LoadResultView_b__66_0();
		[CompilerGenerated]
		private void _LoadResultView_b__66_1(SummonTopItemData.ButtonType buttonType);
	}
}
