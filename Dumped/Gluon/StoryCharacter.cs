using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class StoryCharacter
	{
		public enum PartsIdCategory
		{
			EyeBlink,
			LipSynch
		}

		public enum PartsFrameCategory
		{
			Standard,
			Changed,
			DefaultMax
		}

		public enum ColorType
		{
			Color,
			ScreenTopColor,
			ScreenBottomColor,
			LastMulColor,
			Max
		}

		public struct CompleteData
		{
			public Vector2 position;

			public Vector3 scale;

			public float alpha;

			public float rotate;

			public DifferenceImageController.MaterialParameter matParam;

			public float depth;

			public void SetDefault()
			{
			}
		}

		public DifferenceImageController imageCtrl;

		public RectTransform rootRect;

		public CanvasGroup group;

		public CompleteData completeData;

		public List<Tweener> currentTweenList;

		public PartsFrameCategory currentEyeBlinkFrame;

		public PartsFrameCategory currentLipSynchFrame;

		public PartsFrameCategory maxEyeBlinkFrame;

		public PartsFrameCategory maxLipSynchFrame;

		public string characterId;

		public GameObject[] emotion;

		public Tweener shakeTween;

		public StoryImageManager.ShakePhase shakePhase;

		public Tweener blinkTween;

		public float subAlpha;

		public List<Tweener> actMoveTween;

		public List<Tweener> actScaleTween;

		public List<Tweener> actRotateTween;

		public List<Tweener> actFadeTween;

		public Tweener eyeBlinkTween;

		public Tweener lipSynchTween;

		public float eyeBlinkIntervalMin;

		public float eyeBlinkIntervalMax;

		public float eyeBlinkingTime;

		public float lipSynchIntervalMin;

		public float lipSynchIntervalMax;

		public float lipSynchingTime;

		public const char firstDigitCharOfResourceIdForChara = '1';

		public const char firstDigitCharOfResourceIdForDragon = '2';

		public const float slideMoveValue = 100f;

		public const int faceMax = 2;

		public const float defaultEyeBlinkIntervalMin = 2f;

		public const float defaultEyeBlinkIntervalMax = 5f;

		public const float defaultEyeBlinkingTime = 0.05f;

		public const float defaultLipSynchIntervalMin = 71f / (339f * (float)Math.PI);

		public const float defaultLipSynchIntervalMax = 71f / (339f * (float)Math.PI);

		public const float defaultLipSynchingTime = 0.1f;

		private const float shakeSecondsWeak = 0.01f;

		private const float shakeSecondsStrong = 0.05f;

		private readonly Vector2 emotionBasePos;

		private const float emotionBaseWidth = 200f;

		public void SetDefault()
		{
		}

		public void SetImageData(string charaId)
		{
		}

		public static string CharaIdToResourceId(string charaId)
		{
			return null;
		}

		public static string GetImagePath(string resId)
		{
			return null;
		}

		public void SetFace(int faceId, int faceNum)
		{
		}

		public void KillTweenList(bool complete = false)
		{
		}

		public void SetCompleteData()
		{
		}

		public void SetColorFromMainBackground()
		{
		}

		public void SetPosition(Vector2 position)
		{
		}

		public void SetScale(Vector3 scale)
		{
		}

		public void SetAlpha(float alpha)
		{
		}

		public void SetDepth(float depth)
		{
		}

		public void SetRotate(float rotate)
		{
		}

		public void SetMatParam(DifferenceImageController.MaterialParameter matParam)
		{
		}

		public static DifferenceImageController.MaterialParameter CloneMatParam(DifferenceImageController.MaterialParameter matParam)
		{
			return null;
		}

		public void SetEyeBlink()
		{
		}

		public void SetLipSynch()
		{
		}

		public void SetCompleteVisible(bool visible)
		{
		}

		public Tweener SetFadeColor(Color color, float fadeSec, ColorType type, float smoothMin, float smoothMax)
		{
			return null;
		}

		public Tweener SetFadeContrast(float value, float fadeSec)
		{
			return null;
		}

		public Tweener SetFadeSaturation(float value, float fadeSec)
		{
			return null;
		}

		public Tweener SetFadeBrightness(float value, float fadeSec)
		{
			return null;
		}

		public Tweener SetFadeVisible(bool visible, float sec)
		{
			return null;
		}

		public static Color GetColorForMaterialParam(DifferenceImageController.MaterialParameter matParam, ColorType type)
		{
			return default(Color);
		}

		public static void SetColorForMaterialParam(DifferenceImageController.MaterialParameter matParam, ColorType type, Color color)
		{
		}

		public Tweener SetSlideVisible(bool visible, float sec, StoryImageManager.SlideDirection direction, bool isFade, float moveValue)
		{
			return null;
		}

		public void SetShake(bool isStart, bool isVertical, StoryImageManager.StrongType type)
		{
		}

		public void PlayShake(Vector2 shakeBasePos, Vector2 shakeAddMove, float shakeSeconds)
		{
		}

		public void PlayShakeFixed(Vector2 shakeBasePos, Vector2 shakeAddMove, float shakeSeconds)
		{
		}

		public void SetBlink(float seconds, float minAlpha = 0f, float maxAlpha = 1f)
		{
		}

		public void SetActionMoveManual(float sec, Vector2 moveValue, Ease ease)
		{
		}

		public void SetActionScaleManual(float sec, Vector3 scaleValue, Ease ease)
		{
		}

		public void SetActionRotateManual(float sec, float rotateValue, Ease ease)
		{
		}

		public void SetActionFadeManual(float sec, float fadeValue, Ease ease)
		{
		}

		public void ResetActTween()
		{
		}

		private void ClearTweenList(List<Tweener> tweenList)
		{
		}

		public void SetEmotion(int emotionId, int faceNum, Vector2 offset)
		{
		}
	}
}
