using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class ExtensionImageEffectCronos : ExtensionImageEffect
	{
		[SerializeField]
		[Tooltip("ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«")]
		private Material _material;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089å\u0080¤")]
		private float _fadeValue;

		private int _propertyToIDFadeValue;

		[SerializeField]
		[Tooltip("HSVå¤\u0089æ\u008f\u009bç\u0094\u00a8ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		private HSVParameterBase _HSVParameter;

		public float fadeValue
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
