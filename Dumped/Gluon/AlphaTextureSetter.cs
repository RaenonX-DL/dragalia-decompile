using System;
using UnityEngine;

namespace Gluon
{
	public class AlphaTextureSetter : MonoBehaviour
	{
		[Serializable]
		public struct SpriteRendererAlphaTexPair
		{
			public SpriteRenderer renderer;

			public Texture2D alphaTexture;
		}

		[SerializeField]
		private SpriteRenderer mainRenderer;

		[SerializeField]
		private Texture2D alphaTexture;

		[SerializeField]
		private SpriteRendererAlphaTexPair[] subRenderers;

		private MaterialPropertyBlock materialPropertyBlock;

		private int shaderAlphaTexID;

		private bool isSetAlphaTex;

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
