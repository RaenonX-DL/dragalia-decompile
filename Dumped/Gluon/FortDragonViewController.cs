using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class FortDragonViewController : MonoBehaviour
	{
		public FortScene fortScene;

		public float duration;

		public float distance;

		[SerializeField]
		private float fadeOutStartRatio;

		[SerializeField]
		private float fadeOutDuration;

		private Tweener moveToDragonTweener;

		public void EnableToTap(bool value)
		{
		}

		public void OnDragonTapped()
		{
		}
	}
}
