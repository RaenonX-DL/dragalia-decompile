using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomCellWaitingForJoinControl : MonoBehaviour
	{
		public GameObject[] loadingCircles;

		public Text[] jumpingTexts;

		private const float inOutAnimationTime = 0.3f;

		private Sequence currentSequence;

		private const float circleRadius = 40f;

		private const float circleFadeDuration = 0.3f;

		private const float circleShowDuration = 0.8f;

		private const float circleHideDuration = 0.4f;

		private const float circleInterval = 0.18f;

		private Sequence[] loopSequences;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void PlayWaiting()
		{
		}

		public void StopWaiting()
		{
		}
	}
}
