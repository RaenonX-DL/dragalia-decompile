using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopDrawMaterialSummonOddsTableViewCell : TableViewCell<ShopDrawMaterialSummonOddsTableViewData>
	{
		[SerializeField]
		public Text itemNameText;

		public Text quantityText;

		public Text rateText;

		public override void UpdateContent(ShopDrawMaterialSummonOddsTableViewData data)
		{
		}
	}
}
