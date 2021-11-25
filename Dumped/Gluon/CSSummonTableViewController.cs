using System.Collections.Generic;

namespace Gluon
{
	public class CSSummonTableViewController : TableViewController<SummonTopData.SwitchableSummonInfo>
	{
		private float cellHeight;

		private List<SimpleAnimationCell> animationCellList;

		protected override TableViewCell<SummonTopData.SwitchableSummonInfo> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void ReloadByData(List<SummonTopData.SwitchableSummonInfo> data)
		{
		}
	}
}
