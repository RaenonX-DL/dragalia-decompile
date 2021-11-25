using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class TweenItemVisualizer : MonoBehaviour
	{
		public enum TweenType
		{
			LocalMoveX,
			LocalMoveY,
			LocalMoveXY,
			SizeDelta,
			ScaleX,
			ScaleY,
			ScaleXY,
			Alpha,
			Rotate,
			ColorOffset
		}

		public enum AttachType
		{
			Append,
			Join,
			Prepend,
			PushSequenceAppend,
			PopSequenceAppend
		}

		[Serializable]
		public class CustomEaseInfo
		{
			public List<Vector2> customEaseParamList;

			private const int cacheBezierLayerDepth = 3;

			private Dictionary<float, Vector2> cachedBezierValues;

			public float customEaseErrorValue
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public CustomEaseInfo MakeClone()
			{
				return null;
			}

			public float BezierFindYFromX(float xTarget, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
			{
				return default(float);
			}

			public Vector2 Bezier(double t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
			{
				return default(Vector2);
			}

			public float CustomEaseFunction(float time, float duration, float overshootOrAmplitude, float period)
			{
				return default(float);
			}
		}

		private class InitialState
		{
			private float x;

			private float y;

			private float w;

			private float h;

			private float scaleX;

			private float scaleY;

			private float alpha;

			private Vector3 angles;

			private UnityEngine.Object recordedItem;

			public void RecordInitialState(TweenItemVisualizer item)
			{
			}

			public void ResetToInitialState(TweenItemVisualizer item)
			{
			}
		}

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

		public void OnResetToInitialState()
		{
		}

		public void RecordInitialState()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void RefineScreenSizeParam()
		{
		}

		public static Tweener DoExposure(Image image, float fromEvBy255, float toEvBy255, float duration, bool isAtlas)
		{
			return null;
		}

		private void DecideTweenEaseFunc()
		{
		}

		public float CustomEaseFunction(float time, float duration, float overshootOrAmplitude, float period)
		{
			return default(float);
		}

		public void SetCutstomEaseTweenHelper(Tweener tw)
		{
		}

		public void AttachTween()
		{
		}
	}
}
