using System.Collections.Generic;

namespace Gluon
{
	public class CampaignListPopup : CommonPopup
	{
		private class TmpListData
		{
			public CampaignType type;

			public int questGroupId;

			public TmpListData(CampaignType type, int questGroupId)
			{
			}
		}

		public CampaignListController listController;

		private List<CampaignCellData> cellDataList;

		private List<TmpListData> tmpList;

		public static CampaignListPopup CreateCampaignListPopup()
		{
			return null;
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}
	}
}
