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
	public class CharaGimmickCustomPointGaugeUI : CharaGimmickBaseGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _gaugeBgAnimRt;
		[SerializeField]
		protected RectTransform _iconAnimRt;
		[SerializeField]
		protected InGameGaugeUISpriteRenderer _gauge;
		[SerializeField]
		protected SpriteRenderer _gaugeBgImage;
		[SerializeField]
		protected SpriteRenderer _iconImage;
		[SerializeField]
		protected SpriteRenderer _gaugeBgAnimImage;
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
		protected Color _deactiveColor;
		protected VisibleUIObject _visible;
		protected Sequence _seqIconAnim;
		protected Sequence _seqGaugeAnim;
		protected float _requestRate;
		protected float _requestDelay;
		protected bool _requestImmediate;
		protected int _lastAppearanceType;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public Action<int> onComplete;
			public int idx;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _SetGaugeAnimCompleteCallback_b__0(float gauegLastValue);
		}
	
		// Constructors
		public CharaGimmickCustomPointGaugeUI();
	
		// Methods
		public static CharaGimmickCustomPointGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize(CharacterBase chara);
		private void OnDestroy();
		public override void FastUpdate();
		public override void Show();
		public override void Hide();
		public override bool IsVisible();
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false);
		private void UpdateGaugeValue();
		private float GetSequenceRemainTime(ref Sequence seq);
		public override void SetGaugeAnimCompleteCallback(int idx, Action<int> onComplete);
		protected void PlayIconAnim();
		protected void PlayGaugeBgAnim();
		protected void SetAlpha(ref SpriteRenderer sprite, float alpha);
		private void SetIconImage(Material mat);
		public override int GetGaugeType();
		public override float GetGaugeMoveTime();
		public override void ChangeAppearance(int type, bool isForce = false);
		protected void ChangeAppearance(bool active);
		protected void SetColor(ref SpriteRenderer sprite, Color color);
		[CompilerGenerated]
		private void _PlayIconAnim_b__36_0();
		[CompilerGenerated]
		private void _PlayGaugeBgAnim_b__37_0();
	}
}
