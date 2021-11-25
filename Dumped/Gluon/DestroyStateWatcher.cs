using System;
using UnityEngine;

namespace Gluon
{
	public class DestroyStateWatcher : MonoBehaviour
	{
		public Action<bool> enableStateWatcher;

		public Action destroyStateWatcher;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void RemoveAllCallbacksAndDestroySelf()
		{
		}
	}
}
