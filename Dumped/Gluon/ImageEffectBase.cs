using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class ImageEffectBase : MonoBehaviour
	{
		[SerializeField]
		[Header("ã\u0080\u0090ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®ç®¡ç\u0090\u0086æ\u0083\u0085å\u00a0±ã\u0080\u0091")]
		[Tooltip("ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081\u008cå\u0087¦ç\u0090\u0086ã\u0081\u0099ã\u0082\u008bé\u00a0\u0086ç\u0095ªã\u0082\u0092æ\u008c\u0087å®\u009aã\u0081\u0099ã\u0082\u008bID")]
		private int _imageEffectID;

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®å\u0087¦ç\u0090\u0086ã\u0081®é\u00a0\u0086ç\u0095ªã\u0082\u0092ç®¡ç\u0090\u0086ã\u0081\u0099ã\u0082\u008bã\u0081\u009fã\u0082\u0081ã\u0081®ID")]
		private int _imageEffectSortID;

		[SerializeField]
		[Tooltip("ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®å\u0087¦ç\u0090\u0086ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0081ªã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080LOD")]
		private LodLevel _enableLodLevel;

		public int imageEffectID
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int imageEffectSortID
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public LodLevel enableLodLevel => default(LodLevel);

		public virtual DepthTextureMode GetNeedDepthTextureMode()
		{
			return default(DepthTextureMode);
		}

		public virtual bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}
	}
}
