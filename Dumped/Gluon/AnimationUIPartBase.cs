using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public abstract class AnimationUIPartBase : MonoBehaviour
	{
		protected bool _isReverseAnimation;

		private RectTransform _rectTransform;

		private bool isInited;

		public bool isAnimating
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<bool> onAnimationFinished
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isReverseAnimation => default(bool);

		public RectTransform rectTransform => null;

		public virtual void Init()
		{
		}

		public virtual void Execute(bool isReverse = false)
		{
		}

		protected virtual void OnAnimationFinished()
		{
		}

		public virtual void Kill()
		{
		}
	}
}
