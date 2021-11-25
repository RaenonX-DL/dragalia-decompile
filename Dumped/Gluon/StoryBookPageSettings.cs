using UnityEngine;

namespace Gluon
{
	public class StoryBookPageSettings : MonoBehaviour
	{
		public Vector3 pagePosition1;

		public Vector3 pagePosition2;

		public Vector3 pagePosition3;

		public Vector3 pagePosition4;

		public Vector3 pagePosition5;

		public Vector3 pagePosition6;

		public Vector3 pagePosition7;

		public float pageUpSpeed;

		public float pageDownSpeed;

		public float pageUpDuration;

		public float pageDownDelay;

		public float pageDownDuration;

		public void Reset()
		{
		}

		public Vector3 GetPagePosition(int index)
		{
			return default(Vector3);
		}
	}
}
