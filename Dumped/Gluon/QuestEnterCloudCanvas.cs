using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class QuestEnterCloudCanvas : SingletonInBaseMonoBehaviour<QuestEnterCloudCanvas>
	{
		public static bool skipCreateOnStart;

		public CanvasGroup canvasGroup;

		public CanvasGroup whiteCanvasGroup;

		private FlashPlayer flashPlayer;

		private bool isLoaded;

		private Tweener tweener;

		public bool isOnAnimation
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

		public void Init()
		{
		}

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void StartAnimation(Action nextAction, [Optional] Action hideAfterAction)
		{
		}

		private IEnumerator StartAnimationCoroutine(Action nextAction, [Optional] Action hideAfterAction)
		{
			return null;
		}

		public void EndAnimation([Optional] Action outEndAnimationAction)
		{
		}
	}
}
