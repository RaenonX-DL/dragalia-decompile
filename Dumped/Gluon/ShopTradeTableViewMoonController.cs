using UnityEngine;

namespace Gluon
{
	public class ShopTradeTableViewMoonController : ShopTradeTableViewController
	{
		[SerializeField]
		[Header("Size")]
		public int highCellSize;

		public int lowCellSize;

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
