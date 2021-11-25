using System;
using UnityEngine;

namespace SPFX
{
	public class SPFXCameraRT : MonoBehaviour
	{
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

		[Header("â\u0096\u00a0 Lighting Info")]
		public Light TargetLight;

		public float SceneLightScale;

		public float SceneAmbientScale;

		[Header("â\u0096\u00a0 VFX Draw Layer")]
		public eDrawLayer[] DrawLayersBefore;

		public eDrawLayer[] DrawLayersAfter;

		[Header("â\u0096\u00a0 Billboard Target Camera")]
		public bool RequireBillboardCamera;

		[Header("â\u0096\u00a0 Effect Flags")]
		public bool EnableFramebufferFx;

		public bool EnableSoftParticle;

		public bool EnableProjectionMap;

		public bool EnableDepthBufferDecode;

		[Header("â\u0096\u00a0 Texture Size for Screen Copy")]
		public int CopyTextureSize;

		[Header("â\u0096\u00a0 Materials")]
		public Material ColorCopyMaterial;

		public Material ReverseColorCopyMaterial;

		public Material DepthCopyMaterial;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPreRender()
		{
		}

		private void OnPostRender()
		{
		}

		private void DecodeDepthBuffer()
		{
		}

		private void RefreshRenderTextures()
		{
		}
	}
}
