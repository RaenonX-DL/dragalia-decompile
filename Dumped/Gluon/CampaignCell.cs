using UnityEngine.UI;

namespace Gluon
{
	public class CampaignCell : TableViewCell<CampaignCellData>
	{
		public Image icon;

		public Text description;

		public Text remainDate;

		private CampaignDataWrapper data;

		private void Start()
		{
		}

		public override void UpdateContent(CampaignCellData cellData)
		{
		}

		public void InitParam(CampaignDataWrapper data)
		{
		}

		public void OnPressed()
		{
		}
	}
}
