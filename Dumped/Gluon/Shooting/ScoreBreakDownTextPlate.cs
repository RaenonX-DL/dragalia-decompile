using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Shooting
{
	public class ScoreBreakDownTextPlate : MonoBehaviour
	{
		[SerializeField]
		private Text rankText;

		[SerializeField]
		private Text scoreText;

		[SerializeField]
		private Text numText;

		[SerializeField]
		private Text totalText;

		public void Init(int rank, STGDataManager.CurrentGameData.EnemyRankBreakdown enemyRankBreakdown)
		{
		}
	}
}
