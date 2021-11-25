using System.Collections.Generic;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPagePresentListController : TableViewController<MyPagePresentListCellData>
	{
		public Text NoPresentText;

		public const float cellHeight = 168f;

		protected override void Awake()
		{
		}

		protected override TableViewCell<MyPagePresentListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void LoadData(List<MyPagePresentListCellData> cellList)
		{
		}

		public void ReloadData(List<MyPagePresentListCellData> cellList)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
