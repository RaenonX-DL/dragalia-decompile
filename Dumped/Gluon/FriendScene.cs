using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class FriendScene : SceneBase
	{
		[SerializeField]
		[Header("SwitchablePanels")]
		private Transform currentPanelNode;

		[SerializeField]
		private Transform nextPanelNode;

		[HideInInspector]
		public Canvas canvas;

		private bool bPrevPanelExitDone;

		private bool bNextHttpReady;

		private FriendPanelBase activePanel;

		private Coroutine waitReadyStateCoroutine;

		private BackButton backButton;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private void LoadBG()
		{
		}

		public void SetCaption()
		{
		}

		public void SetBackButton()
		{
		}

		private void OnBackButtonPressed()
		{
		}

		private void OnEnterScene()
		{
		}

		public override void StartExitAnimation()
		{
		}

		public void SwitchToPanel(FriendModel.PanelType type)
		{
		}

		private IEnumerator WaitForReadyState(FriendModel.PanelType type)
		{
			return null;
		}

		private void ReleasePanel(FriendModel.PanelType type)
		{
		}

		private void RequestHttpForPanel(FriendModel.PanelType type)
		{
		}

		public void LoadPanel(FriendModel.PanelType type)
		{
		}

		public void SetNextHttpReady()
		{
		}

		private void OnDestroy()
		{
		}

		public void ClearChangeSceneCallbacks()
		{
		}

		public override void OnPresentReceived()
		{
		}
	}
}
