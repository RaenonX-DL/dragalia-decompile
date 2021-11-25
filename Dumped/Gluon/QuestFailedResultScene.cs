using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestFailedResultScene : SceneBase
	{
		[SerializeField]
		[Header("HttpGreenLight")]
		private GameObject httpGreenLight;

		[SerializeField]
		[Header("Nodes")]
		private Transform topNode;

		[SerializeField]
		private Image questBg;

		[SerializeField]
		private Image uiBackGround;

		public Canvas sceneCanvas;

		[SerializeField]
		public Camera mainCamera;

		private QuestFailedResultTopPage topPage;

		private EventKindType eventKindType;

		private int eventViewType;

		private IEnumerator Start()
		{
			return null;
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReadyRequestHttp()
		{
		}

		private void OnEnterScene()
		{
		}

		private IEnumerator OnEnterSceneCoroutine()
		{
			return null;
		}

		public void LoadTopView()
		{
		}

		public void LoadNextScene(string nextSceneName)
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnBeforeLeaving()
		{
		}
	}
}
