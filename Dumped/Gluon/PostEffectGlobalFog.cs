using System;
using UnityEngine;

namespace Gluon
{
	public class PostEffectGlobalFog : ExtensionImageEffect
	{
		[Serializable]
		public class DistanceFogParam
		{
			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0083¢ã\u0083¼ã\u0083\u0089")]
			public FogMode fogMode;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®è\u0089²")]
			public Color fogColor;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®å\u00af\u0086åº¦")]
			public float density;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®æ¿\u0083ã\u0081\u008fã\u0081ªã\u0082\u008aå§\u008bã\u0082\u0081ã\u0082\u008b")]
			public float start;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081\u008cæ\u009c\u0080ã\u0082\u0082æ¿\u0083ã\u0081\u008fã\u0081ªã\u0082\u008bè·\u009dé\u009b¢")]
			public float end;
		}

		[Serializable]
		public class HeightFogParam
		{
			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®è\u0089²")]
			public Color fogColor;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0083¢ã\u0083¼ã\u0083\u0089")]
			public FogMode fogMode;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®æ\u00b8\u009bè¡°")]
			public float decay;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®é«\u0098ã\u0081\u0095")]
			public float height;

			[SerializeField]
			[Tooltip("ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®æ¿\u0083åº¦")]
			public float concentration;

			[SerializeField]
			[Tooltip("ã\u0082¹ã\u0083\u00a0ã\u0083¼ã\u0082¹ã\u0082\u0092æ\u009c\u0089å\u008a¹ã\u0081«ã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
			public bool enableDensitySmooth;

			[SerializeField]
			[Tooltip("ã\u0082¹ã\u0083\u00a0ã\u0083¼ã\u0082¹ã\u0081®æ\u009c\u0080å°\u008få\u0080¤")]
			public float densitySmoothMin;

			[SerializeField]
			[Tooltip("ã\u0082¹ã\u0083\u00a0ã\u0083¼ã\u0082¹ã\u0081®æ\u009c\u0080å¤§å\u0080¤")]
			public float densitySmoothMax;

			public void Setup(HeightFogParam src)
			{
			}
		}

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081§ä½¿ã\u0081\u0086ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«")]
		private Material _material;

		[SerializeField]
		[Tooltip("è·\u009dé\u009b¢ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0081\u008b")]
		private bool _enableDistanceFog;

		[SerializeField]
		[Tooltip("é«\u0098ã\u0081\u0095ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081\u008cæ\u009c\u0089å\u008a¹ã\u0081\u008b")]
		private bool _enableHeightFog;

		[SerializeField]
		[Tooltip("è·\u009dé\u009b¢ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		private DistanceFogParam _distanceFogParam;

		[SerializeField]
		[Tooltip("é«\u0098ã\u0081\u0095ã\u0083\u0095ã\u0082©ã\u0082°ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		private HeightFogParam _heightFogParam;

		public bool enableDistanceFog
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool enableHeightFog
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public DistanceFogParam distanceFogParam => null;

		public HeightFogParam heightFogParam => null;

		public override DepthTextureMode GetNeedDepthTextureMode()
		{
			return default(DepthTextureMode);
		}

		private void Start()
		{
		}

		private void OnPreRender()
		{
		}

		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}
	}
}
