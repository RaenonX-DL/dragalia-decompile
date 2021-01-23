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
	public class SPFXCamera : MonoBehaviour
	{
		// Fields
		public Light TargetLight;
		[Range]
		public float SceneLightScale;
		[Range]
		public float SceneAmbientScale;
		[Range]
		public int TargetSize;
		private int CurrentTargetSize;
		[Range]
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
	
		// Constructors
		protected SPFXCamera();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		private void ReleaseRenderTarget();
		private void UpdateRenderTarget();
		private void Awake();
		private void OnDestroy();
		private void OnPreRender();
		private void OnPostRender();
	}
}
