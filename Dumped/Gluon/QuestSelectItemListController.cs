using System.Collections.Generic;

namespace Gluon
{
	public class QuestSelectItemListController : TableViewController<ItemListCellData>
	{
		public const float cellHeight = 150f;

		public void LoadData(List<ItemListCellData> cellList)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
