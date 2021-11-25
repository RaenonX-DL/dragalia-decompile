using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTreasureTradeTopTableViewController : TableViewController<ShopTradeModel.TreasureTradeTopData>
	{
		[SerializeField]
		[Header("WarningText")]
		public Text noTreasureText;

		private float cellHeight;

		private List<SimpleAnimationCell> animationCellList;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override TableViewCell<ShopTradeModel.TreasureTradeTopData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override void UpdateContents()
		{
		}
	}
}
