using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickCustomPointGaugeUI4 : CharaGimmickBaseGaugeUI
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
		protected float _gaugeAnimTime;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«å¾\u008cã\u0080\u0081ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081\u008cç\u0094»é\u009d¢å\u0086\u0085ã\u0081«æ\u0088»ã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082\u0092è¡\u008cã\u0081\u0086ã\u0081¾ã\u0081§ã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
		protected float _gaugeInsideWaitTime;

		[SerializeField]
		[Tooltip("é\u0080\u009aå\u00b8\u00b8æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		protected Color _defaultColor;

		[SerializeField]
		[Tooltip("å¼·å\u008c\u0096æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		protected Color _enhancedColor;

		protected VisibleUIObject _visible;

		protected Sequence _seqIconAnim;

		protected Sequence _seqGaugeAnim;

		protected float _requestRate;

		protected float _requestDelay;

		protected bool _requestImmediate;

		protected int _lastAppearanceType;

		public static CharaGimmickCustomPointGaugeUI4 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
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
	}
}
