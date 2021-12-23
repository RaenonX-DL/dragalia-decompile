using System.Collections.Generic;

namespace Gluon
{
	public class DmodeServitorPassiveListController : CommonIconListController
	{
		protected override void Start()
		{
		}

		public void LoadData()
		{
		}

		private List<int> CreateDataIdList()
		{
			return null;
		}

		protected override CommonIconListCellData CreateDmodeServitorPassiveCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
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
	}
}
