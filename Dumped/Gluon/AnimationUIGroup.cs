using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class AnimationUIGroup : AnimationUIPartBase
	{
		public GameObject[] targets;

		[SerializeField]
		public float delayInterval;

		[SerializeField]
		private bool shouldReverseDelayInterval;

		private IEnumerator coroutine;

		public override void Init()
		{
		}

		public void UpdateDelayTime()
		{
		}

		public override void Execute(bool isReverse = false)
		{
		}

		private IEnumerator WaitForFinished(float time)
		{
			return null;
		}

		public override void Kill()
		{
		}
	}
}
