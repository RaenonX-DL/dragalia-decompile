using UnityEngine;

namespace Gluon
{
	public class AndroidStatusBarResume : MonoBehaviour
	{
		public bool isStatusBarOn;

		public bool isNavigationBarOn;

		public void InitOnBoot()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}
	}
}
