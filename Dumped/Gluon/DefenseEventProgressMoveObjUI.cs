using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class DefenseEventProgressMoveObjUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		protected RectTransform _rootRt;

		[SerializeField]
		protected RectTransform _iconRt;

		[SerializeField]
		protected SpriteRenderer _iconImage;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ç§»å\u008b\u0095è£\u009cå®\u008cã\u0082\u0092å\u0088¤å®\u009aã\u0081\u0099ã\u0082\u008bé\u0096¾å\u0080¤")]
		protected float _moveCompletionThreshold;

		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095è£\u009cå®\u008cã\u0081®æ\u0099\u0082é\u0096\u0093")]
		protected float _moveCompletionTime;

		protected DefenseEventProgressInfoUI _infoUI;

		protected VisibleUIObject _visible;

		protected EnemyCharacter _enemy;

		protected Sequence _seqAppear;

		protected Sequence _seqAttack;

		protected Sequence _seqDisappear;

		protected Tweener _tweenMove;

		protected Action<int> _OnDisappear;

		protected float _positionRate;

		protected float _lastPositionRate;

		public float sortingPosZ
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual void Initialize(DefenseEventProgressInfoUI infoUI, Material material, Action<int> onDisappear)
		{
		}

		public virtual void Setup(EnemyCharacter chara, DefenseEventInfoCtrl.MoveObjIconType type)
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Release()
		{
		}

		public virtual void Show()
		{
		}

		public virtual void Hide()
		{
		}

		public override void FastUpdate()
		{
		}

		public virtual void SetIcon(Sprite sprite)
		{
		}

		public virtual void SetIcon(DefenseEventInfoCtrl.MoveObjIconType type)
		{
		}

		public virtual void SetPosition(float rate)
		{
		}

		public virtual void ApplyPosition()
		{
		}

		public virtual bool IsEndPoint()
		{
			return default(bool);
		}

		public virtual void ActionAppear()
		{
		}

		public virtual void ActionAttack()
		{
		}

		public virtual void ActionDisappear()
		{
		}

		public virtual bool IsPlayingAction()
		{
			return default(bool);
		}

		protected virtual void PlayAppear()
		{
		}

		protected virtual void PlayAttack()
		{
		}

		protected virtual void PlayDisappear()
		{
		}
	}
}
