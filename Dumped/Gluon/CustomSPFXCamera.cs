using SPFX;
using UnityEngine;

namespace Gluon
{
	public class CustomSPFXCamera : FixedImageEffect
	{
		[SerializeField]
		protected bool _forceRenderLayerBefore;

		[SerializeField]
		protected bool _forceDrawLayerAfter;

		[SerializeField]
		protected eDrawLayer[] _drawLayerBeforeRT;

		[SerializeField]
		protected eDrawLayer[] _drawLayerAfterRT;

		[SerializeField]
		[Header("Other Flags")]
		private bool _requireBillboardCamera;

		private bool _requiredBillboardCamera;

		[SerializeField]
		private bool _rotVDirectX;

		[SerializeField]
		private bool _rotVMetal;

		[SerializeField]
		public Material _reverseVerticalCopyMaterial;

		protected Camera _refCamera;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected override void Awake()
		{
		}

		protected virtual void Initialize()
		{
		}

		protected void RenderTarget(bool enableRenderBeforeRT, bool enableRenderAfterRT, RenderTextureData srcRTData, bool isEnableDepthTexture)
		{
		}

		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}
	}
}
