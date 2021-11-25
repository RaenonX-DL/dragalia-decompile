using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Shooting
{
	public class HomeScoreBoardPlate : MonoBehaviour
	{
		[SerializeField]
		private Image plateImage;

		[SerializeField]
		private Image bossImage;

		[SerializeField]
		private GameObject bossLevelNode;

		[SerializeField]
		private Text bossLevelText;

		[SerializeField]
		private Text scoreText;

		[SerializeField]
		private GameObject newScoreIcon;

		[SerializeField]
		private List<Sprite> plateImageList;

		[SerializeField]
		private List<Sprite> bossImageList;

		public Animator animator;

		private Vector2 blinkingToFrom;

		private float blinkingDuring;

		private Ease blinkingEasing;

		private Sequence blinkSeq;

		public void Init(Transform node, int scoreRank, int score, int enemyRank, bool isNewScore, STGDataManager.Mode mode)
		{
		}

		private void SetPlateImage(int rank)
		{
		}

		public void SetAnimation(bool isIn)
		{
		}

		private void SetBossImage(int level, STGDataManager.Mode mode)
		{
		}

		private void SetNewScoreTween()
		{
		}
	}
}
