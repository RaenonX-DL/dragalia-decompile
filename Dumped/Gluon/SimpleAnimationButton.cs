using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class SimpleAnimationButton : AnimationUIBase
	{
		protected PointerEventHandler pointEventHandler;

		public bool isStop;

		private bool isStarted;

		public bool isExitAnimationCompleted
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

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void StartEnterAnimation([Optional] Action onAnimationDone)
		{
		}

		public override void StartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		public void ForceStartEnterAnimation([Optional] Action onAnimationDone)
		{
		}

		public void ForceStartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		public override void ResetUIAnimations()
		{
		}

		public void ModifyEnterDelay(int frame)
		{
		}
	}
}
