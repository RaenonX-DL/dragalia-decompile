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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonStrokeScene : SceneBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject httpGreenLight;
		[Header]
		[SerializeField]
		public GameObject cameraRoot;
		public Camera mainCamera;
		public Camera renderTargetCamera;
		public Vector3 defaultCameraPosition;
		public Vector3 defaultCameraRotation;
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
		public Transform uiTopNode;
		public Transform world3DNode;
		public Transform dragonNode;
		public Transform effectNode;
		public Transform godrayNode;
		[Header]
		[SerializeField]
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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public bool effectLoaded;
			public DragonStrokeScene __4__this;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _Start_b__1();
			internal bool _Start_b__2();
			internal void _Start_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__45_0;
			public static Func<bool> __9__47_0;
			public static Func<bool> __9__48_0;
			public static Func<bool> __9__54_2;
			public static Action __9__61_0;
			public static UnityAction __9__72_2;
			public static Action __9__72_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__45_0();
			internal bool _WatiUntilSceneLoadedCorotine_b__47_0();
			internal bool _WatiUntilSceneLoadedCorotine2D_b__48_0();
			internal bool _OnEnterScene_b__54_2();
			internal void _OnPushBackButton_b__61_0();
			internal void _DragonContactTutorialCoroutine_b__72_1();
			internal void _DragonContactTutorialCoroutine_b__72_2();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeScene __4__this;
			private __c__DisplayClass45_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WatiUntilSceneLoadedCorotine_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WatiUntilSceneLoadedCorotine_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WatiUntilSceneLoadedCorotine2D_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WatiUntilSceneLoadedCorotine2D_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _LoadBGCoroutine_b__0();
			internal bool _LoadBGCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBGCoroutine_d__52 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBGCoroutine_d__52(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnEnterScene_d__54 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnEnterScene_d__54(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DragonContactTutorialCoroutine_d__72 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStrokeScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DragonContactTutorialCoroutine_d__72(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DragonStrokeScene();
	
		// Methods
		public static string GetMotionFilePath(int dragonID, int decoModelId = -1);
		public static string GetContactAssetPath(int dragonID);
		public DateTime GetRecoverGetTime();
		public void ResetRecoverGetTime();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType);
		[IteratorStateMachine]
		private IEnumerator WatiUntilSceneLoadedCorotine();
		[IteratorStateMachine]
		private IEnumerator WatiUntilSceneLoadedCorotine2D();
		private void OnTryLeavingThroughMenu(UnityAction onCheckDone);
		public override void OnBeforeLeaving();
		private void OnPrevSceneExitDone();
		[IteratorStateMachine]
		private IEnumerator LoadBGCoroutine();
		private void OnInitReadyRequestHttp();
		[IteratorStateMachine]
		private IEnumerator OnEnterScene();
		public void OnChangedBackgroundShaderParameter();
		private void LoadCommonResources();
		public void OnDisable();
		private void Awake();
		private void OnDestroy();
		public override void StartExitAnimation();
		public void OnPushBackButton();
		public static string GetDragonStageInfo();
		private void ApiDragonGetContactDataRequest();
		private void ApiOnSuccess(DragonGetContactDataResponse res);
		private void OnErrorDragonGetContactDataRequest(ErrorType errorType, int resultCode);
		public void ApiDragonPresentRequest(int dragonID, int itemID);
		private void ApiOnSuccess(DragonSendGiftResponse res);
		private void OnErrorDragonPresentRequest(ErrorType errorType, int resultCode);
		public override void OnPresentReceived();
		public static int DecideDragonID();
		private void StartTutorial();
		[IteratorStateMachine]
		private IEnumerator DragonContactTutorialCoroutine();
		[CompilerGenerated]
		private void _FooterButtonPressed_b__46_0();
		[CompilerGenerated]
		private void _OnTryLeavingThroughMenu_b__49_0();
		[CompilerGenerated]
		private bool _OnEnterScene_b__54_0();
		[CompilerGenerated]
		private void _OnEnterScene_b__54_1();
		[CompilerGenerated]
		private void _DragonContactTutorialCoroutine_b__72_0();
	}
}
