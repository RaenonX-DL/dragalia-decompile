using UnityEngine;

namespace Gluon
{
	public class ExtensionImageEffectChromaticAberration : ExtensionImageEffect
	{
		[SerializeField]
		[Tooltip("ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«")]
		private Material _material;

		[SerializeField]
		[Tooltip("è\u0089²å\u008f\u008eå·®ã\u0081®ã\u0082µã\u0082¤ã\u0082º")]
		private float _aberrationSize;

		private int _propertyToIDAberrationSize;

		public float aberrationSize
		{
			set
			{
			}
		}

		private void Awake()
		{
		}

		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}
	}
}
