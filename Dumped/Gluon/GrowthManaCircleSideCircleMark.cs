using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleSideCircleMark : MonoBehaviour
	{
		public enum State
		{
			AllReleased,
			Releasable,
			LimitReleaseRequired,
			NotReleased
		}

		public State state;

		public GameObject allReleased;

		public GameObject releasable;

		public GameObject limitReleaseRequired;

		public GameObject notReleased;

		private void Awake()
		{
		}

		public void SetState(State state)
		{
		}
	}
}
