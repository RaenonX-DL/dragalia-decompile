using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class AnimationUITalkWindow : AnimationUIBase
	{
		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡å\u009b\u009eè»¢ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		private float exitRotationDuration;

		[SerializeField]
		[Header("çµ\u0082äº\u0086æ\u0099\u0082ã\u0081®OverRun")]
		private float exitOverRunZ;

		[SerializeField]
		[Header("çµ\u0082äº\u0086æ\u0099\u0082ã\u0081®OverRunæ\u0099\u0082é\u0096\u0093")]
		private float exitOverRunDuration;

		[SerializeField]
		[Header("è\u00a8­å®\u009aã\u0081\u0097ã\u0081\u009fDelayã\u0082\u0092ä½¿ã\u0081\u0086ã\u0081\u008bã\u0081©ã\u0081\u0086ã\u0081\u008b")]
		private bool shouldUseCustomDelay;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081®å\u009b\u009eè»¢ã\u0082\u0092ç\u0084¡è¦\u0096ã\u0081\u0099ã\u0082\u008bã\u0081\u008bã\u0081©ã\u0081\u0086ã\u0081\u008b")]
		private bool plainScaleEnterAnimation;

		[HideInInspector]
		public bool ignoreDelay;

		public override void Awake()
		{
		}

		public override void StartEnterAnimation([Optional] Action onAnimationDone)
		{
		}

		public override void StartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		public void StartCloseOpenAnimation(Action changeTextAction, [Optional] Action onAnimationDone)
		{
		}

		public override void ResetUIAnimations()
		{
		}

		public void ResetEnterAnimationPlayStatus()
		{
		}

		public void ResetExitAnimationPlayStatus()
		{
		}
	}
}
