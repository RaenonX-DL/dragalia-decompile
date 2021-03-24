/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryCharacter
	{
		// Fields
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
		public const float defaultLipSynchIntervalMin = 0.06666667f;
		public const float defaultLipSynchIntervalMax = 0.06666667f;
		public const float defaultLipSynchingTime = 0.1f;
		private const float shakeSecondsWeak = 0.01f;
		private const float shakeSecondsStrong = 0.05f;
		private readonly Vector2 emotionBasePos;
		private const float emotionBaseWidth = 200f;
	
		// Nested types
		public enum PartsIdCategory
		{
			EyeBlink = 0,
			LipSynch = 1
		}
	
		public enum PartsFrameCategory
		{
			Standard = 0,
			Changed = 1,
			DefaultMax = 2
		}
	
		public enum ColorType
		{
			Color = 0,
			ScreenTopColor = 1,
			ScreenBottomColor = 2,
			LastMulColor = 3,
			Max = 4
		}
	
		public struct CompleteData
		{
			// Fields
			public Vector2 position;
			public Vector3 scale;
			public float alpha;
			public float rotate;
			public DifferenceImageController.MaterialParameter matParam;
			public float depth;
	
			// Methods
			public void SetDefault();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public UnityAction nextFrameCallback;
			public UnityAction resetFrameCallback;
			public StoryCharacter __4__this;
			public TweenCallback __9__3;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _SetEyeBlink_b__1();
			internal void _SetEyeBlink_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public UnityAction resetFrameCallback;
			public StoryCharacter __4__this;
			public TweenCallback __9__4;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _SetLipSynch_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_1
		{
			// Fields
			public UnityAction nextFrameCallback;
			public __c__DisplayClass61_0 CS___8__locals1;
			public TweenCallback __9__3;
	
			// Constructors
			public __c__DisplayClass61_1();
	
			// Methods
			internal void _SetLipSynch_b__2();
			internal void _SetLipSynch_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public StoryCharacter __4__this;
			public ColorType type;
			public Color color;
	
			// Constructors
			public __c__DisplayClass63_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_1
		{
			// Fields
			public Color baseColor;
			public __c__DisplayClass63_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass63_1();
	
			// Methods
			internal void _SetFadeColor_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public StoryCharacter __4__this;
			public float value;
	
			// Constructors
			public __c__DisplayClass64_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_1
		{
			// Fields
			public float baseValue;
			public __c__DisplayClass64_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass64_1();
	
			// Methods
			internal void _SetFadeContrast_b__0(float fade);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public StoryCharacter __4__this;
			public float value;
	
			// Constructors
			public __c__DisplayClass65_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_1
		{
			// Fields
			public float baseValue;
			public __c__DisplayClass65_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass65_1();
	
			// Methods
			internal void _SetFadeSaturation_b__0(float fade);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public StoryCharacter __4__this;
			public float value;
	
			// Constructors
			public __c__DisplayClass66_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_1
		{
			// Fields
			public float baseValue;
			public __c__DisplayClass66_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass66_1();
	
			// Methods
			internal void _SetFadeBrightness_b__0(float fade);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public StoryCharacter __4__this;
			public Vector2 basePos;
			public Vector2 addMove;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal void _SetSlideVisible_b__0(float fade);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public StoryCharacter __4__this;
			public Vector2 shakeBasePos;
			public Vector2 shakeAddMove;
			public float shakeSeconds;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal void _PlayShake_b__0(float fade);
			internal void _PlayShake_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public Vector2 shakeBasePos;
			public Vector2 shakeAddMove;
			public StoryCharacter __4__this;
			public float shakeSeconds;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _PlayShakeFixed_b__0(float fade);
			internal void _PlayShakeFixed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0
		{
			// Fields
			public StoryCharacter __4__this;
			public Vector2 basePos;
			public Vector2 moveValue;
			public Tweener tween;
	
			// Constructors
			public __c__DisplayClass75_0();
	
			// Methods
			internal void _SetActionMoveManual_b__0(float value);
			internal void _SetActionMoveManual_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public StoryCharacter __4__this;
			public Vector3 baseScale;
			public Vector3 scaleValue;
			public Tweener tween;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _SetActionScaleManual_b__0(float value);
			internal void _SetActionScaleManual_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0
		{
			// Fields
			public StoryCharacter __4__this;
			public float baseRotate;
			public float rotateValue;
			public Tweener tween;
	
			// Constructors
			public __c__DisplayClass77_0();
	
			// Methods
			internal void _SetActionRotateManual_b__0(float value);
			internal void _SetActionRotateManual_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0
		{
			// Fields
			public StoryCharacter __4__this;
			public float fadeValue;
	
			// Constructors
			public __c__DisplayClass78_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_1
		{
			// Fields
			public float baseFade;
			public Tweener tween;
			public __c__DisplayClass78_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass78_1();
	
			// Methods
			internal void _SetActionFadeManual_b__0(float value);
			internal void _SetActionFadeManual_b__1();
		}
	
		// Constructors
		public StoryCharacter();
	
		// Methods
		public void SetDefault();
		public void SetImageData(string charaId);
		public static string CharaIdToResourceId(string charaId);
		public static string GetImagePath(string resId);
		public void SetFace(int faceId, int faceNum);
		public void KillTweenList(bool complete = false);
		public void SetCompleteData();
		public void SetColorFromMainBackground();
		public void SetPosition(Vector2 position);
		public void SetScale(Vector3 scale);
		public void SetAlpha(float alpha);
		public void SetDepth(float depth);
		public void SetRotate(float rotate);
		public void SetMatParam(DifferenceImageController.MaterialParameter matParam);
		public static DifferenceImageController.MaterialParameter CloneMatParam(DifferenceImageController.MaterialParameter matParam);
		public void SetEyeBlink();
		public void SetLipSynch();
		public void SetCompleteVisible(bool visible);
		public Tweener SetFadeColor(Color color, float fadeSec, ColorType type, float smoothMin, float smoothMax);
		public Tweener SetFadeContrast(float value, float fadeSec);
		public Tweener SetFadeSaturation(float value, float fadeSec);
		public Tweener SetFadeBrightness(float value, float fadeSec);
		public Tweener SetFadeVisible(bool visible, float sec);
		public static Color GetColorForMaterialParam(DifferenceImageController.MaterialParameter matParam, ColorType type);
		public static void SetColorForMaterialParam(DifferenceImageController.MaterialParameter matParam, ColorType type, Color color);
		public Tweener SetSlideVisible(bool visible, float sec, StoryImageManager.SlideDirection direction, bool isFade, float moveValue);
		public void SetShake(bool isStart, bool isVertical, StoryImageManager.StrongType type);
		public void PlayShake(Vector2 shakeBasePos, Vector2 shakeAddMove, float shakeSeconds);
		public void PlayShakeFixed(Vector2 shakeBasePos, Vector2 shakeAddMove, float shakeSeconds);
		public void SetBlink(float seconds, float minAlpha = 0f, float maxAlpha = 1f);
		public void SetActionMoveManual(float sec, Vector2 moveValue, Ease ease);
		public void SetActionScaleManual(float sec, Vector3 scaleValue, Ease ease);
		public void SetActionRotateManual(float sec, float rotateValue, Ease ease);
		public void SetActionFadeManual(float sec, float fadeValue, Ease ease);
		public void ResetActTween();
		private void ClearTweenList(List<Tweener> tweenList);
		public void SetEmotion(int emotionId, int faceNum, Vector2 offset);
		[CompilerGenerated]
		private void _SetEyeBlink_b__60_0();
		[CompilerGenerated]
		private void _SetEyeBlink_b__60_2();
		[CompilerGenerated]
		private void _SetEyeBlink_b__60_4();
		[CompilerGenerated]
		private void _SetLipSynch_b__61_0();
		[CompilerGenerated]
		private void _SetLipSynch_b__61_1();
		[CompilerGenerated]
		private void _SetBlink_b__74_0(float fade);
	}
}
