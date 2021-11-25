using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class AnimationUIMove : AnimationUIPart
	{
		public Vector2 relativeDistance;

		public Vector2 startPos;

		public Vector2 endPos;

		public bool useRelativeDistance;

		[SerializeField]
		private Ease easeTypeReverse;

		private bool isResetMovePos;

		public override void Init()
		{
		}

		public void OnEnable()
		{
		}

		public override void Execute(bool isReverse = false)
		{
		}
	}
}
