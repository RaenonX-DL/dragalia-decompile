using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class InGameSimpleGaugeUI : FastUpdateMonoBehaviour
	{
		private enum BaseGaugeState
		{
			Normal,
			Max
		}

		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private SpriteRenderer _baseGaugeImage;

		[SerializeField]
		[Header("resource")]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®ç\u008a¶æ\u0085\u008bã\u0081«å\u0090\u0088ã\u0082\u008fã\u0081\u009bã\u0081¦ã\u0082¹ã\u0083\u0097ã\u0083©ã\u0082¤ã\u0083\u0088ã\u0082\u0092å\u0089²ã\u0082\u008aå½\u0093ã\u0081¦ã\u0082\u008bã\u0081\u008b")]
		private bool _useGaugeSprite;

		[SerializeField]
		[Tooltip("0:é\u0080\u009aå\u00b8\u00b8, 1:Max")]
		private Sprite[] _gaugeSprite;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0083\u0099ã\u0083¼ã\u0082¹ã\u0082«ã\u0083©ã\u0083¼")]
		private Color _baseGaugeColor;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color _maxGaugeColor;

		[SerializeField]
		[Tooltip("å\u0088\u009dæ\u009c\u009fã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8å\u0089²å\u0090\u0088")]
		private float _initialValue;

		[SerializeField]
		[Tooltip("å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093(s)")]
		private float _waitTime;

		[SerializeField]
		[Tooltip("å·®å\u0088\u0086ç§»å\u008b\u0095æ\u0099\u0082é\u0096\u0093(s/å¹\u0085)")]
		private float _diffMoveTime;

		[SerializeField]
		[Tooltip("9ã\u0082¹ã\u0083©ã\u0082¤ã\u0082¹æ\u009c\u0089å\u008a¹ã\u0083\u0095ã\u0083©ã\u0082°\næ\u009c\u0089å\u008a¹ï¼\u009awidth/heightã\u0082\u0092ä½¿ç\u0094\u00a8\nç\u0084¡å\u008a¹ï¼\u009alocalScaleã\u0081®x/yã\u0082\u0092ä½¿ç\u0094\u00a8")]
		private bool _isNineSlice;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®ç§»å\u008b\u0095æ\u0096¹\ntrueï¼\u009awidth/xã\u0081®å\u0080¤ã\u0082\u0092æ\u0093\u008dä½\u009c\nfalseï¼\u009aheight/yã\u0081®å\u0080¤ã\u0082\u0092æ\u0093\u008dä½\u009c")]
		private bool _isMoveHorizontal;

		private VisibleUIObject _visible;

		private RectTransform _baseGaugeImageRt;

		private Vector2 _baseGaugeOriginalSize;

		private float _targetGaugeRate;

		private float _lastBaseGaugeRate;

		private float _waitRemainTime;

		private bool _lossMoving;

		private bool _gainMoving;

		private bool _isAlphaGauge;

		public Action<float> OnCompleteAnim
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		private bool UpdateWaitTime(float t)
		{
			return default(bool);
		}

		private void SetBaseGaugeRate(float rate, bool isForce = false)
		{
		}

		private float GetBaseGaugeRate()
		{
			return default(float);
		}

		private void SetBaseGaugeSprite(BaseGaugeState type)
		{
		}

		private void SetBaseGaugeColor(BaseGaugeState type)
		{
		}

		public void SetGaugeRate(float rate, bool immediate, float waitTime = 0f)
		{
		}

		public float GetGaugeRate()
		{
			return default(float);
		}

		public bool IsGaugeMax()
		{
			return default(bool);
		}

		public bool IsGaugeEmpty()
		{
			return default(bool);
		}

		public void Visible(bool value)
		{
		}

		public void SetWaitTime(float time)
		{
		}

		public void SetBaseGaugeColor(Color color)
		{
		}

		public void SetMaxGaugeColor(Color color)
		{
		}

		public float GetGaugeMoveTime()
		{
			return default(float);
		}

		private bool CopyMaterialForAlphaGauge(ref SpriteRenderer image, out bool isAlphaGauge)
		{
			return default(bool);
		}
	}
}
