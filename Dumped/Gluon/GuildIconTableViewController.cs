using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildIconTableViewController : TableViewController<GuildModel.ProfileIconData>
	{
		[SerializeField]
		[Header("Setting")]
		public GiftType type;

		public Text noItemText;

		private float cellWidth;

		private float cellHeight;

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		protected override void Start()
		{
		}

		public void UpdateSelectedIconData(ref GuildModel.ProfileIconData selectedIconData)
		{
		}

		protected override TableViewCell<GuildModel.ProfileIconData> CreateCellForIndex(int index)
		{
			return null;
		}
	}
}
