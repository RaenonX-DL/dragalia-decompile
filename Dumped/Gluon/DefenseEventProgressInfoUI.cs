using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class DefenseEventProgressInfoUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		protected RectTransform _rootRt;

		[SerializeField]
		protected RectTransform _fortRt;

		[SerializeField]
		protected RectTransform[] _glitterRt;

		[SerializeField]
		protected RectTransform _moveObjRt;

		[SerializeField]
		protected RectTransform _lineStartRt;

		[SerializeField]
		protected RectTransform _lineEndRt;

		[SerializeField]
		protected RectTransform _gaugeRt;

		[SerializeField]
		protected SpriteRenderer _fortImage;

		[SerializeField]
		protected SpriteRenderer _fortImageAdd;

		[SerializeField]
		protected SpriteRenderer _lineImage;

		[SerializeField]
		protected SpriteRenderer _gaugeBgImage;

		[SerializeField]
		protected SpriteRenderer[] _glitterImage;

		[SerializeField]
		protected SpriteRenderer[] _glitterImageAdd;

		[SerializeField]
		protected InGameGaugeUISpriteRenderer _gaugeUI;

		[SerializeField]
		protected DefenseEventLineMsgUI _lineMsg;

		[SerializeField]
		[Header("resource")]
		protected DefenseEventProgressMoveObjUI _originMoveObj;

		[SerializeField]
		protected Sprite _sprFort;

		[SerializeField]
		protected Sprite _sprFortAdd;

		[SerializeField]
		protected Sprite _sprLine;

		[SerializeField]
		protected Sprite _sprGaugeBg;

		[SerializeField]
		protected Sprite _sprGlitter;

		[SerializeField]
		protected Sprite[] _spriteIconList;

		[SerializeField]
		protected Sprite _sprMsg;

		[SerializeField]
		protected Material _matSprite;

		[SerializeField]
		protected Material _matAddSprite;

		[SerializeField]
		protected Material _matDOTween;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("è³\u0091ã\u0082\u0084ã\u0081\u008bã\u0081\u0097ã\u0081®ã\u0082µã\u0082¤ã\u0082º")]
		protected Vector2 _glitterScale;

		[SerializeField]
		[Tooltip("è³\u0091ã\u0082\u0084ã\u0081\u008bã\u0081\u0097ã\u0081®é\u0096\u008bå§\u008bé\u0081\u0085å»¶")]
		protected Vector2 _glitterStartDelayTime;

		[SerializeField]
		[Tooltip("è³\u0091ã\u0082\u0084ã\u0081\u008bã\u0081\u0097ã\u0081®ã\u0081°ã\u0082\u0089ã\u0081\u0091ç\u00af\u0084å\u009b²")]
		protected Vector2 _glitterCorrectRadius;

		[SerializeField]
		[Tooltip("æ\u008b\u00a0ç\u0082¹ã\u0081\u008cã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082\u0092å\u008f\u0097ã\u0081\u0091ã\u0081\u009fé\u009a\u009bã\u0081®ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8è¡\u00a8ç¤ºã\u0082¤ã\u0083³ã\u0082¿ã\u0083¼ã\u0083\u0090ã\u0083«")]
		protected float _fortDamageMsgIntervalTime;

		[SerializeField]
		[Tooltip("æ\u008b\u00a0ç\u0082¹ã\u0081\u008cç\u0080\u0095æ­»ã\u0081«ã\u0081ªã\u0081£ã\u0081\u009fé\u009a\u009bã\u0081®ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ã\u0082\u0092è¡\u00a8ç¤ºã\u0081\u0099ã\u0082\u008bHPå\u0089²å\u0090\u0088")]
		protected float _fortDyingMsgHpRate;

		protected InGameFollowLayout _followLayout;

		protected Sequence _seqFortDamage;

		protected Sequence[] _seqFortDamageGritter;

		protected TweenUtil.ColorModulusArgs _colorModulusFort;

		protected float _fortDamageMsgIntervalCount;

		protected bool _isFortDyingMsgDisplayed;

		private const float GlitterDefaultScale = 100f;

		public RectTransform moveObjRt => null;

		public static DefenseEventProgressInfoUI Create(GameObject parent, InGameUIConst.DecorationType type, int siblingIndex = -1)
		{
			return null;
		}

		public virtual void Initialize(InGameUIConst.DecorationType type)
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Release()
		{
		}

		public override void FastUpdate()
		{
		}

		public virtual void Show()
		{
		}

		public virtual void Hide()
		{
		}

		protected virtual void Visible(bool b, bool force = false)
		{
		}

		public virtual void SetFortHpRate(float rate, bool immediate)
		{
		}

		public virtual Sprite GetIconSprite(DefenseEventInfoCtrl.MoveObjIconType type)
		{
			return null;
		}

		public virtual DefenseEventProgressMoveObjUI CreateMoveObj(Action<int> onDisappear)
		{
			return null;
		}

		public virtual DefenseEventLineMsgUI GetLineMsg(GameObject parent)
		{
			return null;
		}

		public virtual Vector3 GetMoveObjPosition(float rate)
		{
			return default(Vector3);
		}

		public virtual void ActionFortDamage()
		{
		}

		protected virtual void PlayFortDamage()
		{
		}
	}
}
