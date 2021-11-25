using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon.Shooting
{
	public class ShootingResultUiCanvas : AnimationUICanvas
	{
		[SerializeField]
		private GameObject difficultyNormal;

		[SerializeField]
		private GameObject difficultyHard;

		[SerializeField]
		private GameObject difficultyNightmare;

		[SerializeField]
		[Header("Numbers")]
		public Sprite[] numbers;

		public Image[] digits;

		[SerializeField]
		private Animator canvasAnim;

		[SerializeField]
		private Animator scoreBoardAnim;

		[SerializeField]
		private Animator rankingAnim;

		[SerializeField]
		private Animator retryButtonAnim;

		[SerializeField]
		private Animator nextButtonAnim;

		[SerializeField]
		private Animator whiteScreenAnimator;

		[SerializeField]
		private Animator blackScreenAnimator;

		[SerializeField]
		private GameObject scoreBoardNode;

		[SerializeField]
		private List<GameObject> breakDownPosList;

		[SerializeField]
		private Text bonusText;

		[SerializeField]
		private GameObject rankingNode;

		[SerializeField]
		private List<Transform> platePos;

		[SerializeField]
		private GameObject cloudObject;

		private List<ResultScoreBoardPlate> rankingPlateList;

		private const int hardBreakdownRankNum = 4;

		private const int resultBackKeyEventNum = 0;

		private void Start()
		{
		}

		private void Appear()
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void OnNextButtonPressed()
		{
		}

		private void ReStartShooting()
		{
		}

		private IEnumerator FadeOut(Action onCompletedAction)
		{
			return null;
		}

		private void SetResultData()
		{
		}

		private void SetDifficulty(STGDataManager.Mode mode)
		{
		}

		private void SetTotalScore(int score)
		{
		}

		private void SetRetryButton(float diry = 0f)
		{
		}

		private void PlayTotalScoreVoice(STGDataManager.CurrentGameData data)
		{
		}

		private void SetBreakdown(STGDataManager.CurrentGameData data)
		{
		}

		private void SetScorePlate(int rank, GameObject parent, STGDataManager.CurrentGameData.EnemyRankBreakdown enemyBreakdown)
		{
		}

		private ScoreBreakDownTextPlate CreateBreakdownPlate(GameObject parent)
		{
			return null;
		}

		private void setBonusPlate(GameObject parent, int score)
		{
		}

		private void SetRanking()
		{
		}

		private void PlayRankInSe(int rank)
		{
		}

		private void PlayRankInVoice(int rank)
		{
		}

		private ResultScoreBoardPlate CreateScoreBordPlate(GameObject parent)
		{
			return null;
		}

		private bool IsRankIn()
		{
			return default(bool);
		}

		private void StartUIAnim(Animator animator, bool isIn)
		{
		}

		private void StartUIAnim(Animator animator, bool isIn, float diray)
		{
		}

		private IEnumerator StartUIAnimWithWaight(Animator animator, bool isIn, float diray)
		{
			return null;
		}

		private void SetBuckKeyEvent(int sortingOrder, UnityAction action)
		{
		}

		private void RemoveBuckKeyEvent(int sortingOrder)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
