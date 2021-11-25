using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class AnimationUIExpand : AnimationUIPart
	{
		[SerializeField]
		private Ease easeTypeReverse;

		[SerializeField]
		private float startWidth;

		[SerializeField]
		private float endWidth;

		public override void Init()
		{
		}

		public override void Execute(bool isReverse = false)
		{
		}
	}
}
