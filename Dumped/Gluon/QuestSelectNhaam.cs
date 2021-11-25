using System;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectNhaam : MonoBehaviour
	{
		[SerializeField]
		private FlashPlayerManager nhaamFlashMgr;

		private FlashPlayer twinkleFlash;

		private readonly Vector2 twinklePos;

		private FlashPlayer moveFlash;

		public void Initialize(int sortOrder)
		{
		}

		public void PlayAnimation()
		{
		}

		public void PlayExitAnimation(Action onEnd)
		{
		}

		public void SetSortingOrder(int sortOrder)
		{
		}

		public bool IsInitialized()
		{
			return default(bool);
		}
	}
}
