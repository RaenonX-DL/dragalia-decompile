/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ImageEffectCtrlCronos : ImageEffectCtrl
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private Color stopTimeVignetteColor;
		[Header]
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fadeInStopTime;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeFadeInCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeAberrationSizeFadeInCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeVignetteIntensityFadeInCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeVignetteeDecrementFadeInCurve;
		[Header]
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fadeOutStopTime;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeFadeOutCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeAberrationSizeFadeOutCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeVignetteIntensityFadeOutCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve stopTimeVignetteeDecrementFadeOutCurve;
		[Header]
		[SerializeField]
		[Tooltip]
		private Color sceneChangeColor;
		[SerializeField]
		[Tooltip]
		private bool sceneChangeColorIsAdd;
		[Header]
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fadeInChangeSceneTime;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeFilmPowerFadeInCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeHueFadeInCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeSaturationFadeInCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeValueFadeInCurve;
		[Header]
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fadeOutChangeSceneTime;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeFilmPowerFadeOutCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeHueFadeOutCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeSaturationFadeOutCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve sceneChangeValueFadeOutCurve;
		private float _stopTimeFadeTime;
		private float _sceneChangeFadeTime;
		private bool _isStopTimeFadeIn;
		private bool _isSceneChangeFadeIn;
		private ExtensionImageEffectCronos _extensionImageEffectCronos;
		private ExtensionImageEffectChromaticAberration _extensionImageEffectChromaticAberration;
		private ExtensionImageEffectChangeHSV _extensionImageEffectChangeHSV;
	
		// Constructors
		public ImageEffectCtrlCronos();
	
		// Methods
		public float GetStopMaxFadeTime(bool isFadeIn);
		public float GetChangeSceneMaxFadeTime(bool isFadeIn);
		public override void Initialize(CameraGroupCtrl cameraGroupCtrl);
		public void FadeStopTimeEffect(float fadeTime, bool isFadeIn);
		public void FadeSceneChange(float fadeTime, bool isFadeIn);
	}
}
