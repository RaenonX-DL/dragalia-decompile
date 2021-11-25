using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class AlbumScene : SceneBase
	{
		[SerializeField]
		private Camera mainCamera;

		private string charaVoiceGroupName;

		private TouchGuardObject albumSceneTouchGuard;

		private TouchGuardObject albumSceneTutorialTouchGuard;

		private bool isTutorial;

		private bool isConnecting;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnterScene()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReadyRequestHttp()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void TutorialStart()
		{
		}

		private IEnumerator TutorialAlbumCoroutine()
		{
			return null;
		}

		private void CreateGetAlbumBonusPopup()
		{
		}

		public override void OnBeforeLeaving()
		{
		}
	}
}
