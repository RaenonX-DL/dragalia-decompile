using System.Collections.Generic;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemListController : TableViewController<ItemListCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public float captionHeight;

		public float fundsHeight;

		public float messageTextHeight;

		public Text noItemText;

		private int captionNum;

		private int fundsNum;

		private int textNum;

		protected override void Awake()
		{
		}

		public void LoadData(List<ItemListCellData> cellList)
		{
		}

		protected override TableViewCell<ItemListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override void UpdateContentSize()
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
