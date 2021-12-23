using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorPassiveListPopupListController : TableViewController<DmodeServitorPassiveListPopupListCellData>
	{
		[SerializeField]
		private Text noAbilityText;

		private float cellWidth;

		private float cellHeight;

		protected override void Awake()
		{
		}

		public void LoadData()
		{
		}

		protected override void UpdateContents()
		{
		}

		protected override TableViewCell<DmodeServitorPassiveListPopupListCellData> CreateCellForIndex(int index)
		{
			return null;
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
