using UnityEngine;

namespace Gluon
{
	public class QuestResultRankingEffect
	{
		public enum RankingEffectType
		{
			ClearTime,
			Rank
		}

		private QuestResultFlController clearTimeFlController;

		private QuestResultFlController rankController;

		private int clearTimeNum;

		private int rankingNum;

		private readonly int speriaorRankThreshold;

		public void Init(int questId, FlashPlayerManager fpManager, Transform parent)
		{
		}

		public bool IsInitCompleted(RankingEffectType type)
		{
			return default(bool);
		}

		public void Enter(RankingEffectType type)
		{
		}

		public void Exit(RankingEffectType type)
		{
		}
	}
}
