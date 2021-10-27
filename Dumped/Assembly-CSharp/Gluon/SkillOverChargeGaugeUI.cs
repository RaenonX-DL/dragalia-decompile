/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SkillOverChargeGaugeUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _maxChargeAnimRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _lineRootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _lineTopRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _lineBottomRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _originLineRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _gaugeMaskRt;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _gaugeSprite;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _maxGaugeEffectSprite;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _maxGaugeEffectSprite2;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _maxGaugeEffectSprite3;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _maxGaugeFrameEffectSprite;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _maxGaugeGradationEffectSprite;
		[Header]
		[SerializeField]
		[Tooltip]
		private Color[] _subGaugeColor;
		[SerializeField]
		[Tooltip]
		private Color[] _effectColor;
		[SerializeField]
		[Tooltip]
		private Color[] _gradationEffectColor;
		[SerializeField]
		[Tooltip]
		private LoopColorData[] _frameEffectLoopColor;
		[SerializeField]
		[Tooltip]
		private LoopColorData _maxGaugeSubGaugeLoopColor;
		[SerializeField]
		[Tooltip]
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
	
		// Nested types
		[Serializable]
		private class LoopColorData
		{
			// Fields
			[SerializeField]
			[Tooltip]
			private Color _startColor;
			[SerializeField]
			[Tooltip]
			private Color _endColor;
	
			// Properties
			public Color startColor { get; }
			public Color endColor { get; }
	
			// Constructors
			public LoopColorData(Color start, Color end);
		}
	
		[Serializable]
		private class LoopFadeData
		{
			// Fields
			[Range]
			[SerializeField]
			[Tooltip]
			private float _startFade;
			[Range]
			[SerializeField]
			[Tooltip]
			private float _endFade;
	
			// Properties
			public float startFade { get; }
			public float endFade { get; }
	
			// Constructors
			public LoopFadeData(float start, float end);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public SkillOverChargeGaugeUI __4__this;
			public bool isMaxGauge;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _PlayMaxSubGauge_b__1(float t);
			internal void _PlayMaxSubGauge_b__2(float t);
			internal void _PlayMaxSubGauge_b__0();
		}
	
		// Constructors
		public SkillOverChargeGaugeUI();
	
		// Methods
		public void Initialize(int skillIndex);
		private void OnDestroy();
		public void SetupLine();
		public void SetupLine(int divisionNum);
		public override void FastUpdate();
		public void SetLineNum(CharacterBase chara);
		public void SetLineNum(int divisionNum);
		public void SetGaugeRate(int phase, int phaseSp, int phaseConsumeSp, bool isPlayAnim = true, bool isForce = false);
		private void SetGaugeRate(float rate, bool isPlayAnim = true, bool isForce = false);
		private bool IsMomentMaxGauge(float rate);
		private bool IsMomentMaxSubGauge(float rate);
		private bool IsMomentStepOverSubGauge(float rate);
		public void ApplyGaugeColor();
		public void ApplyEffectColor();
		public void ApplyLineVisible();
		public void SetVisible(bool b);
		public bool IsVisible(bool b = false);
		public void PlayMaxGauge();
		public void PlayMaxSubGauge(bool isMaxGauge);
		public void OnUpdateMaxGauge(float t);
		[CompilerGenerated]
		private void _PlayMaxGauge_b__52_0();
	}
}
