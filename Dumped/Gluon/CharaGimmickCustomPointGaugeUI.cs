using System;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickCustomPointGaugeUI : CharaGimmickBaseGaugeUI
	{
		[SerializeField]
		[Header("component")]
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

		[SerializeField]
		[Header("parameter")]
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
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«å¾\u008cã\u0080\u0081ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081\u008cç\u0094»é\u009d¢å\u0086\u0085ã\u0081«æ\u0088»ã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082\u0092è¡\u008cã\u0081\u0086ã\u0081¾ã\u0081§ã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
		protected float _gaugeInsideWaitTime;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®çµ\u0082äº\u0086ä½\u0095ç§\u0092å\u0089\u008dã\u0081«å\u0089\u008dã\u0081«ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082\u0092æ¶\u0088ã\u0081\u0099ã\u0081\u008b")]
		protected float _gaugeHidePostTime;

		[SerializeField]
		[Tooltip("é\u009d\u009eã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		protected Color _deactiveColor;

		protected VisibleUIObject _visible;

		protected Sequence _seqIconAnim;

		protected Sequence _seqGaugeAnim;

		protected float _requestRate;

		protected float _requestDelay;

		protected bool _requestImmediate;

		protected int _lastAppearanceType;

		public static CharaGimmickCustomPointGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected virtual void Initialize(CharacterBase chara)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
		{
		}

		private void UpdateGaugeValue()
		{
		}

		private float GetSequenceRemainTime(ref Sequence seq)
		{
			return default(float);
		}

		public override void SetGaugeAnimCompleteCallback(int idx, Action<int> onComplete)
		{
		}

		protected void PlayIconAnim()
		{
		}

		protected void PlayGaugeBgAnim()
		{
		}

		protected void OnUpdateAnim(RectTransform trans, Vector2 fromScale, Vector2 toScale, SpriteRenderer sprite, float fromFade, float toFade, float t)
		{
		}

		private void SetIconImage(Material mat)
		{
		}

		public override int GetGaugeType()
		{
			return default(int);
		}

		public override float GetGaugeMoveTime()
		{
			return default(float);
		}

		public override void ChangeAppearance(int type, bool isForce = false)
		{
		}

		protected void ChangeAppearance(bool active)
		{
		}

		protected void SetColor(ref SpriteRenderer sprite, Color color)
		{
		}
	}
}
