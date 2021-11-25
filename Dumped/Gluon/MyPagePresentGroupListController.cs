using System.Collections.Generic;

namespace Gluon
{
	public class MyPagePresentGroupListController : TableViewController<MyPagePresentGroupListCellData>
	{
		public static int sceneButtonOpenedCellDataIndex;

		public const float cellHeight = 100f;

		protected override void Awake()
		{
		}

		public void LoadData(List<MyPagePresentGroupListCellData> cellList)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
