using System;

namespace Gluon.Mission.ListView
{
	public class MissionTableViewController : TableViewController<MissionTableViewData>
	{
		public const float cellHeight = 168f;

		public const float cellWidth = 564f;

		public const float captionCellHeight = 56f;

		public const float textCellHeight = 50f;

		public const float cellAnimationDuration = 355f / (678f * (float)Math.PI);

		public bool IsNoEntry => default(bool);

		protected override void Awake()
		{
		}

		protected override TableViewCell<MissionTableViewData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void SetCellData(MissionTableViewData[] data)
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

		public void ShowCellAnimation()
		{
		}

		public void SkipCellAnimation()
		{
		}

		public void ScrollToMission(int missionId)
		{
		}
	}
}
