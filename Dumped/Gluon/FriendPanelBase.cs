using System;
using UnityEngine;

namespace Gluon
{
	public class FriendPanelBase : MonoBehaviour
	{
		public AnimationUIAutoPublisher[] enterPublishers;

		public AnimationUIAutoPublisher[] exitPublishers;

		private int animationDoneCount;

		private int animationToPlay;

		protected FriendScene scene;

		public void PlayEnterAnimation(Action onFinished)
		{
		}

		public virtual void PlayExitAnimation(Action onFinished)
		{
		}

		private void OnSingleAnimationDone(Action onAllFinished)
		{
		}

		public void OnMenuButtonPressed(FriendMenuButton button)
		{
		}

		[HideInInspector]
		public void OnMenuButtonPressed(FriendModel.PanelType type)
		{
		}

		public virtual void RefreshCurrentPage()
		{
		}
	}
}
