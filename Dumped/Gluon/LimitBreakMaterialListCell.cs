using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LimitBreakMaterialListCell : CommonIconListCell
	{
		[SerializeField]
		private GameObject itemCountBaseObject;

		[SerializeField]
		private Text countText;

		public override void UpdateContent(CommonIconListCellData data)
		{
		}

		public void SetDragonSphereCountText(int useCount, int needCount)
		{
		}
	}
}
