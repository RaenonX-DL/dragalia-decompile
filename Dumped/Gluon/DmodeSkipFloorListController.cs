using System;

namespace Gluon
{
	public class DmodeSkipFloorListController : TableViewController<DmodeSkipFloorListCell.DmodeSkipFloorListCellData>
	{
		private Action<int> onCellPressedCallback;

		private float cellWidth;

		private float cellHeight;

		protected override void Start()
		{
		}

		public void AddonCellPressedCallback(Action<int> callback)
		{
		}

		public void LoadData(int maxFloorNum)
		{
		}

		protected override TableViewCell<DmodeSkipFloorListCell.DmodeSkipFloorListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public bool ExistSkipableFloorData()
		{
			return default(bool);
		}
	}
}
