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
	public class CharaGimmickCustomPointGaugeUI4 : CharaGimmickBaseGaugeUI
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
		protected float _gaugeAnimTime;
		[SerializeField]
		[Tooltip]
		protected float _gaugeInsideWaitTime;
		[SerializeField]
		[Tooltip]
		protected Color _defaultColor;
		[SerializeField]
		[Tooltip]
		protected Color _enhancedColor;
		protected VisibleUIObject _visible;
		protected Sequence _seqIconAnim;
		protected Sequence _seqGaugeAnim;
		protected float _requestRate;
		protected float _requestDelay;
		protected bool _requestImmediate;
		protected int _lastAppearanceType;
	
		// Constructors
		public CharaGimmickCustomPointGaugeUI4();
	
		// Methods
		public static CharaGimmickCustomPointGaugeUI4 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize(CharacterBase chara);
		private void OnDestroy();
		public override void FastUpdate();
		public override void Show();
		public override void Hide();
		public override bool IsVisible();
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false);
		private void UpdateGaugeValue();
		private float GetSequenceRemainTime(ref Sequence seq);
		protected void PlayIconAnim();
		protected void PlayGaugeBgAnim();
		protected void OnUpdateAnim(RectTransform trans, Vector2 fromScale, Vector2 toScale, SpriteRenderer sprite, float fromFade, float toFade, float t);
		private void SetIconImage(Material mat);
		public override int GetGaugeType();
		public override float GetGaugeMoveTime();
		public override void ChangeAppearance(int type, bool isForce = false);
		[CompilerGenerated]
		private void _PlayIconAnim_b__32_1(float t);
		[CompilerGenerated]
		private void _PlayIconAnim_b__32_0();
		[CompilerGenerated]
		private void _PlayGaugeBgAnim_b__33_1(float t);
		[CompilerGenerated]
		private void _PlayGaugeBgAnim_b__33_0();
	}
}
