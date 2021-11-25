using System.Collections.Generic;

namespace Gluon
{
	public class ShopDrawMaterialSummonOddsTableViewController : TableViewController<ShopDrawMaterialSummonOddsTableViewData>
	{
		private float cellHeight;

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void ReloadByData(List<ShopDrawMaterialSummonOddsTableViewData> data)
		{
		}
	}
}
