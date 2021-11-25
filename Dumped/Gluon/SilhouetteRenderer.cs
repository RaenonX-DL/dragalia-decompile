using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class SilhouetteRenderer : MonoBehaviour
	{
		[SerializeField]
		public enum SampleCount
		{
			Sample1 = 1,
			Sample2 = 2,
			Sample4 = 4,
			Sample8 = 8
		}

		[SerializeField]
		private float _silhouetteTextureScale;

		[SerializeField]
		private Color _SilhouetteRimColor;

		[SerializeField]
		private Color _SilhouetteBaseColor;

		[SerializeField]
		private Color _SilhouetteDisableColor;

		[SerializeField]
		private float _SilhouetteRimWidth;

		[SerializeField]
		private float _SilhouetteRimPower;

		private Camera _camera;

		private RenderTexture _renderTexture;

		private Shader _silhouetteBaseShader;

		private bool _enableSilhouette;

		private int _SilhouetteRimColorID;

		private int _SilhouetteBaseColorID;

		private int _SilhouetteRimWidthID;

		private int _SilhouetteRimPowerID;

		private int _SilhouetteTextureID;

		public void SetEnableSilhouette()
		{
		}

		public void SetDisableSilhouette()
		{
		}

		public void SetSilhouetteColor(Color baseColor, [Optional] Color rimColor)
		{
		}

		private void SetShaderGlobalColorParam(Color rimColor, Color baseColor)
		{
		}

		private void CreateRenderTexture()
		{
		}

		private void SetSilhouetteParam()
		{
		}

		private void Start()
		{
		}
	}
}
