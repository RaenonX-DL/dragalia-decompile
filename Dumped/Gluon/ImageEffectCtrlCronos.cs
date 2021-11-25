using UnityEngine;

namespace Gluon
{
	public class ImageEffectCtrlCronos : ImageEffectCtrl
	{
		[SerializeField]
		[Header("ã\u0080\u0090æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8å\u0085±é\u0080\u009aè\u00a8­å®\u009aã\u0080\u0091")]
		[Tooltip("ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088ç\u0094\u00a8ã\u0081®ä¹\u0097ç®\u0097è\u0089²")]
		private Color stopTimeVignetteColor;

		[SerializeField]
		[Header("ã\u0080\u0090æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³æ\u0099\u0082ã\u0081®å\u0085\u00a8ä½\u0093ã\u0081®å\u0086\u008dç\u0094\u009fæ\u0099\u0082é\u0096\u0093")]
		private float _fadeInStopTime;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeFadeInCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®è\u0089²å\u008f\u008eå·®ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeAberrationSizeFadeInCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088ã\u0081®å¼·ã\u0081\u0095ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeVignetteIntensityFadeInCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088åº\u0083ã\u0081\u008cã\u0082\u008aã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeVignetteeDecrementFadeInCurve;

		[SerializeField]
		[Header("ã\u0080\u0090æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0099\u0082ã\u0081®å\u0085\u00a8ä½\u0093ã\u0081®å\u0086\u008dç\u0094\u009fæ\u0099\u0082é\u0096\u0093")]
		private float _fadeOutStopTime;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeFadeOutCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®è\u0089²å\u008f\u008eå·®ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeAberrationSizeFadeOutCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088ã\u0081®å¼·ã\u0081\u0095ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeVignetteIntensityFadeOutCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢ç\u0094\u00a8ã\u0081®ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088åº\u0083ã\u0081\u008cã\u0082\u008aã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve stopTimeVignetteeDecrementFadeOutCurve;

		[SerializeField]
		[Header("ã\u0080\u0090ç\u0094»é\u009d¢é\u0081·ç§»ç\u0094\u00a8å\u0085±é\u0080\u009aã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ç\u0094\u00a8ã\u0081®è\u0089²ã\u0082\u0092è\u00a8­å®\u009a")]
		private Color sceneChangeColor;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ç\u0094\u00a8ã\u0081®è\u0089²ã\u0082\u0092å\u008a\u00a0ç®\u0097å\u0090\u0088æ\u0088\u0090ã\u0081«ã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
		private bool sceneChangeColorIsAdd;

		[SerializeField]
		[Header("ã\u0080\u0090ç\u0094»é\u009d¢é\u0081·ç§»ç\u0094\u00a8ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³æ\u0099\u0082ã\u0081®å\u0085\u00a8ä½\u0093ã\u0081®å\u0086\u008dç\u0094\u009fæ\u0099\u0082é\u0096\u0093")]
		private float _fadeInChangeSceneTime;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ç\u0094\u00a8ã\u0081®ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®å¼·ã\u0081\u0095ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeFilmPowerFadeInCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ç\u0094\u00a8ã\u0081®è\u0089²ç\u009b\u00b8ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeHueFadeInCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ç\u0094\u00a8ã\u0081®å½©åº¦ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeSaturationFadeInCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³ç\u0094\u00a8ã\u0081®æ\u0098\u008eåº¦ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeValueFadeInCurve;

		[SerializeField]
		[Header("ã\u0080\u0090ç\u0094»é\u009d¢é\u0081·ç§»ç\u0094\u00a8ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0080\u0091")]
		[Tooltip("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0099\u0082ã\u0081®å\u0085\u00a8ä½\u0093ã\u0081®å\u0086\u008dç\u0094\u009fæ\u0099\u0082é\u0096\u0093")]
		private float _fadeOutChangeSceneTime;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ç\u0094\u00a8ã\u0081®ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®å¼·ã\u0081\u0095ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeFilmPowerFadeOutCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ç\u0094\u00a8ã\u0081®è\u0089²ç\u009b\u00b8ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeHueFadeOutCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ç\u0094\u00a8ã\u0081®å½©åº¦ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeSaturationFadeOutCurve;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ\u0099\u0082ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ç\u0094\u00a8ã\u0081®æ\u0098\u008eåº¦ã\u0081®ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve sceneChangeValueFadeOutCurve;

		private float _stopTimeFadeTime;

		private float _sceneChangeFadeTime;

		private bool _isStopTimeFadeIn;

		private bool _isSceneChangeFadeIn;

		private ExtensionImageEffectCronos _extensionImageEffectCronos;

		private ExtensionImageEffectChromaticAberration _extensionImageEffectChromaticAberration;

		private ExtensionImageEffectChangeHSV _extensionImageEffectChangeHSV;

		public float GetStopMaxFadeTime(bool isFadeIn)
		{
			return default(float);
		}

		public float GetChangeSceneMaxFadeTime(bool isFadeIn)
		{
			return default(float);
		}

		public override void Initialize(CameraGroupCtrl cameraGroupCtrl)
		{
		}

		public void FadeStopTimeEffect(float fadeTime, bool isFadeIn)
		{
		}

		public void FadeSceneChange(float fadeTime, bool isFadeIn)
		{
		}
	}
}
