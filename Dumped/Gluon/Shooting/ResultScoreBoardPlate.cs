using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Shooting
{
	public class ResultScoreBoardPlate : MonoBehaviour
	{
		[SerializeField]
		private Text rankText;

		[SerializeField]
		private Text scoreText;

		[SerializeField]
		private Image newBadge;

		private static Color normalColor;

		private static Color newColor;

		private Vector2 blinkingToFrom;

		private float blinkingDuring;

		private Ease blinkingEasing;

		private Sequence blinkSeq;

		public void Init(Transform node, int scoreRank, int score, bool isNew)
		{
		}

		private void SetNewScoreTween()
		{
		}
	}
}
