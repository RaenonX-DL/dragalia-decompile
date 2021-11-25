using System.Collections.Generic;

namespace Gluon
{
	public class CampaignListController : TableViewController<CampaignCellData>
	{
		public const float cellHeight = 150f;

		protected override void Awake()
		{
		}

		protected override TableViewCell<CampaignCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void LoadData(List<CampaignCellData> cellList)
		{
		}

		public void ReloadData(List<CampaignCellData> cellList)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
