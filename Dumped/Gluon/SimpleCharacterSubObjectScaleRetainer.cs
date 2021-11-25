using System;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterSubObjectScaleRetainer : MonoBehaviour
	{
		private const float epsilon = 0.01f;

		private bool shouldDisableComponentOnNextUpdate;

		private Action onDisableCallback;

		private void OnDisable()
		{
		}

		public void AddDisableCallback(Action callback)
		{
		}

		public void DisableComponentOnNextUpdate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
