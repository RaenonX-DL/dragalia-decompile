using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickAddCountInputBadgeUI : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _iconRt;

		[SerializeField]
		private SpriteRenderer _iconImage;

		[SerializeField]
		private SpriteRenderer _blinkImage;

		[SerializeField]
		private VisibleUIObject _visibleRoot;

		[SerializeField]
		[Header("resource")]
		private Sprite _enableIconSprite;

		[SerializeField]
		private Sprite _disableIconOffSprite;

		private Sequence _seqShow;

		private Sequence _seqHide;

		private Sequence _seqEnable;

		private Vector3 _orgScaleIcon;

		public int ShowAnimIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int HideAnimIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsEnableIcon
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(Transform parent)
		{
		}

		private void OnDestroy()
		{
		}

		public void Show(bool anim = true)
		{
		}

		public void Hide(bool anim = true)
		{
		}

		public void SetEnableIcon(bool enable, bool force = false, [Optional] Action onComplete)
		{
		}

		private void CreateActionShow()
		{
		}

		private void CreateActionHide()
		{
		}

		private void CreateActionEnable([Optional] Action onComplete)
		{
		}
	}
}
