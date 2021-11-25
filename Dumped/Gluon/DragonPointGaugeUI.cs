using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class DragonPointGaugeUI : FastUpdateMonoBehaviour
	{
		[Serializable]
		protected class GaugeParam
		{
			[SerializeField]
			protected Sprite[] _gaugeSprites;

			[SerializeField]
			protected Color _gaugeColor;

			public Sprite[] gaugeSprites => null;

			public Color gaugeColor => default(Color);
		}

		public enum DispType
		{
			Valid_01,
			Valid_02,
			Invalid
		}

		[SerializeField]
		[Header("component")]
		private InGameButtonGaugeUI _buttonGauge1;

		[SerializeField]
		private InGameButtonGaugeUI _buttonGauge2;

		[SerializeField]
		protected SpriteRenderer _gaugeEffect;

		[SerializeField]
		protected SpriteRenderer _gaugeLineEffect;

		[SerializeField]
		[Header("resource")]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0083ªã\u0082¹ã\u0083\u0088\n  0: æ\u009c\u0089å\u008a¹ï¼\u0088ç«\u009cå\u008c\u0096ä\u00b8\u008då\u008f\u00afï¼\u0089\n  1: æ\u009c\u0089å\u008a¹ï¼\u0088ç«\u009cå\u008c\u0096å\u008f\u00afï¼\u0089\n  2: ç\u0084¡å\u008a¹ï¼\u0088ã\u0082°ã\u0083¬ã\u0083¼ã\u0082¢ã\u0082¦ã\u0083\u0088è¡\u00a8ç¤ºï¼\u0089")]
		protected GaugeParam[] _gaugeParams;

		protected DispType _dispType;

		protected RectTransform _gaugeEffectRt;

		protected Tweener _twGaugeEffect;

		protected Tweener _twGaugeLineEffect;

		protected int _targetGaugeLineEffect;

		protected float _rate;

		protected float _gaugeValue1;

		protected float _gaugeValue2;

		public void Initialize(DispType type)
		{
		}

		public void OnDestroy()
		{
		}

		public void UpdateUI()
		{
		}

		public void SetDispType(DispType type, bool isForce = false)
		{
		}

		public bool SetGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true)
		{
			return default(bool);
		}

		public float GetGaugeRate1()
		{
			return default(float);
		}

		public float GetGaugeRate2()
		{
			return default(float);
		}

		public void StartGaugeEffect()
		{
		}

		protected void OnUpdateEffect(float value)
		{
		}
	}
}
