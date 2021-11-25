using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class InGameScoringEventCountDownUI : FastUpdateMonoBehaviour
	{
		[Serializable]
		private class TimeData
		{
			public float time;

			[Header("text")]
			public Vector3 leftTextPos;

			public Vector3 rightTextPos;

			public Vector3 leftTextScale;

			public Vector3 rightTextScale;

			[Header("number")]
			public Sprite numberImage_10;

			public Sprite numberImage_01;

			public Vector3 numberPos_10;

			public Vector3 numberPos_01;

			public Vector3 numberScale_10;

			public Vector3 numberScale_01;
		}

		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _adjustRt;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _animRt;

		[SerializeField]
		private SpriteRenderer _numberImage_10;

		[SerializeField]
		private SpriteRenderer _numberImage_01;

		[SerializeField]
		private SpriteRenderer _leftTextImage;

		[SerializeField]
		private SpriteRenderer _rightTextImage;

		[SerializeField]
		[Header("parameter")]
		private TimeData[] _timeDataArray_jp;

		[SerializeField]
		private TimeData[] _timeDataArray_us;

		[SerializeField]
		private TimeData[] _timeDataArray_cn;

		[SerializeField]
		private TimeData[] _timeDataArray_tw;

		private RectTransform _numberImageRt_10;

		private RectTransform _numberImageRt_01;

		private RectTransform _leftTextImageRt;

		private RectTransform _rightTextImageRt;

		private VisibleUIObject _rootVisible;

		private Sequence _seqAnim;

		private float _lastTime;

		public static InGameScoringEventCountDownUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected virtual void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetTime(float time, bool isForce = false, bool isPlayAnim = true)
		{
		}

		private void PlayAnim10()
		{
		}

		private void PlayAnim01()
		{
		}

		private void OnUpdateAnim(float t, float startFade, float endFade, float startPosY, float endPosY)
		{
		}

		private void SetPosY(float value)
		{
		}

		private void SetFade(float value)
		{
		}

		private void SetFade(SpriteRenderer obj, float value)
		{
		}

		private TimeData[] GetTimeDataArray()
		{
			return null;
		}
	}
}
