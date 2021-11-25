using UnityEngine.UI;

namespace Gluon
{
	public class CSSummonTableViewCell : TableViewCell<SummonTopData.SwitchableSummonInfo>
	{
		public Image image;

		public SummonSwitchPopup switchPopup;

		public override void UpdateContent(SummonTopData.SwitchableSummonInfo info)
		{
		}

		public void OnItemPressed()
		{
		}
	}
}
