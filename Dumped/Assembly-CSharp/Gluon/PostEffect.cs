/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[ExecuteAlways]
	[RequireComponent]
	public class PostEffect : PostEffectsBase
	{
		// Fields
		private const int BLOOM_DIVIDER = 4;
		private const float BLOOM_WIDTHMOD = 0.5f;
		private const float DEFAULT_SCREEN_LONG = 1280f;
		private const float DEFAULT_SCREEN_SHORT = 720f;
		private const string keywordEnableBloomColor = "ENABLE_BLOOM_COLOR";
		private const string keywordEnableDiffusionColor = "ENABLE_DIFFUSION_COLOR";
		private const string keywordEnableColorAdjustment = "ENABLE_COLOR_ADJUSTMENT";
		private const string keywordEnableLastGaussFilter = "ENABLE_LAST_GAUSSFILTER";
		private CacheCamera _cacheCamera;
		[Header]
		[SerializeField]
		[Tooltip]
		private bool _isMainCamera;
		private PostEffect _mainCameraPostEffectLive3D;
		[SerializeField]
		[Tooltip]
		private FilterType _filterType;
		[SerializeField]
		[Tooltip]
		private FilterUseType _filterUseType;
		[SerializeField]
		[Tooltip]
		private bool _isNoSetNoEffect;
		[SerializeField]
		[Tooltip]
		private bool _isEnableDof;
		[SerializeField]
		[Tooltip]
		private bool _isEnableBloom;
		[SerializeField]
		[Tooltip]
		private bool _isEnableDiffusionColor;
		[SerializeField]
		[Tooltip]
		private bool _isEnableColorAdjustment;
		[SerializeField]
		private PostEffectShaderListData _postEffectShaderListData;
		[Header]
		[SerializeField]
		private CommonParam _commonParam;
		[Header]
		[SerializeField]
		private GaussFilterParam _gaussFilterParam;
		[Header]
		[SerializeField]
		private BloomParam _bloomParam;
		[Header]
		[SerializeField]
		private DepthOfFieldParam _depthOfFieldParam;
		[Header]
		[SerializeField]
		private TiltShiftParam _tiltShiftParam;
		[Header]
		[SerializeField]
		private ColorAdjustmentParam _colorAdjustmentParam;
		[Header]
		[SerializeField]
		private PostFilmParam _postFilmParam;
		[Header]
		[SerializeField]
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
	
		// Properties
		public bool isMainCamera { get; set; }
		public FilterType filterType { get; set; }
		public FilterUseType filterUseType { get; set; }
		public bool isNoSetNoEffect { get; }
		public bool isEnableDof { get; set; }
		public bool isEnableBloom { get; set; }
		public bool isEnableDiffusionColor { get; set; }
		public bool isEnableColorAdjustment { get; set; }
		public CommonParam commonParam { get; }
		public GaussFilterParam gaussFilterParam { get; }
		public BloomParam bloomParam { get; }
		public DepthOfFieldParam depthOfFieldParam { get; }
		public TiltShiftParam tiltShiftParam { get; }
		public ColorAdjustmentParam colorAdjustmentParam { get; }
		public PostFilmParam postFilmParam { get; }
		public LastGaussFilterParam lastGaussFilterParam { get; }
		public List<RenderTexture> renderTextureList { get; }
	
		// Constructors
		public PostEffect();
	
		// Methods
		private float FocalDistance01(float worldDist);
		public override bool CheckResources();
		private new void OnEnable();
		private Vector2 CalcScreenRate();
		private void SetupColorAdjustment(Material material);
		private RenderTexture CreateResizeTempRenderTexture(RenderTexture source, float scale);
		private void SetPixelBuff(Material material, float pixelSize, GaussType gauss);
		private void BlitGaussFilter(Material material, RenderTexture source, float blurSize, RenderTexture rt1, GaussType gaussH, int passH, RenderTexture rt2, GaussType gaussV, int passV);
		private void BlitCreateBloom(Material material, RenderTexture source, RenderTexture destination, int pass);
		private void LastGaussBlit(Material material, int pass, RenderTextureData srcRTData, RenderTextureData dstRTData, int horizonGaussPass, int verticaluGaussPass);
		private void BlitDestination(Material material, int pass, RenderTextureData srcRTData, RenderTextureData dstRTData, RenderTexture bloomTex, int horizonGaussPass, int verticaluGaussPass);
		private void PostFilmBlit(RenderTexture source, RenderTexture destination, Material material, int pass = 0);
		private void SetBloomParameter(Material material);
		private void SetDofParameter(Material material);
		public void SetPointIrisSetting(int index, float centerX, float centerY, float radiusX, float radiusY);
		private bool OnRenderImageBloom(RenderTextureData srcRTData, RenderTextureData dstRTData);
		private bool OnRenderImageDofBloom(RenderTextureData srcRTData, RenderTextureData dstRTData);
		private bool OnRenderImageTiltShiftBloom(RenderTextureData srcRTData, RenderTextureData dstRTData);
		private bool OnRenderImageTiltShiftPointIrisBloom(RenderTextureData srcRTData, RenderTextureData dstRTData);
		private bool OnRenderImageGaussBloom(RenderTextureData srcRTData, RenderTextureData dstRTData);
		private bool OnRenderImageOnlyStandardEffect(RenderTextureData srcRTData, RenderTextureData dstRTData);
		private void OnRenderImageTiltShiftBloomCommon(Material material, RenderTextureData srcRTData, RenderTextureData dstRTData);
		public override DepthTextureMode GetNeedDepthTextureMode();
		private void CreatePropertyIDTable();
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
		protected override void Awake();
		private void LateUpdateStatusFromMainCamera();
		private void LateUpdate();
	}
}
