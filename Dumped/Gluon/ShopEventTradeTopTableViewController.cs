using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopEventTradeTopTableViewController : TableViewController<ShopTradeModel.EventTradeTopData>
	{
		[SerializeField]
		[Header("WarningText")]
		public Text noEventText;

		private float cellHeight;

		private List<SimpleAnimationCell> animationCellList;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override TableViewCell<ShopTradeModel.EventTradeTopData> CreateCellForIndex(int index)
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
