using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RawImageWithAlphaBlend : RawImage
	{
		private RenderTexture rtB;

		private RenderTexture rtW;

		private Camera cam;

		private bool isSPFX;

		private bool useBlackBg;

		private const string externalWhiteAlphaTextureMat = "Materials/Common/UIDefaultWithExternalWhiteBGTexture";

		private const string externalBlackAlphaTextureMat = "Materials/Common/UIDefaultWithExternalBlackBGTexture";

		public void InitRenderTexture(string name, int w, int h, Camera cam, bool isSpark = false, bool useBlackBg = false)
		{
		}

		public bool IsExternalAlphaBlendEnabled()
		{
			return default(bool);
		}

		public void EnableExternalAlphaBlend(string nameAlphaRT)
		{
		}

		protected override void OnDestroy()
		{
		}

		public void ReleaseRenderTexture()
		{
		}

		private void Update()
		{
		}
	}
}
