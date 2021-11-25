using System;
using System.Collections.Generic;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class SkillOverChargeGaugeUI : FastUpdateMonoBehaviour
	{
		[Serializable]
		private class LoopColorData
		{
			[SerializeField]
			[Tooltip("é\u0096\u008bå§\u008bã\u0082«ã\u0083©ã\u0083¼")]
			private Color _startColor;

			[SerializeField]
			[Tooltip("çµ\u0082äº\u0086ã\u0082«ã\u0083©ã\u0083¼")]
			private Color _endColor;

			public Color startColor => default(Color);

			public Color endColor => default(Color);

			public LoopColorData(Color start, Color end)
			{
			}
		}

		[Serializable]
		private class LoopFadeData
		{
			[SerializeField]
			[Tooltip("é\u0096\u008bå§\u008bã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089")]
			private float _startFade;

			[SerializeField]
			[Tooltip("çµ\u0082äº\u0086ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089")]
			private float _endFade;

			public float startFade => default(float);

			public float endFade => default(float);

			public LoopFadeData(float start, float end)
			{
			}
		}

		[SerializeField]
		[Header("component")]
		[Tooltip("æ\u009c\u0080å¤§ã\u0083\u0081ã\u0083£ã\u0083¼ã\u0082\u00b8æ\u0099\u0082ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _maxChargeAnimRt;

		[SerializeField]
		[Tooltip("ã\u0083©ã\u0082¤ã\u0083³ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _lineRootRt;

		[SerializeField]
		[Tooltip("ã\u0083©ã\u0082¤ã\u0083³ä\u00b8\u008aé\u0083\u00a8ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _lineTopRt;

		[SerializeField]
		[Tooltip("ã\u0083©ã\u0082¤ã\u0083³ä\u00b8\u008bé\u0083\u00a8ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _lineBottomRt;

		[SerializeField]
		[Tooltip("ã\u0083©ã\u0082¤ã\u0083³ã\u0081®å\u0085\u0083ç\u00b4\u00a0æ\u009d\u0090ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _originLineRt;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0083\u009eã\u0082¹ã\u0082\u00afã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _gaugeMaskRt;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _gaugeSprite;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®æ¼\u0094å\u0087ºç\u0094»å\u0083\u008fï¼\u0088ã\u0082«ã\u0083©ã\u0083¼å¤\u0089æ\u009b\u00b4ç\u0094\u00a8ï¼\u0089")]
		private SpriteRenderer _maxGaugeEffectSprite;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®æ¼\u0094å\u0087ºç\u0094»å\u0083\u008fï¼\u0088ã\u0083«ã\u0083¼ã\u0083\u0097ã\u0082¢ã\u0083\u008bã\u0083¡ç\u0094\u00a8ï¼\u0089")]
		private SpriteRenderer _maxGaugeEffectSprite2;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®æ¼\u0094å\u0087ºç\u0094»å\u0083\u008fï¼\u0088ã\u0082·ã\u0083³ã\u0082°ã\u0083«ã\u0082¢ã\u0083\u008bã\u0083¡ç\u0094\u00a8ï¼\u0089")]
		private SpriteRenderer _maxGaugeEffectSprite3;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ¼\u0094å\u0087ºç\u0094»å\u0083\u008f")]
		private SpriteRenderer _maxGaugeFrameEffectSprite;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®ã\u0082°ã\u0083©ã\u0083\u0087ã\u0083¼ã\u0082·ã\u0083§ã\u0083³æ¼\u0094å\u0087ºç\u0094»å\u0083\u008f")]
		private SpriteRenderer _maxGaugeGradationEffectSprite;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082µã\u0083\u0096ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082«ã\u0083©ã\u0083¼")]
		private Color[] _subGaugeColor;

		[SerializeField]
		[Tooltip("æ¼\u0094å\u0087ºã\u0082«ã\u0083©ã\u0083¼")]
		private Color[] _effectColor;

		[SerializeField]
		[Tooltip("ã\u0082°ã\u0083©ã\u0083\u0087ã\u0083¼ã\u0082·ã\u0083§ã\u0083³æ¼\u0094å\u0087ºã\u0082«ã\u0083©ã\u0083¼")]
		private Color[] _gradationEffectColor;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ¼\u0094å\u0087ºã\u0083«ã\u0083¼ã\u0083\u0097ã\u0082«ã\u0083©ã\u0083¼")]
		private LoopColorData[] _frameEffectLoopColor;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®ã\u0082µã\u0083\u0096ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0083«ã\u0083¼ã\u0083\u0097ã\u0082«ã\u0083©ã\u0083¼")]
		private LoopColorData _maxGaugeSubGaugeLoopColor;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®æ¼\u0094å\u0087ºã\u0083«ã\u0083¼ã\u0083\u0097ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089")]
		private LoopFadeData _maxGaugeEffectLoopFade;

		private RectTransform _maxGaugeEffectRt;

		private RectTransform _maxGaugeEffectRt2;

		private RectTransform _maxGaugeEffectRt3;

		private RectTransform _maxGaugeFrameEffectRt;

		private RectTransform _maxGaugeGradationEffectRt;

		private VisibleUIObject _rootVisible;

		private List<RectTransform> _lineRtList;

		private Sequence _seqMaxGauge;

		private Sequence _seqMaxSubGauge;

		private int _divisionNum;

		private int _lineNum;

		private int _skillIndex;

		private int _effectPhaseIndex;

		private float _gaugeRate;

		private float _maxSubGaugeRate;

		public void Initialize(int skillIndex)
		{
		}

		private void OnDestroy()
		{
		}

		public void SetupLine()
		{
		}

		public void SetupLine(int divisionNum)
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetLineNum(CharacterBase chara)
		{
		}

		public void SetLineNum(int divisionNum)
		{
		}

		public void SetGaugeRate(int phase, int phaseSp, int phaseConsumeSp, bool isPlayAnim = true, bool isForce = false)
		{
		}

		private void SetGaugeRate(float rate, bool isPlayAnim = true, bool isForce = false)
		{
		}

		private bool IsMomentMaxGauge(float rate)
		{
			return default(bool);
		}

		private bool IsMomentMaxSubGauge(float rate)
		{
			return default(bool);
		}

		private bool IsMomentStepOverSubGauge(float rate)
		{
			return default(bool);
		}

		public void ApplyGaugeColor()
		{
		}

		public void ApplyEffectColor()
		{
		}

		public void ApplyLineVisible()
		{
		}

		public void SetVisible(bool b)
		{
		}

		public bool IsVisible(bool b = false)
		{
			return default(bool);
		}

		public void PlayMaxGauge()
		{
		}

		public void PlayMaxSubGauge(bool isMaxGauge)
		{
		}

		public void OnUpdateMaxGauge(float t)
		{
		}
	}
}
