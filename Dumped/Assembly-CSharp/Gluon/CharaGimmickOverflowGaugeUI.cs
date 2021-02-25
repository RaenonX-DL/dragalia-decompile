/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickOverflowGaugeUI : CharaGimmickBaseGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _gaugeBgAnimRt;
		[SerializeField]
		protected RectTransform _stockAnimRt;
		[SerializeField]
		protected InGameGaugeUISpriteRenderer _gauge;
		[SerializeField]
		protected SpriteRenderer _stockImage;
		[SerializeField]
		protected SpriteRenderer _baseGaugeImage;
		[SerializeField]
		protected SpriteRenderer _gaugeBgAnimImage;
		[SerializeField]
		protected SpriteRenderer _stockAnimImage;
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
		protected Color _stockNumEmptyColor;
		[SerializeField]
		protected Color _stockNumColor;
		[SerializeField]
		protected Color _stockNumMaxColor;
		[SerializeField]
		protected Color _baseGaugeEmptyColor;
		[SerializeField]
		protected Color _baseGaugeColor;
		[SerializeField]
		protected Color _baseGaugeMaxColor;
		[Header]
		[SerializeField]
		protected Sprite[] _numberSpriteList;
		protected VisibleUIObject _visible;
		protected Sequence _seqCountAnim;
		protected Sequence _seqGaugeAnim;
		protected int _lastValue;
		protected int _lastStockNum;
	
		// Constructors
		public CharaGimmickOverflowGaugeUI();
	
		// Methods
		public static CharaGimmickOverflowGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize(CharacterBase chara);
		private void OnDestroy();
		public override void Show();
		public override void Hide();
		public override bool IsVisible();
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false);
		protected void PlayStockAnim();
		protected void PlayGaugeBgAnim();
		protected void SetAlpha(ref SpriteRenderer sprite, float alpha);
		public override int GetGaugeType();
		public override float GetGaugeMoveTime();
		[CompilerGenerated]
		private void _PlayStockAnim_b__31_0();
		[CompilerGenerated]
		private void _PlayGaugeBgAnim_b__32_0();
	}
}
