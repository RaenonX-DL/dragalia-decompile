using System;
using UnityEngine;

namespace SPFX
{
	public class SPFXCamera : MonoBehaviour
	{
		public Light TargetLight;

		public float SceneLightScale;

		public float SceneAmbientScale;

		public int TargetSize;

		private int CurrentTargetSize;

		public int CopyTargetSizeRate;

		private bool RequiredBillboardCamera;

		public bool RequireBillboardCamera;

		public bool EnableFramebufferFx;

		public bool EnableProjectionMap;

		public eDrawLayer[] DrawLayersBefore;

		public eDrawLayer[] DrawLayersAfter;

		private Camera RefCamera;

		private RenderTexture RenderTarget;

		private RenderTexture RenderTargetCopy;

		private IntPtr RenderTargetDepthPtr;

		private IntPtr RenderTargetCopyPtr;

		private Camera CameraChild;

		public Material ColorCopyMaterial;

		public Material ReverseColorCopyMaterial;

		protected SPFXCamera()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ReleaseRenderTarget()
		{
		}

		private void UpdateRenderTarget()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPreRender()
		{
		}

		private void OnPostRender()
		{
		}
	}
}
