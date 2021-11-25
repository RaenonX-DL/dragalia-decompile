using UnityEngine;

namespace Gluon
{
	public class FollowCameraDataContainer : MonoBehaviour
	{
		[SerializeField]
		private CameraController.FollowCameraData[] followData;

		public void SetFollowCameraData(out CameraController.FollowCameraData[] data)
		{
		}
	}
}
