using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopDrawMaterialSummonOddsPopup : PopupBase
	{
		[SerializeField]
		public Text detailText;

		public ShopDrawMaterialSummonOddsTableViewController tableView;

		private List<ShopDrawMaterialSummonOddsTableViewData> dataList;

		public static ShopDrawMaterialSummonOddsPopup Create(List<ShopDrawMaterialSummonOddsTableViewData> dataList)
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}
