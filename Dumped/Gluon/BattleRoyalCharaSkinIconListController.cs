using UnityEngine;

namespace Gluon
{
	public class BattleRoyalCharaSkinIconListController : TableViewController<CommonIconListCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public CommonIconListBase iconListBase;

		[HideInInspector]
		public int selectCharaSkinId;

		public void LoadSkinData(ulong[] charaSkinIds)
		{
		}

		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void UpdateSelectCell()
		{
		}

		public void Reload()
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
