using UnityEngine;

namespace Gluon
{
	public class RenderTextureToScreenCamera : MonoBehaviour
	{
		public RenderTexture MainRenderTexture;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
