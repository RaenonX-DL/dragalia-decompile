using System;
using SPFX;
using UnityEngine;

namespace Gluon
{
	public class CustomSPFXCameraDistortion : FixedImageEffect
	{
		public Material reverseMaterial;

		public eDrawLayer[] drawLayers;

		private Camera refCamera;

		private RenderTexture screenCopy;

		private IntPtr screenCopyPtr;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}
	}
}
