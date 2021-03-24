/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickCustomPointGaugeUI2 : CharaGimmickBaseGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _gaugeBgAnimRt;
		[SerializeField]
		protected RectTransform _gaugeBgAnimAdjustRt;
		[SerializeField]
		protected RectTransform _iconAnimRt;
		[SerializeField]
		protected RectTransform[] _gaugeMaxRt;
		[SerializeField]
		protected InGameGaugeUISpriteRenderer _gauge;
		[SerializeField]
		protected SpriteRenderer _gaugeBgAnimImage;
		[SerializeField]
		protected SpriteRenderer _iconImage;
		[SerializeField]
		protected SpriteRenderer _iconAnimImage;
		[Header]
		[SerializeField]
		protected Vector2 _countAnimScale;
		[SerializeField]
		protected float _countAnimTime;
		[SerializeField]
		protected Vector2 _gaugeAnimScale;
		[SerializeField]
		protected Vector2 _gaugeAnimScale2;
		[SerializeField]
		protected float[] _gaugeAnimStepScaleX;
		[SerializeField]
		protected float _gaugeAnimTime;
		[SerializeField]
		protected float _gaugeIntervalTime;
		[SerializeField]
		protected float _gaugeAnimTime2;
		[SerializeField]
		[Tooltip]
		protected float _gaugeInsideWaitTime;
		[SerializeField]
		[Tooltip]
		protected float _gaugeHidePostTime;
		[SerializeField]
		[Tooltip]
		protected Color[] _gaugeColor;
		protected VisibleUIObject _visible;
		protected Sequence _seqIconAnim;
		protected Sequence _seqGaugeAnim;
		protected float _lastRate;
		protected int _requestCP;
		protected int _requestMaxCP;
		protected float _requestRate;
		protected float _requestDelay;
		protected bool _requestImmediate;
		protected bool _requestPlayAnim;
		protected bool _maxPlayAnim;
		protected float _maximumValuePerGauge;
		protected bool[] _animPlayed;
		protected Action<int, int, int> _onStepoverCallback;
		protected int _stepoverCallbackArgeIndex;
		protected int _lastGaugeIndex;
	
		// Constructors
		public CharaGimmickCustomPointGaugeUI2();
	
		// Methods
		public static CharaGimmickCustomPointGaugeUI2 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize(CharacterBase chara);
		private void OnDestroy();
		public override void FastUpdate();
		public override void Show();
		public override void Hide();
		public override bool IsVisible();
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false);
		private void UpdateGaugeValue();
		private void UpdateGaugeAnimParam();
		private void UpdateGaugeStatus(float gaugeRate, float targetGaugeRate);
		private float GetSequenceRemainTime(ref Sequence seq);
		public override void SetGaugeAnimCompleteCallback(int idx, Action<int, int, int> onComplete);
		protected void PlayIconAnim();
		protected void PlayGaugeBgAnim();
		protected void SetAlpha(ref SpriteRenderer sprite, float alpha);
		private void SetIconImage(Material mat);
		public override int GetGaugeType();
		public override float GetGaugeMoveTime();
		[CompilerGenerated]
		private void _SetGaugeAnimCompleteCallback_b__48_0(float gauegLastValue);
		[CompilerGenerated]
		private void _PlayIconAnim_b__49_0();
		[CompilerGenerated]
		private void _PlayGaugeBgAnim_b__50_0();
	}
}
