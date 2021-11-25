using System;
using UnityEngine;

namespace Gluon
{
	public class FortBillboard : CameraTrackingRotator
	{
		[Serializable]
		public struct SpriteRendererAlphaTexPair
		{
			public SpriteRenderer renderer;

			public Texture2D alphaTexture;
		}

		public SpriteRenderer mainRenderer;

		[SerializeField]
		private Texture2D alphaTexture;

		[SerializeField]
		private SpriteRendererAlphaTexPair[] subRenderers;

		private MaterialPropertyBlock materialPropertyBlock;

		private int shaderAlphaTexID;

		public Texture2D ExternalAlphaTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpriteRendererAlphaTexPair[] subRenderArray => null;

		private void Start()
		{
		}
	}
}
