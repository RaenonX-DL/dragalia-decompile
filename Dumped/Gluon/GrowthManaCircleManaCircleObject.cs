using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleManaCircleObject : MonoBehaviour
	{
		public int index;

		public GrowthManaCircleScene scene;

		public GameObject[] pointNodes;

		public GameObject[] pointObjects;

		public GrowthManaCircleManaPieceObject[] points;

		private GrowthManaCircleEffectSettings efs;

		private const int numOfPoints = 10;

		private IEnumerator Start()
		{
			return null;
		}

		public List<int> GetUnReleasedPointIndexList()
		{
			return null;
		}

		public void SetTouchablePoints(int centerIndex)
		{
		}

		public Vector3 GetTouchPointWorldPosition(int touchPointIndex)
		{
			return default(Vector3);
		}

		public void PlayReleasePointEffect(GrowthManaCircleManaPieceObject touchPoint)
		{
		}

		private IEnumerator ChangeReleasePointCoroutine(EffectObject effectObject)
		{
			return null;
		}

		public void PlayReleaseAutoEffect(List<GrowthManaCircleManaPieceObject> pointList, bool isSoundOff = false)
		{
		}

		private IEnumerator AutoReleaseEffectCoroutine(GrowthManaCircleManaPieceObject touchPoint, float delay, bool isSoundOff)
		{
			return null;
		}

		public void PlayReleaseLimitReadyEffect(Vector3 lockObjectPosition)
		{
		}

		private IEnumerator ReleaseLimitOnPointEffectCoroutine()
		{
			return null;
		}

		private IEnumerator ReleaseLimitFlyingEffectCoroutine(Vector3 lockObjectPosition)
		{
			return null;
		}

		public void PlayAllReleaseEffect(Vector3 lockObjectPosition)
		{
		}

		private IEnumerator AllReleaseOnPointEffectCoroutine()
		{
			return null;
		}

		private IEnumerator AllReleaseFlyingEffectCoroutine(Vector3 lockObjectPosition)
		{
			return null;
		}
	}
}
