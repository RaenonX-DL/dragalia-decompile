using System.Collections.Generic;
using UnityEngine.UI;

namespace Gluon
{
	public class FriendListController : TableViewController<FriendListCellData>
	{
		public const float cellHeight = 148f;

		public Text NoFriendText;

		public CommonSortButton sortButton;

		private const int paddingBottomLayoutHeight = 80;

		protected override void Awake()
		{
		}

		public void LoadData(List<FriendListCellData> cellList)
		{
		}

		protected override TableViewCell<FriendListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void RemoveCellData(FriendListCellData data)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void Reload()
		{
		}
	}
}
