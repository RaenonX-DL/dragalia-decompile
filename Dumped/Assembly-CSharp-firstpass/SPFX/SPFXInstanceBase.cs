/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	[DisallowMultipleComponent]
	public abstract class SPFXInstanceBase : MonoBehaviour
	{
		// Fields
		public static OnLoadResourceDirectEvent LoadResourceDirectEvent;
		public static OnLoadResourceEvent LoadResourceEvent;
		public static OnUnloadResourceEvent UnloadResourceEvent;
		private uint m_ShowFlags;
		[Header]
		[HideInInspector]
		[SerializeField]
		private string m_FilePath;
		[HideInInspector]
		[SerializeField]
		private TextAsset m_VfxbAsset;
		[HideInInspector]
		[SerializeField]
		private byte[] NameUTF8;
		[SerializeField]
		private Texture[] Textures;
		[HideInInspector]
		public bool IsLoadedBinaryInformation;
		[HideInInspector]
		public string CullType;
		[HideInInspector]
		public int LifeLength;
		[HideInInspector]
		public bool BinderValid;
		[HideInInspector]
		public uint TriggerValid;
		[HideInInspector]
		public int[] TriggerLifeLength;
		[HideInInspector]
		public string[] TriggerName;
		[Tooltip]
		public bool IsSharedResource;
		[Header]
		[Tooltip]
		public eTransformType TransformType;
		[Tooltip]
		public bool IgnoreTransform;
		[Header]
		[Tooltip]
		public eDrawLayer DrawLayer;
		[Tooltip]
		public Color Color;
		[Range]
		[Tooltip]
		public float Opacity;
		[Range]
		[Tooltip]
		public int DrawPriority;
		[Range]
		[Tooltip]
		public float PlaySpeed;
		[Tooltip]
		public int StartFrame;
		[Range]
		[Tooltip]
		public float DepthBiasOffset;
		[Range]
		[Tooltip]
		public float DepthBiasScale;
		[Header]
		[Tooltip]
		public bool IsLoadOnAwake;
		[Tooltip]
		public bool IsAutoRun;
		[Tooltip]
		public bool IsLoop;
		[Tooltip]
		public bool IsAutoRelease;
		[Tooltip]
		public eUpdateStopAtHideControlType UpdateStopAtHideControlType;
		[Header]
		[Tooltip]
		public int UniqueParam;
		[Header]
		[Tooltip]
		public Transform TargetTransform;
		[Tooltip]
		public Vector3 TargetTransformOffset;
		[Header]
		[Tooltip]
		public bool IsViewCulling;
		[Tooltip]
		public float BoundingRadius;
		[Header]
		[Tooltip]
		public bool IsAdditionalTransform;
		[Tooltip]
		public Vector3 AdditionalScale;
		[Tooltip]
		public Vector3 AdditionalRotate;
		[Tooltip]
		public Vector3 AdditionalToraslate;
		[Header]
		[Range]
		[Tooltip]
		public float FogInfluence;
		[Header]
		[Tooltip]
		public Transform[] PolylineManyPointBind;
		[Tooltip]
		public Vector3 PolylineManyPointRotate;
		private int LastKickTrigger;
		public OnLoadStartEvent LoadStartEvent;
		public OnLoadedEvent LoadedEvent;
		public OnPlayStartededEvent PlayedEvent;
		public OnPlayEndedEvent StoppedEvent;
		private ePlayingStatus m_PlayingStatus;
		private eRequestStatus m_RequestStatus;
		private SPFXPluginInterface m_RefPlugin;
		private GameObject m_RefGameObject;
		private Transform m_RefTransform;
		private IntPtr m_InstanceHandle;
		private uint m_SystemMemory;
		private uint m_VideoMemory;
		private float[] m_WorldMatrix;
		private float[] m_TargetWorldMatrix;
		private bool m_IsPlayStarted;
		private bool m_IsPlayEnded;
		private bool m_IsPause;
		private bool m_IsForceTransformUpdate;
		private int m_KickRequestTriggerCount;
		private int[] m_KickRequestTriggers;
		private uint m_KickedTriggerFlags;
		private int m_CurrentLayer;
		private eDrawLayer m_CurrentDrawLayer;
		private int m_CurrentDrawPriority;
		private float m_CurrentSpeed;
		private float m_CurrentDepthBiasOffset;
		private float m_CurrentDepthBiasScale;
		private float m_CurrentFogInfluence;
		private float m_CurrentR;
		private float m_CurrentG;
		private float m_CurrentB;
		private float m_CurrentA;
		[Header]
		public UnityEvent<CLIPEVENTDATA> ClipCallEventCallback;
		public UnityEvent<SOUNDDATA> SoundPlayCallback;
		public UnityEvent<POSITIONNOTIFICATION_DATA> PositionNotificationCallback;
	
		// Properties
		public bool PlayStarted { get; }
		public bool PlayEnded { get; }
		public bool Playing { get; }
		public bool Pausing { get; }
		public bool Loaded { get; }
		public bool LoadError { get; }
		public uint ShowFlags { get; }
		public bool IsShow { get; }
		public string FilePath { get; }
		public TextAsset VfxbAsset { get; }
		public int GetLastKickTrigger { get; }
		public uint TextAssetSize { get; }
	
		// Nested types
		public delegate byte[] OnLoadResourceDirectEvent(string Name);
	
		public delegate TextAsset OnLoadResourceEvent(string Name);
	
		public delegate void OnUnloadResourceEvent(string Name, TextAsset Asset);
	
		public enum eUpdateStopAtHideControlType
		{
			UseBinaryDataSetting = 0,
			ForceOn = 1
		}
	
		public enum eTransformType
		{
			Complete = 0,
			IgnoreRotate = 1,
			IgnoreRotateXZ = 2,
			IgnoreScale = 3,
			IgnoreRotateAndScale = 4,
			IgnoreRotateXZAndScale = 5
		}
	
		public delegate void OnLoadStartEvent(GameObject This);
	
		public delegate void OnLoadedEvent(GameObject This);
	
		public delegate void OnPlayStartededEvent(GameObject This);
	
		public delegate void OnPlayEndedEvent(GameObject This);
	
		private enum ePlayingStatus
		{
			Empty = 0,
			Playing = 1,
			Loading = 2,
			LoadErr = 3,
			Standby = 4
		}
	
		private enum eRequestStatus
		{
			None = 0,
			Play = 1,
			Stop = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal TextAsset _.cctor_b__167_0(string Name);
			internal void _.cctor_b__167_1(string Name, TextAsset Asset);
		}
	
		// Constructors
		protected SPFXInstanceBase();
		static SPFXInstanceBase();
	
		// Methods
		private void OnPlay();
		private void OnStop();
		public Texture[] GetTextures();
		private byte[] GetNameUTF8(string Name);
		public void UnloadTextAsset();
		public void SetVfxbTextAsset(string Path, TextAsset Asset);
		public void SetTexture(List<Texture> Datas);
		public void SwapTexture(string Name, Texture Source);
		public void SwapTexture(int Index, Texture Source);
		private void CreateTextureInfo(out IntPtr[] Infos);
		public void Load();
		public void Unload();
		public void ForceResetHandle();
		private void InitRef();
		protected void Awake();
		protected void Start();
		protected void OnEnable();
		protected void OnDisable();
		protected void OnDestroy();
		protected void Update();
		public void EditorUpdate();
		public void OnLateUpdate();
		private void KickTriggerImpl();
		private void PlayImpl();
		private void StopImpl();
		private void SetWorldMatrix(Matrix4x4 mWorld);
		private void ComputeWorldMatrix(Matrix4x4 mWorld);
		private void UpdateWorldMatrixImpl();
		private void UpdateWorldMatrix();
		private void UpdateTargetWorldMatrix();
		private float GetPlaySpeed();
		private void UpdateAllParameters();
		private void UpdateParameters();
		public void RequireForceTransformUpdate();
		public bool Play();
		public bool Stop();
		public bool Pause();
		private uint GetTriggerFlag(int Trigger);
		public bool IsKickedTrigger(int Trigger);
		public bool KickTrigger(int Trigger);
		public void SetLabelTexture(string Label, Texture Texture);
		public bool SetShow(int Index, bool IsShow);
		public bool IsPlaying();
		public bool IsPause();
		public bool IsLoadError();
		public bool IsLoaded();
		public uint GetUsingSystemMemory();
		public uint GetUsingVideoMemory();
		public void LoadBinaryInformation(TextAsset OverwriteVfxbAsset);
		public void OnClipCall(CLIPEVENTDATA Data);
		public void OnSoundPlay(SOUNDDATA Data);
		public void OnPositionNotify(POSITIONNOTIFICATION_DATA Data);
	}
}
