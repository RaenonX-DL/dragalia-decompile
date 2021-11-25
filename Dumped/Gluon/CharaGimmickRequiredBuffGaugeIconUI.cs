using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickRequiredBuffGaugeIconUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform rootRt;

		[SerializeField]
		private SpriteRenderer iconImage;

		[SerializeField]
		private SpriteRenderer overlayImage;

		[SerializeField]
		private SpriteRenderer overlayCircleImage;

		[SerializeField]
		private SpriteRenderer overlayLoopImage;

		[SerializeField]
		private SpriteRenderer ringImage;

		[SerializeField]
		[Header("parameter")]
		private Color enableColor;

		[SerializeField]
		private Color disableColor;

		private Sequence seqAnim;

		private Sequence seqLoopAnim;

		private Action onCompleteActiveAnim;

		private Action onInactive;

		public bool isActive
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

		public bool isEnable
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

		public void Initialize(string iconName, Action onCompleteActiveAnim, Action onInactive)
		{
		}

		public void SetupIcon(string iconName)
		{
		}

		private void OnDestroy()
		{
		}

		public void SetEnable(bool b, bool isForce = false)
		{
		}

		public void SetActive(bool b)
		{
		}

		public void PlayActiveAnim()
		{
		}

		public void PlayAllSlotActiveAnim()
		{
		}

		public void StopAllSlotActiveAnimForLoop()
		{
		}

		public bool IsPlayingAnim()
		{
			return default(bool);
		}
	}
}
