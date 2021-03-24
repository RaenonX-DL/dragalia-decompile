/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SPFX;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CustomSPFXCamera : FixedImageEffect
	{
		// Fields
		[SerializeField]
		protected bool _forceRenderLayerBefore;
		[SerializeField]
		protected bool _forceDrawLayerAfter;
		[SerializeField]
		protected eDrawLayer[] _drawLayerBeforeRT;
		[SerializeField]
		protected eDrawLayer[] _drawLayerAfterRT;
		[Header]
		[SerializeField]
		private bool _requireBillboardCamera;
		private bool _requiredBillboardCamera;
		[SerializeField]
		private bool _rotVDirectX;
		[SerializeField]
		private bool _rotVMetal;
		[SerializeField]
		public Material _reverseVerticalCopyMaterial;
		protected Camera _refCamera;
	
		// Constructors
		public CustomSPFXCamera();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		protected override void Awake();
		protected virtual void Initialize();
		protected void RenderTarget(bool enableRenderBeforeRT, bool enableRenderAfterRT, RenderTextureData srcRTData, bool isEnableDepthTexture);
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
	}
}
