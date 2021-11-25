using DG.Tweening;
using UnityEngine;
using UnityEngine.Playables;

namespace Gluon
{
	public class MyPageCamera : MonoBehaviour
	{
		public MyPageScene scene;

		public Camera mainCamera;

		public MyPageObjectsSettings objectsSettings;

		public MyPageSkitCameraSettings skitCameraSettings;

		private Tweener tweener;

		private bool isTimelineValid;

		private Camera timelineCamera;

		private PlayableDirector director;

		private void CleanUp()
		{
		}

		public void SetupMoveMapCamera()
		{
		}

		public void SetUpSkitMapCamera()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
