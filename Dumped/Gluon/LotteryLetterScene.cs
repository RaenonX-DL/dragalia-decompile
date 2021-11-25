using System;
using System.Collections;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class LotteryLetterScene : SceneBase
	{
		[SerializeField]
		private Camera mainCamera;

		[SerializeField]
		private Transform overlayParent;

		private AtgenLotteryResultList[] lotteryOddsRateList;

		[SerializeField]
		private int letterGrade;

		private bool isCommunicationFinished;

		private LotteryLetterMain mainCanvas;

		private FlMotion letterAnimeMotion;

		public static string prefabDir;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
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

		private IEnumerator LoadScene()
		{
			return null;
		}

		private void PlayOpningFlash(GameObject craftAnimation)
		{
		}

		private void PlayResultFlash()
		{
		}

		private IEnumerator WaiteTap(Action onTap)
		{
			return null;
		}

		private void SendLotteryExec(int lotteryId)
		{
		}

		private void GetLetterGrade()
		{
		}

		private void CreatePopup()
		{
		}

		private void GoToNextPage()
		{
		}

		public void GotoMyPage()
		{
		}

		public static bool IsExistLotteryTickets()
		{
			return default(bool);
		}

		private static bool IsWithinPeriod(int ticketId)
		{
			return default(bool);
		}
	}
}
