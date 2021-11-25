using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.UI;

namespace Gluon
{
	public class AnimationUICaption : AnimationUIBase
	{
		public bool isShown;

		public AnimationUICanvas canvas;

		private Image[] images;

		private Text[] texts;

		private Action onEnterAnimationDone;

		private Action onExitAnimationDone;

		public override void Awake()
		{
		}

		public override void StartEnterAnimation([Optional] Action onAnimationDone)
		{
		}

		private IEnumerator StartEnterAnimationCoroutine([Optional] Action onAnimationDone)
		{
			return null;
		}

		private void StartEnterAnimationImpl()
		{
		}

		public override void StartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		public bool IsOnExitAnimation()
		{
			return default(bool);
		}

		private void SetUIPartsEnable(bool enabled)
		{
		}
	}
}
