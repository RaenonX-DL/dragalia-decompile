using System.Collections.Generic;

namespace Gluon
{
	public class ReceivedOverLimitListController : TableViewController<ReceivedOverLimitListCellData>
	{
		public const float cellHeight = 100f;

		protected override void Awake()
		{
		}

		public void LoadData(List<ReceivedOverLimitListCellData> cellList)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
