using System;
using UnityEngine;

namespace Gluon.Shooting
{
	public class STGPausePU : MonoBehaviour
	{
		[SerializeField]
		public GameObject restartButton;

		public PointerEventHandler continueButton;

		public GameObject[] gameOverGOs;

		public GameObject[] pauseGOs;

		public GameObject touchGuard;

		[SerializeField]
		[Header("Publishers")]
		public UIAnimationPublisher publisher;

		private Action onContinue;

		private Action onRestart;

		private Action onRetire;

		public void Setup(bool isPause, bool hasRestart, Action onContinue, Action onRestart, Action onRetire)
		{
		}

		public void OnContinue()
		{
		}

		public void OnRestart()
		{
		}

		public void OnRetire()
		{
		}
	}
}
