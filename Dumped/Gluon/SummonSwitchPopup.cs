using UnityEngine;

namespace Gluon
{
	public class SummonSwitchPopup : PopupBase
	{
		public CSSummonTableViewController tableView;

		public GameObject singleViewOffObject;

		public Transform singleViewContentOffsetTransform;

		private SummonTopItemView itemView;

		private const float singleViewContentOffsetY = -109f;

		public static SummonSwitchPopup Create(SummonTopItemView itemView)
		{
			return null;
		}

		public void OnItemPressed(SummonTopData.SwitchableSummonInfo info)
		{
		}
	}
}
