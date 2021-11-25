using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class AnimationUIMoveTwoWay : AnimationUIPart
	{
		[SerializeField]
		[Header("Enter")]
		private Vector2 enteringRelativeDistance;

		[SerializeField]
		private Vector2 enteringStartPos;

		[SerializeField]
		private Vector2 enteringEndPos;

		[SerializeField]
		private Ease enteringEaseType;

		[SerializeField]
		[Header("Exit")]
		private Vector2 exitingRelativeDistance;

		[SerializeField]
		private Vector2 exitingStartPos;

		[SerializeField]
		private Vector2 exitingEndPos;

		[SerializeField]
		private Ease exitingEaseType;

		[SerializeField]
		private bool useRelativeDistance;

		[SerializeField]
		private bool useAlphaFade;

		private CanvasGroup canvasGroup;

		private Tweener curFadeTweener;

		public override void Init()
		{
		}

		public override void Execute(bool isExit = false)
		{
		}
	}
}
