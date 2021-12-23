using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickAddCountInputUI : CharaGimmickBaseInputUI
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _fingerRt;

		[SerializeField]
		private RectTransform _fingerBgRt;

		[SerializeField]
		private RectTransform _badgeRootRt;

		[SerializeField]
		private SpriteRenderer _bgImage;

		[SerializeField]
		private CharaGimmickAddCountInputBadgeUI _baseBadge;

		[SerializeField]
		[Header("parameter")]
		private float _baseBgWidth;

		[SerializeField]
		private float _addBgWidth;

		private List<CharaGimmickAddCountInputBadgeUI> _badgeUIList;

		private VisibleUIObject _visibleRoot;

		private Sequence _seqShow;

		private Sequence _seqHide;

		private Sequence _seqFinger;

		private CharacterBase _owner;

		private int _showBadgeNum;

		private int _maxBadgeNum;

		private int maxAdditionalInputCount;

		private int additionalInputConditionId;

		private bool _show;

		public const float HIDE_ANIM_ENABLE_ICON_BLINK_TIME = 0.23333335f;

		public static CharaGimmickAddCountInputUI Create(GameObject parent, CharacterBase owner, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(CharacterBase owner)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void Show(int num)
		{
		}

		public override void Hide(bool anim = true)
		{
		}

		public override void ReserveItem(int actionId)
		{
		}

		private void EnableItem(int num)
		{
		}

		public override void SetCount(int num, bool force = false, bool immediate = false)
		{
		}

		public void OnEnableBadgeMaximum()
		{
		}

		private void CreateActionShow()
		{
		}

		private void CreateActionHide()
		{
		}

		private void CreateActionFinger()
		{
		}

		public override int GetInputType()
		{
			return default(int);
		}

		public override bool IsVisible()
		{
			return default(bool);
		}
	}
}
