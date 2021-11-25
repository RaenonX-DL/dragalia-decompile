using System.Collections.Generic;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public class PostEffect : PostEffectsBase
	{
		private const int BLOOM_DIVIDER = 4;

		private const float BLOOM_WIDTHMOD = 0.5f;

		private const float DEFAULT_SCREEN_LONG = 1280f;

		private const float DEFAULT_SCREEN_SHORT = 720f;

		private const string keywordEnableBloomColor = "ENABLE_BLOOM_COLOR";

		private const string keywordEnableDiffusionColor = "ENABLE_DIFFUSION_COLOR";

		private const string keywordEnableColorAdjustment = "ENABLE_COLOR_ADJUSTMENT";

		private const string keywordEnableLastGaussFilter = "ENABLE_LAST_GAUSSFILTER";

		private CacheCamera _cacheCamera;

		[SerializeField]
		[Header("ã\u0080\u0090ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®æ§\u008bæ\u0088\u0090æ\u0083\u0085å\u00a0±ã\u0080\u0091")]
		[Tooltip("ã\u0083¡ã\u0082¤ã\u0083³ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008bã\u0081©ã\u0081\u0086ã\u0081\u008b")]
		private bool _isMainCamera;

		private PostEffect _mainCameraPostEffectLive3D;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0083¢ã\u0083¼ã\u0083\u0089")]
		private FilterType _filterType;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®ä\u00b8\u008bé\u0099\u0090ã\u0082¿ã\u0082¤ã\u0083\u0097")]
		private FilterUseType _filterLowerLimitType;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®ã\u0083\u008eã\u0083¼ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082\u0092ä½¿ã\u0082\u008fã\u0081ªã\u0081\u0084ã\u0082\u0088ã\u0081\u0086ã\u0081«ã\u0081\u0099ã\u0082\u008b\nToDo:ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®ç®¡ç\u0090\u0086ã\u0081®ä¿®æ­£ã\u0081\u008cå¿\u0085è¦\u0081")]
		private bool _isNoSetNoEffect;

		[SerializeField]
		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0081\u008b")]
		private bool _isEnableDof;

		[SerializeField]
		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0083»ç\u0084¡å\u008a¹")]
		private bool _isEnableBloom;

		[SerializeField]
		[Tooltip("ã\u0083\u0087ã\u0083¥ã\u0083\u0095ã\u0083¥ã\u0083¼ã\u0082\u00b8ã\u0083§ã\u0083³ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0081\u008b")]
		private bool _isEnableDiffusionColor;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0083¡ã\u0083©æ\u0096¹å\u0090\u0091ã\u0081«ã\u0081\u008aã\u0081\u0091ã\u0082\u008bã\u0083\u009dã\u0083ªã\u0082\u00b4ã\u0083³é\u009d¢ã\u0081®ã\u0082«ã\u0083©ã\u0083¼èª¿æ\u0095\u00b4ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0081\u008b")]
		private bool _isEnableColorAdjustment;

		private FilterUseType _filterUseType;

		[SerializeField]
		private PostEffectShaderListData _postEffectShaderListData;

		[SerializeField]
		[Header("ã\u0080\u0090å\u0085±é\u0080\u009aè\u00a8­å®\u009aã\u0081®æ\u0083\u0085å\u00a0±ã\u0080\u0091")]
		private CommonParam _commonParam;

		[SerializeField]
		[Header("ã\u0080\u0090ã\u0082¬ã\u0082¦ã\u0082¹ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®æ\u0083\u0085å\u00a0±ã\u0080\u0091")]
		private GaussFilterParam _gaussFilterParam;

		[SerializeField]
		[Header("ã\u0080\u0090ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		private BloomParam _bloomParam;

		[SerializeField]
		[Header("ã\u0080\u0090è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ç\u0094\u00a8ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		private DepthOfFieldParam _depthOfFieldParam;

		[SerializeField]
		[Header("ã\u0080\u0090ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ç\u0094\u00a8ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		private TiltShiftParam _tiltShiftParam;

		[SerializeField]
		[Header("ã\u0080\u0090ã\u0083\u009dã\u0083ªã\u0082\u00b4ã\u0083³é\u009d¢ã\u0081«å\u00af¾ã\u0081\u0097ã\u0081¦ã\u0081®ã\u0082«ã\u0083©ã\u0083¼ã\u0081®èª¿æ\u0095\u00b4ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		private ColorAdjustmentParam _colorAdjustmentParam;

		[SerializeField]
		[Header("ã\u0080\u0090ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ç\u0094\u00a8ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		private PostFilmParam _postFilmParam;

		[SerializeField]
		[Header("ã\u0080\u0090æ\u009c\u0080çµ\u0082æ\u008f\u008fç\u0094»ã\u0081®ã\u0082¬ã\u0082¦ã\u0082¹ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081«ã\u0081¤ã\u0081\u0084ã\u0081¦ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		private LastGaussFilterParam _lastGaussFilterParam;

		private List<RenderTexture> _renderTextureList;

		private const int pointIrisMaxCount = 8;

		private const int pointIrisParamCount = 4;

		private Vector4[] pointIrisCenterPosition;

		private Vector4[] pointIrisCenterRadius;

		private int[] _PostEffectPropIDPointIrisPosition;

		private int[] _PostEffectPropIDPointIrisRadius;

		private const int PASS_POSTBLOOM_HORIZONGAUSS = 0;

		private const int PASS_POSTBLOOM_VERTICALGAUSS = 1;

		private const int PASS_POSTBLOOM_VERTICALGAUSS_BLOOM = 2;

		private const int PASS_POSTBLOOM_BLIT = 3;

		private const int PASS_POSTDOFBLOOM_HORIZONGAUSS = 0;

		private const int PASS_POSTDOFBLOOM_VERTICALGAUSS = 1;

		private const int PASS_POSTDOFBLOOM_BLOOM = 2;

		private const int PASS_POSTDOFBLOOM_COC_DEBUG = 3;

		private const int PASS_POSTDOFBLOOM_DEPTH_DEBUG = 4;

		private const int PASS_POSTDOFBLOOM_BLIT = 5;

		private const int PASS_POSTTILTSHIFTBLOOM_HORIZONGAUSS = 0;

		private const int PASS_POSTTILTSHIFTBLOOM_VERTICALGAUSS = 1;

		private const int PASS_POSTTILTSHIFTBLOOM_BLOOM = 2;

		private const int PASS_POSTTILTSHIFTBLOOM_DEBUG = 3;

		private const int PASS_POSTTILTSHIFTBLOOM_BLIT = 4;

		private const int PASS_POSTONLYSTANDARDEFFECT_HORIZONGAUSS = 0;

		private const int PASS_POSTONLYSTANDARDEFFECT_VERTICALGAUSS = 1;

		private const int PASS_POSTONLYSTANDARDEFFECT_BLIT = 2;

		public bool isMainCamera
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public FilterType filterType
		{
			get
			{
				return default(FilterType);
			}
			set
			{
			}
		}

		public bool isEnableDof
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isEnableBloom
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isEnableDiffusionColor
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isEnableColorAdjustment
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public CommonParam commonParam => null;

		public GaussFilterParam gaussFilterParam => null;

		public BloomParam bloomParam => null;

		public DepthOfFieldParam depthOfFieldParam => null;

		public TiltShiftParam tiltShiftParam => null;

		public ColorAdjustmentParam colorAdjustmentParam => null;

		public PostFilmParam postFilmParam => null;

		public LastGaussFilterParam lastGaussFilterParam => null;

		public List<RenderTexture> renderTextureList => null;

		public void SetFilterUseType(FilterUseType useType)
		{
		}

		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		public override bool CheckResources()
		{
			return default(bool);
		}

		private void OnEnable()
		{
		}

		private Vector2 CalcScreenRate()
		{
			return default(Vector2);
		}

		private void SetupColorAdjustment(Material material)
		{
		}

		private RenderTexture CreateResizeTempRenderTexture(RenderTexture source, float scale)
		{
			return null;
		}

		private void SetPixelBuff(Material material, float pixelSize, GaussType gauss)
		{
		}

		private void BlitGaussFilter(Material material, RenderTexture source, float blurSize, RenderTexture rt1, GaussType gaussH, int passH, RenderTexture rt2, GaussType gaussV, int passV)
		{
		}

		private void BlitCreateBloom(Material material, RenderTexture source, RenderTexture destination, int pass)
		{
		}

		private void LastGaussBlit(Material material, int pass, RenderTextureData srcRTData, RenderTextureData dstRTData, int horizonGaussPass, int verticaluGaussPass)
		{
		}

		private void BlitDestination(Material material, int pass, RenderTextureData srcRTData, RenderTextureData dstRTData, RenderTexture bloomTex, int horizonGaussPass, int verticaluGaussPass)
		{
		}

		private void PostFilmBlit(RenderTexture source, RenderTexture destination, Material material, int pass = 0)
		{
		}

		private void SetBloomParameter(Material material)
		{
		}

		private void SetDofParameter(Material material)
		{
		}

		public void SetPointIrisSetting(int index, float centerX, float centerY, float radiusX, float radiusY)
		{
		}

		private bool OnRenderImageBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
		{
			return default(bool);
		}

		private bool OnRenderImageDofBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
		{
			return default(bool);
		}

		private bool OnRenderImageTiltShiftBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
		{
			return default(bool);
		}

		private bool OnRenderImageTiltShiftPointIrisBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
		{
			return default(bool);
		}

		private bool OnRenderImageGaussBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
		{
			return default(bool);
		}

		private bool OnRenderImageOnlyStandardEffect(RenderTextureData srcRTData, RenderTextureData dstRTData)
		{
			return default(bool);
		}

		private void OnRenderImageTiltShiftBloomCommon(Material material, RenderTextureData srcRTData, RenderTextureData dstRTData)
		{
		}

		public override DepthTextureMode GetNeedDepthTextureMode()
		{
			return default(DepthTextureMode);
		}

		private void CreatePropertyIDTable()
		{
		}

		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}

		protected override void Awake()
		{
		}

		private void LateUpdateStatusFromMainCamera()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
