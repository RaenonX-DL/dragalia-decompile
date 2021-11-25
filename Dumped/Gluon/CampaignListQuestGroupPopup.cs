using System.Collections.Generic;

namespace Gluon
{
	public class CampaignListQuestGroupPopup : CommonPopup
	{
		public CampaignListController listController;

		private List<CampaignCellData> cellDataList;

		private List<CampaignDataWrapper> campaignDataList;

		public static CampaignListQuestGroupPopup CreateCampaignListPopup(List<CampaignDataWrapper> grogroup)
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
