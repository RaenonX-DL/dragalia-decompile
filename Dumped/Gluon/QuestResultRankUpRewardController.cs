using DG.Tweening;

namespace Gluon
{
	public class QuestResultRankUpRewardController : TableViewController<QuestResultModel.PlayerLevelupModel.PlantEnhanceInfo>
	{
		private float cellHeight;

		private float cellWidth;

		protected override void Awake()
		{
		}

		public void LoadData()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		public Sequence FadeIn()
		{
			return null;
		}
	}
}
