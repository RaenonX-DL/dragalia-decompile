/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	public class SPFXCameraRT : MonoBehaviour
	{
		// Fields
		private bool RequiredBillboardCamera;
		private Material ActiveColorCopyMaterial;
		private Camera RefCamera;
		public RenderTexture RenderTargetTex;
		public RenderTexture DepthTargetTex;
		private RenderTexture ColorCopyBufferTex;
		private RenderTexture DepthCopyBufferTex;
		private RenderBuffer BackupRT_Color;
		private RenderBuffer BackupRT_Depth;
		private int ActiveRT_SizeX;
		private int ActiveRT_SizeY;
		private int ID_CustomColorTexture;
		private int ID_CustomDepthTexture;
		private int ID_CameraDepthTexture;
		private IntPtr m_ColorTexPtr;
		private IntPtr m_DepthTexPtr;
		[Header]
		public Light TargetLight;
		[Range]
		public float SceneLightScale;
		[Range]
		public float SceneAmbientScale;
		[Header]
		public eDrawLayer[] DrawLayersBefore;
		public eDrawLayer[] DrawLayersAfter;
		[Header]
		public bool RequireBillboardCamera;
		[Header]
		public bool EnableFramebufferFx;
		public bool EnableSoftParticle;
		public bool EnableProjectionMap;
		public bool EnableDepthBufferDecode;
		[Header]
		[Range]
		public int CopyTextureSize;
		[Header]
		public Material ColorCopyMaterial;
		public Material ReverseColorCopyMaterial;
		public Material DepthCopyMaterial;
	
		// Constructors
		public SPFXCameraRT();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		private void OnEnable();
		private void OnDisable();
		private void OnPreRender();
		private void OnPostRender();
		private void DecodeDepthBuffer();
		private void RefreshRenderTextures();
	}
}
