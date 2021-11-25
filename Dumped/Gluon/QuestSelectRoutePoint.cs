using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectRoutePoint : MonoBehaviour
	{
		[SerializeField]
		private float _waitForNextArranging;

		public int watchListIndex;

		private bool _isActivateImmediately;

		public List<float> waitForNextAnimationList;

		public bool autoDestroyFlag;

		public float startDelayTime;

		public float waitForNextArranging
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool isActivateImmediately
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual void StartActivation()
		{
		}

		public virtual void ActivateImmediately()
		{
		}
	}
}
