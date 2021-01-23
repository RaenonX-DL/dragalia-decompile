/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu]
	public class WallHackDetector : ActDetectorBase
	{
		// Fields
		internal const string COMPONENT_NAME = "WallHack Detector";
		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";
		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";
		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";
		private const int SHADER_TEXTURE_SIZE = 4;
		private const int RENDER_TEXTURE_SIZE = 4;
		private readonly Vector3 rigidPlayerVelocity;
		private static int instancesInScene;
		private readonly WaitForEndOfFrame waitForEndOfFrame;
		[SerializeField]
		[Tooltip]
		private bool checkRigidbody;
		[SerializeField]
		[Tooltip]
		private bool checkController;
		[SerializeField]
		[Tooltip]
		private bool checkWireframe;
		[SerializeField]
		[Tooltip]
		private bool checkRaycast;
		[Range]
		[Tooltip]
		public int wireframeDelay;
		[Range]
		[Tooltip]
		public int raycastDelay;
		[Tooltip]
		public Vector3 spawnPosition;
		[Tooltip]
		public byte maxFalsePositives;
		private GameObject serviceContainer;
		private GameObject solidWall;
		private GameObject thinWall;
		private Camera wfCamera;
		private MeshRenderer foregroundRenderer;
		private MeshRenderer backgroundRenderer;
		private Color wfColor1;
		private Color wfColor2;
		private Shader wfShader;
		private Material wfMaterial;
		private Texture2D shaderTexture;
		private Texture2D targetTexture;
		private RenderTexture renderTexture;
		private int whLayer;
		private int raycastMask;
		private Rigidbody rigidPlayer;
		private CharacterController charControllerPlayer;
		private float charControllerVelocity;
		private byte rigidbodyDetections;
		private byte controllerDetections;
		private byte wireframeDetections;
		private byte raycastDetections;
		private bool wireframeDetected;
		[CompilerGenerated]
		private static WallHackDetector _Instance_k__BackingField;
	
		// Properties
		public bool CheckRigidbody { get; set; }
		public bool CheckController { get; set; }
		public bool CheckWireframe { get; set; }
		public bool CheckRaycast { get; set; }
		public static WallHackDetector Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private static WallHackDetector GetOrCreateInstance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _InitDetector_d__78 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public WallHackDetector __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitDetector_d__78(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CaptureFrame_d__83 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public WallHackDetector __4__this;
			private RenderTexture _previousActive_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CaptureFrame_d__83(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		private WallHackDetector();
	
		// Methods
		public static void StartDetection();
		public static void StartDetection(UnityAction callback);
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition);
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives);
		public static void StopDetection();
		public static void Dispose();
		private void Awake();
		protected override void OnDestroy();
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode);
		private void OnLevelLoadedCallback();
		private void FixedUpdate();
		private void Update();
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow);
		protected override void StartDetectionAutomatically();
		protected override void PauseDetector();
		protected override void ResumeDetector();
		protected override void StopDetectionInternal();
		protected override void DisposeInternal();
		private void UpdateServiceContainer();
		[IteratorStateMachine]
		private IEnumerator InitDetector();
		private void StartRigidModule();
		private void StartControllerModule();
		private void StartWireframeModule();
		private void ShootWireframeModule();
		[IteratorStateMachine]
		private IEnumerator CaptureFrame();
		private void StartRaycastModule();
		private void ShootRaycastModule();
		private void StopRigidModule();
		private void StopControllerModule();
		private void StopWireframeModule();
		private void StopRaycastModule();
		private void InitRigidModule();
		private void InitControllerModule();
		private void UninitRigidModule();
		private void UninitControllerModule();
		private bool Detect();
		private static Color32 GenerateColor();
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance);
	}
}
