using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class ImageEffectPlayer : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡ã\u0081®å\u0087¦ç\u0090\u0086ã\u0081\u008cå¿\u0085è¦\u0081ã\u0081\u008b")]
		private bool enableAlpha;

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private List<ImageEffectBase> _imageEffectList;

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®å®\u009fé\u009a\u009bã\u0081®å\u0087¦ç\u0090\u0086ã\u0081§ä½¿ã\u0081\u0086ã\u0081\u009fã\u0082\u0081ã\u0081®ã\u0083\u00afã\u0083¼ã\u0082\u00afã\u0083ªã\u0082¹ã\u0083\u0088")]
		private List<ImageEffectBase> _imageEffectWorkList;

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®å¤\u0096é\u0083\u00a8å\u008f\u0082ç\u0085§ã\u0083¢ã\u0083¼ã\u0083\u0089")]
		private PostEffectExternalMode[] _postEffectExternalModeArray;

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081ç\u0094\u00a8ã\u0081®ã\u0082³ã\u0083³ã\u0083\u009dã\u0083¼ã\u0083\u008dã\u0083³ã\u0083\u0088ã\u0081®ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private ImageEffectAttachment[] _imageEffectAttachmentArray;

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0082³ã\u0083\u0094ã\u0083¼ç\u0094\u00a8ã\u0081®ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«")]
		private Material material;

		private Camera _cacheCamera;

		private const int IMAGEEFFECT_SORTSCALE = 100;

		private const float OUTLINE_FOV_BASE = 30f;

		public bool AddImageEffect(ImageEffectBase imageEffectBase)
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPreRender()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
