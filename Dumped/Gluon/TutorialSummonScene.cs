using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class TutorialSummonScene : SceneBase
	{
		[SerializeField]
		private Camera _uiCamera;

		[SerializeField]
		private Camera _flashCamera;

		public bool isDebugNotConnecting;

		public Camera uiCamera => null;

		public Camera flashCamera => null;

		private void Start()
		{
		}

		private void OnEnterScene()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public override void OnBeforeLeaving()
		{
		}

		public override void StartExitAnimation()
		{
		}

		private IEnumerator StartExitAnimationCoroutine()
		{
			return null;
		}
	}
}
