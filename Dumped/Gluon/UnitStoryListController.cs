using System.Collections.Generic;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitStoryListController : TableViewController<UnitStoryListCellData>
	{
		public Text noStoryText;

		public CommonSortButton sortButton;

		public bool isCastleStory;

		private List<SimpleAnimationCell> animationCellList;

		public const float cellHeight = 148f;

		public const float castleCellHeight = 124f;

		private const float scrollsec = 1f;

		protected override void Awake()
		{
		}

		public void LoadData(List<UnitStoryListCellData> cellList)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void SetScrollForCellIndex(int index)
		{
		}

		public void Reload()
		{
		}

		protected override TableViewCell<UnitStoryListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void ResetScroll()
		{
		}
	}
}
