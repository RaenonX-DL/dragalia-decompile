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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TweenItemVisualizer : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public TweenSequenceVisualizer starter;
		public TweenType tweenType;
		public Vector3 param;
		public Transform tweenTransform;
		public RectTransform tweenRectTransform;
		public CanvasGroup tweenCanvas;
		public Image tweenImage;
		public AttachType attachType;
		public UnityEvent onComplete;
		public float prependInterval;
		public float duration;
		public Ease easeFunc;
		public CustomEaseInfo customEaseInfo;
		public const int fpsForAnimationDesign = 30;
		public bool isRelative;
		public bool isBeyond360;
		private const float screenSizeValue = 10000f;
		private InitialState initState;
	
		// Nested types
		public enum TweenType
		{
			LocalMoveX = 0,
			LocalMoveY = 1,
			LocalMoveXY = 2,
			SizeDelta = 3,
			ScaleX = 4,
			ScaleY = 5,
			ScaleXY = 6,
			Alpha = 7,
			Rotate = 8,
			ColorOffset = 9
		}
	
		public enum AttachType
		{
			Append = 0,
			Join = 1,
			Prepend = 2,
			PushSequenceAppend = 3,
			PopSequenceAppend = 4
		}
	
		[Serializable]
		public class CustomEaseInfo
		{
			// Fields
			public List<Vector2> customEaseParamList;
			[CompilerGenerated]
			private float _customEaseErrorValue_k__BackingField;
			private const int cacheBezierLayerDepth = 3;
			private Dictionary<float, Vector2> cachedBezierValues;
	
			// Properties
			public float customEaseErrorValue { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public CustomEaseInfo();
	
			// Methods
			public CustomEaseInfo MakeClone();
			public float BezierFindYFromX(float xTarget, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3);
			public Vector2 Bezier(double t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3);
			public float CustomEaseFunction(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		private class InitialState
		{
			// Fields
			private float x;
			private float y;
			private float w;
			private float h;
			private float scaleX;
			private float scaleY;
			private float alpha;
			private Vector3 angles;
			private UnityEngine.Object recordedItem;
	
			// Constructors
			public InitialState();
	
			// Methods
			public void RecordInitialState(TweenItemVisualizer item);
			public void ResetToInitialState(TweenItemVisualizer item);
		}
	
		// Constructors
		public TweenItemVisualizer();
	
		// Methods
		public void OnResetToInitialState();
		public void RecordInitialState();
		private void Awake();
		private void Start();
		private void RefineScreenSizeParam();
		public static Tweener DoExposure(Image image, float fromEvBy255, float toEvBy255, float duration, bool isAtlas);
		private void DecideTweenEaseFunc();
		public float CustomEaseFunction(float time, float duration, float overshootOrAmplitude, float period);
		public void SetCutstomEaseTweenHelper(Tweener tw);
		public void AttachTween();
		[CompilerGenerated]
		private void _AttachTween_b__31_0();
	}
}
