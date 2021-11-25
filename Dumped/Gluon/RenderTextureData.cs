using UnityEngine;

namespace Gluon
{
	public struct RenderTextureData
	{
		public RenderTexture colorTexture;

		public RenderTexture depthTexture;

		public int width => default(int);

		public int height => default(int);

		public RenderTextureData(RenderTexture rt)
		{
		}

		public RenderTextureData(RenderTexture colorRT, RenderTexture depthRT)
		{
		}

		public void SetRenderTarget(bool isSetColor = true)
		{
		}
	}
}
