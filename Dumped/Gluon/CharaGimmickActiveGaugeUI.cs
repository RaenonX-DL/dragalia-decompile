using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickActiveGaugeUI : CharaGimmickBaseGaugeUI
	{
		[SerializeField]
		[Header("component")]
		protected RectTransform _rootRt;

		[SerializeField]
		protected RectTransform[] _iconAnimRt;

		[SerializeField]
		protected RectTransform[] _gaugeAnimRt;

		[SerializeField]
		protected InGameGaugeUISpriteRenderer[] _gauge;

		[SerializeField]
		protected SpriteRenderer[] _iconAnimImage;

		[SerializeField]
		protected SpriteRenderer[] _gaugeAnimImage;

		[SerializeField]
		protected SpriteRenderer[] _gaugeAnimImage2;

		[SerializeField]
		[Header("parameter")]
		protected Vector2 _tweenIconSize;

		[SerializeField]
		protected float _tweenIconTime;

		[SerializeField]
		protected Vector2 _tweenGaugeSize;

		[SerializeField]
		protected float _tweenGaugeTime;

		protected VisibleUIObject _visible;

		protected Sequence[] _seqIconAnim;

		protected Sequence[] _seqGaugeAnim;

		protected float[] _lastGaugeValue;

		public static CharaGimmickActiveGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected virtual void Initialize(CharacterBase chara)
		{
		}

		protected void OnDestroy()
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

		protected void PlayAnimIcon(int idx)
		{
		}

		protected void PlayAnimGauge(int idx)
		{
		}

		protected void OnUpdateAnim(RectTransform trans, Vector2 fromScale, Vector2 toScale, SpriteRenderer sprite, float fromFade, float toFade, SpriteRenderer sprite2, float fromFade2, float toFade2, float t)
		{
		}

		protected void OnUpdateAnim(RectTransform trans, Vector2 fromScale, Vector2 toScale, SpriteRenderer sprite, float fromFade, float toFade, float t)
		{
		}

		protected void FlashAnim()
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
	}
}
