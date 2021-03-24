/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	[DefaultExecutionOrder]
	[DisallowMultipleComponent]
	public class SPFXSystem : MonoBehaviour
	{
		// Fields
		[Tooltip]
		public Material DummyMaterial;
		[Tooltip]
		public Camera ActiveCamera;
		[Tooltip]
		public Color ActiveLightColor;
		[Tooltip]
		public Color ActiveAmbientColor;
		[Tooltip]
		public eTimeUpdateMode TimeUpdateMode;
		[Tooltip]
		public float TimeUpdateFixedStep;
		private static IntPtr RenderingCallbackPtr;
		private static RaycastHit HitInfo;
		private static MATRIX4x4 MainMatrix;
		private static DRAWPARAMETER DrawParameter;
		private static CLIPEVENTDATA ClipEventData;
		private static COLLISIONDATA CollisionData;
		private static SOUNDDATA SoundData;
		private static POSITIONNOTIFICATION_DATA PosNotifyData;
		private static int PluginCameraID;
		private static int PluginCameraIDMask;
		private static int PluginCameraIDUpdate;
		private static int PluginCameraIDOffset;
		private static SPFXSystem m_SPFXSystem;
		private static SPFXPluginInterface m_SPFXPlugin;
		private static bool m_IsNullDevice;
		private static int m_UpdateFrameRate;
		private static float m_TimeScale;
		private static bool m_IsRequireMetalRenderTargetSetting;
		public static float LightColorIntensity;
		public static float AmbientIntensity;
		public static ClipCallEvent ClipCallEventCallback;
		public static CollisionCheckEvent CollisionCheckCallback;
		public static SoundPlayEvent SoundPlayCallback;
		public static PositionNotificationEvent PositionNotificationCallback;
		private static FrustmCallback CalculateFrustumPlanes;
		private static Plane[] FrustumPlanes;
		private static LinkedList<SPFXInstanceBase> Instances;
		private SPFXCameraDebugInfo m_DebugInfoCamera;
		private static List<Camera> CameraStack;
		private static Dictionary<int, SPFXInstanceBase> InstanceDict;
		[CompilerGenerated]
		private static SPFXInstanceBase[] _InstanceArray_k__BackingField;
		private static Vector3 CollisionWork_Origin;
		private static Vector3 CollisionWork_Direction;
		private static Material DrawDummyMaterial;
		private static Vector3 LightDirectionWork;
		private static int m_SDKEnabled;
	
		// Properties
		private SPFXCameraDebugInfo DebugInfoCamera { get; }
		public eDebugInfoType DebugInfoType { get; set; }
		public bool DebugInfoVerticalReverse { get; set; }
		public static uint ResourceLoadingCount { get; }
		private static bool IsGraphicsMultiThreaded { get; }
		private static bool IsReversedZBuffer { get; }
		public static SPFXSystem Instance { get; }
		public static bool IsNullDevice { get; }
		public static SPFXPluginInterface Plugin { get; }
		public static int UpdateFrameRate { get; set; }
		public static float TimeScale { get; set; }
		public static bool IsRequireMetalRenderTargetSetting { get; set; }
		public static SPFXInstanceBase[] InstanceArray { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool IsLowSpecMode { get; set; }
		public static bool SDKEnabled { get; set; }
	
		// Nested types
		private delegate void FrustmCallback(Plane[] planes, Matrix4x4 worldToProjectMatrix);
	
		// Constructors
		protected SPFXSystem();
		static SPFXSystem();
	
		// Methods
		private static void Log(int Size, string Text);
		private static void LogEditor(int Size, string Text);
		public static void ReleaseAll();
		public static void Register(int ID, SPFXInstanceBase Instance);
		public static void UnRegister(int ID, SPFXInstanceBase Instance);
		public static void RegistInstance(SPFXInstanceBase Instance);
		public static void UnRegistInstance(SPFXInstanceBase Instance);
		private static void UpdateInstanceArray();
		public static SPFXInstanceBase GetInstanceFromID(int ID);
		public static void Initialize();
		public static void SetGroundHeight(float Height);
		public static void PushBillboardCamera(Camera camera);
		public static void PopBillboardCamera(Camera camera);
		public static void Reset();
		public static void CreateThis();
		private static string GetShaderBinaryPath();
		public static void LoadPlugin();
		private static void CalculateFrustum();
		private void Awake();
		private void OnDestroy();
		private void LateUpdate();
		private static bool CollisionCheck(ref COLLISIONDATA Data);
		private static void SoundPlay(SOUNDDATA Data);
		private static void ClipCall(CLIPEVENTDATA Data);
		public static void PositionNotification(POSITIONNOTIFICATION_DATA Data);
		public static void UpdateAll(float DeltaTime);
		private static void DummyDraw();
		private static void UpdateAllInstance();
		private static void ExecuteCallbackEvent();
		public static int GetDrawLayerFlag(eDrawLayer[] DrawLayers);
		private static void IssuePluginEvent(int CameraID);
		public static bool TryRenderingAll(Camera TargetCamera, eDrawLayer[] DrawLayers, bool IsProjectionRendering);
		public static bool TryRenderingAll(Camera TargetCamera, int DrawLayerFlags, bool IsProjectionRendering);
		private static void IssuePluginEvent(int CameraID, CommandBuffer Command);
		public static void RenderingAll(Camera TargetCamera, Light TargetLight, IntPtr RenderTexture, IntPtr DepthTexture, bool IsVerticalRotation, eDrawLayer[] DrawLayers, eDebugInfoType DebugInfoType, bool IsProjectionRendering, float SceneLightScale = 1f, float SceneAmbientScale = 1f);
		public static void RenderingAll(Camera TargetCamera, Light TargetLight, IntPtr RenderTexture, IntPtr DepthTexture, bool IsVerticalRotation, int DrawLayerFlags, eDebugInfoType DebugInfoType, bool IsProjectionRendering, float SceneLightScale = 1f, float SceneAmbientScale = 1f);
		public static void RenderingAll(Camera TargetCamera, Light TargetLight, IntPtr RenderTexture, IntPtr DepthTexture, bool IsVerticalRotation, eDrawLayer[] DrawLayers, eDebugInfoType DebugInfoType, bool IsProjectionRendering, float SceneLightScale, float SceneAmbientScale, CommandBuffer Command);
		public static void RenderingAll(Camera TargetCamera, Light TargetLight, IntPtr RenderTexture, IntPtr DepthTexture, bool IsVerticalRotation, int DrawLayerFlags, eDebugInfoType DebugInfoType, bool IsProjectionRendering, float SceneLightScale, float SceneAmbientScale, CommandBuffer Command);
		public static void UpdateViewFrustum(Camera TargetCamera);
		private static void SetupRendering(int CameraID, Camera TargetCamera, Light TargetLight, IntPtr RenderTexture, IntPtr DepthTexture, bool IsVerticalRotation, int DrawLayerFlags, eDebugInfoType DebugInfoType, bool IsProjectionRendering, float SceneLightScale = 1f, float SceneAmbientScale = 1f);
		private static Camera UpdateMainMatrix();
		private static void UpdateLightParameter(Light light, float SceneLightScale, float SceneAmbientScale);
		private static void UpdateViewMatrix(Matrix4x4 matrix);
		private static void UpdateProjMatrix(Matrix4x4 matrix);
		private static void UpdateFrustumPlanes(Plane[] planes);
		private static Camera GetMainCamera();
	}
}
