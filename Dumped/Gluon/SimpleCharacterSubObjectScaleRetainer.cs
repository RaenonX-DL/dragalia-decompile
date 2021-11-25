using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterSubObjectScaleRetainer : MonoBehaviour
	{
		private const float epsilon = 0.01f;

		private bool shouldDisableComponentOnNextUpdate;

		public void DisableComponentOnNextUpdate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
