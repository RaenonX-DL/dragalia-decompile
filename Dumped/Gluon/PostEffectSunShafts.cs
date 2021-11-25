using System;
using UnityEngine;

namespace Gluon
{
	public class PostEffectSunShafts : ExtensionImageEffect
	{
		[Serializable]
		public class SunShaftsParam
		{
			public enum SunShaftsShadeMode
			{
				Default,
				Komorebi
			}

			public enum SunShaftsScreenBlendMode
			{
				Screen,
				Add
			}

			[Tooltip("æ\u009c\u0089å\u008a¹ã\u0081\u008b")]
			public bool IsEnable;

			[Tooltip("ã\u0082µã\u0083³ã\u0082·ã\u0083£ã\u0083\u0095ã\u0083\u0088ã\u0081®å\u009fºæº\u0096ã\u0081\u00a8ã\u0081ªã\u0082\u008bä½\u008dç½®ã\u0081®Transform")]
			public Transform SunTransform;

			[Tooltip("ã\u0082µã\u0083³ã\u0082·ã\u0083£ã\u0083\u0095ã\u0083\u0088ã\u0081®å\u009fºæº\u0096ã\u0081\u00a8ã\u0081ªã\u0082\u008bä½\u008dç½®")]
			public Vector3 SunPosition;

			[Tooltip("3ã\u0082·ã\u0083£ã\u0083\u0095ã\u0083\u0088ç\u0094\u00a8ã\u0081®ã\u0083\u0090ã\u0083\u0083ã\u0083\u0095ã\u0082¡ã\u0081®è§£å\u0083\u008fåº¦")]
			public float sunShaftResolutionRate;

			[Tooltip("ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0087ã\u0082£ã\u0083³ã\u0082°ã\u0083¢ã\u0083¼ã\u0083\u0089")]
			public SunShaftsShadeMode sunShaftsShadeMode;

			[Tooltip("ã\u0083\u0096ã\u0083¬ã\u0083³ã\u0083\u0089ã\u0083¢ã\u0083¼ã\u0083\u0089")]
			public SunShaftsScreenBlendMode ScreenBlendMode;

			[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼å\u008d\u008aå¾\u0084")]
			public float SunShaftBlurRadius;

			[Tooltip("å\u0085\u0089æº\u0090ã\u0081®è\u0089²")]
			public Color SunColor;

			[Tooltip("å\u0085\u0089æº\u0090ã\u0081®å¼·ã\u0081\u0095")]
			public float SunPower;

			[Tooltip("å\u0085\u0089æº\u0090ä\u00b8­å¤®ã\u0081®æ\u0098\u008eã\u0082\u008bã\u0081\u0095")]
			public float CenterBrightness;

			[Tooltip("å\u0085\u0089æº\u0090ã\u0081®åº\u0083ã\u0081\u008cã\u0082\u008aè£\u009cæ­£")]
			public float CenterMultiplex;

			[Tooltip("ã\u0082\u00afã\u0083©ã\u0083³ã\u0083\u0097ã\u0081§ç\u00b8\u0081ã\u0081\u008cã\u0081\u008aã\u0081\u008bã\u0081\u0097ã\u0081\u008fã\u0081ªã\u0082\u008bå\u00a0\u00b4å\u0090\u0088ã\u0081«ç\u00b8\u0081ã\u0082\u0092é»\u0092ã\u0081\u008fã\u0081\u0099ã\u0082\u008bã\u0081\u009fã\u0082\u0081ã\u0081®ã\u0083\u0095ã\u0083©ã\u0082°")]
			public bool IsEnabledBorderClear;

			[Tooltip("ã\u0082µã\u0083³ã\u0082·ã\u0083£ã\u0083\u0095ã\u0083\u0088ã\u0081®å¼·ã\u0081\u0095")]
			public float SunShaftIntensity;

			[Tooltip("ã\u0082µã\u0083³ã\u0082·ã\u0083£ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0096\u0093å¼\u0095ã\u0081\u008få¼·ã\u0081\u0095")]
			public float BlackLevel;

			[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®å\u009b\u009eæ\u0095°")]
			public int BlurIterations;

			[NonSerialized]
			public RenderTexture CameraDepthTexture;

			public void Setup(SunShaftsParam src)
			{
			}
		}

		[SerializeField]
		[Tooltip("ã\u0082µã\u0083³ã\u0082·ã\u0083£ã\u0083\u0095ã\u0083\u0088ç\u0094\u00a8ã\u0083\u009eã\u0083\u0086ã\u0082¢ã\u0083ªã\u0082¢ã\u0083«")]
		protected Material _sunShaftsMaterial;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0083ªã\u0082¢ç\u0094\u00a8ã\u0083\u009eã\u0083\u0086ã\u0082¢ã\u0083ªã\u0082¢ã\u0083«")]
		protected Material _simpleClearMaterial;

		[SerializeField]
		private SunShaftsParam _param;

		public SunShaftsParam Param => null;

		public bool IsEnable => default(bool);

		public bool IsUseDepthTexture => default(bool);

		public bool CreateMaterial()
		{
			return default(bool);
		}

		public void ResetDepthTexture()
		{
		}

		private void DrawBorder(RenderTexture dest, Material material)
		{
		}

		private void Start()
		{
		}

		public override DepthTextureMode GetNeedDepthTextureMode()
		{
			return default(DepthTextureMode);
		}

		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}

		public void DestroyMaterial()
		{
		}
	}
}
