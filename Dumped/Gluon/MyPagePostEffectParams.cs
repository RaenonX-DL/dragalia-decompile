using System;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Gluon
{
	public class MyPagePostEffectParams : MonoBehaviour
	{
		[Serializable]
		public struct WorldIrisSetting
		{
			public Vector3 position;

			public float width;

			public float height;
		}

		[Serializable]
		public struct PointIrisSetting
		{
			public float pointIrisCenterX;

			public float pointIrisCenterY;

			public float pointIrisRadiusX;

			public float pointIrisRadiusY;
		}

		[Header("ã\u0080\u0090å\u009fºæ\u009c¬è\u00a8­å®\u009aã\u0080\u0091")]
		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0083¢ã\u0083¼ã\u0083\u0089")]
		public FilterType filterType;

		public bool isColorCollect;

		public bool isUseFog;

		[Header("ã\u0080\u0090è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0080\u0091")]
		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0081\u008b")]
		public bool isDof;

		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081®æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097")]
		public DofFocalType dofFocalType;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cTransformã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®å\u00af¾è±¡ã\u0081®Transformã\u0082³ã\u0083³ã\u0083\u009dã\u0083¼ã\u0083\u008dã\u0083³ã\u0083\u0088")]
		public Transform dofFocalTransfrom;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cPositionã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®å\u00af¾è±¡ã\u0081®ä½\u008dç½®")]
		public Vector3 dofFocalPosition;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cLengthã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008bã\u0082\u0089ã\u0081®è·\u009dé\u009b¢")]
		public float dofFocalPoint;

		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081®é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082¹ã\u0083\u00a0ã\u0083¼ã\u0082¹ã\u0081®æ»\u0091ã\u0082\u0089ã\u0081\u008bã\u0081\u0095")]
		public float dofSmoothness;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081\u008bã\u0082\u0089ã\u0083\u0094ã\u0083³ã\u0083\u0088ã\u0081\u008cã\u0081\u0082ã\u0081£ã\u0081¦ã\u0081\u0084ã\u0082\u008bå¹\u0085")]
		public float focalSize;

		[Header("ã\u0080\u0090ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0083»ç\u0084¡å\u008a¹")]
		public bool isEnableBloom;

		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0081®ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®å¼·ã\u0081\u0095")]
		public float bloomDofWeight;

		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0082\u0092é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bæ\u0098\u008eã\u0082\u008bã\u0081\u0095ã\u0081®ã\u0081\u0097ã\u0081\u008dã\u0081\u0084å\u0080¤")]
		public float bloomThreshhold;

		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0082\u0092é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bæ\u0098\u008eã\u0082\u008bã\u0081\u0095ã\u0081®å¼·åº¦")]
		public float bloomIntensity;

		[SerializeField]
		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ç\u0094\u00a8ã\u0081®ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®è§£å\u0083\u008fåº¦")]
		public float bloomTextureScale;

		[Header("ã\u0080\u0090ã\u0081\u009dã\u0081®ä»\u0096ã\u0081®è\u00a8­å®\u009aã\u0080\u0091")]
		[Tooltip("ã\u0083\u0087ã\u0083¥ã\u0083\u0095ã\u0083¥ã\u0083¼ã\u0082\u00b8ã\u0083§ã\u0083³æ\u0099\u0082ã\u0081®ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ã\u0081¼ã\u0081\u008bã\u0081\u0097å¹\u0085")]
		public float diffusionBlurSize;

		[Tooltip("æ\u0098\u008eã\u0082\u008bã\u0081\u0095èª¿æ\u0095\u00b4å\u0080¤")]
		public float bright;

		[Tooltip("å½©åº¦èª¿æ\u0095\u00b4å\u0080¤")]
		public float saturation;

		[Tooltip("ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0082¹ã\u0083\u0088èª¿æ\u0095\u00b4å\u0080¤")]
		public float contrast;

		[Header("ã\u0080\u0090ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0080\u0091")]
		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0083¢ã\u0083¼ã\u0083\u0089")]
		public PostFilmMode postFilmMode;

		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®ã\u0082«ã\u0083©ã\u0083¼ã\u0081®å¼·ã\u0081\u0095")]
		public float postFilmPower;

		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®é\u0081©ç\u0094\u00a8ä½\u008dç½®ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector2 postFilmOffsetParam;

		[Tooltip("ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088ã\u0081®å¼·ã\u0081\u0095")]
		public float vignetteIntensity;

		[Tooltip("ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088ã\u0081®æ\u00b8\u009bè¡°å\u0080¤")]
		public float vignetteDecrement;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0090")]
		public Color postFilmColor0;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0091")]
		public Color postFilmColor1;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0092")]
		public Color postFilmColor2;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0093")]
		public Color postFilmColor3;

		[Header("ã\u0080\u0090ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0081©ç\u0094\u00a8ç\u00af\u0084å\u009b²")]
		public float blurArea;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®å¼·åº¦")]
		public float blurPower;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088é\u0081©ç\u0094\u00a8ã\u0081®é«\u0098ã\u0081\u0095ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public float blurOffset;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®å¼·ã\u0081\u0095ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public float blurBaseUp;

		public WorldIrisSetting[] worldIrisSetting;

		public PointIrisSetting[] pointIrisSettings;

		[SerializeField]
		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0099¤å¤\u0096ã\u0081\u0099ã\u0082\u008bã\u0081\u0097ã\u0081\u008dã\u0081\u0084å\u0080¤")]
		public float pointIrisCutout;

		[Tooltip("ã\u0083\u0087ã\u0083\u0090ã\u0083\u0083ã\u0082°ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0081§è¡\u00a8ç¤ºã\u0081\u0097ã\u0081¾ã\u0081\u0099ã\u0080\u0082")]
		public bool isTiltShiftDebug;

		[Header("ã\u0080\u0090ã\u0082¬ã\u0082¦ã\u0082¹ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0080\u0091")]
		[Tooltip("å\u009e\u0082ç\u009b\u00b4æ\u0096¹å\u0090\u0091ã\u0081®ã\u0082¬ã\u0082¦ã\u0082¹ã\u0081®ç²¾åº¦")]
		public GaussType gaussVertical;

		[Tooltip("æ°\u00b4å¹³æ\u0096¹å\u0090\u0091ã\u0081®ã\u0082¬ã\u0082¦ã\u0082¹ã\u0081®ç²¾åº¦")]
		public GaussType gaussHorizon;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ã\u0081¼ã\u0081\u008bã\u0081\u0097ã\u0081®å¼·åº¦")]
		public float lastGaussFilterBlurPower;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ã\u0081¼ã\u0081\u008bã\u0081\u0097å¹\u0085")]
		public float lastGaussFilterBlurSize;

		[Header("ã\u0080\u0090ã\u0083\u0095ã\u0082©ã\u0082°ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®è\u0089²")]
		public Color fogColor;

		[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®ã\u0081\u008bã\u0081\u008bã\u0082\u008aå§\u008bã\u0082\u0081ã\u0082\u008bè·\u009dé\u009b¢")]
		public float fogStartDistance;

		[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®ã\u0082\u0082ã\u0081£ã\u0081\u00a8ã\u0082\u0082æ¿\u0083ã\u0081\u008fã\u0081ªã\u0082\u008bè·\u009dé\u009b¢")]
		public float fogEndDistance;
	}
}
