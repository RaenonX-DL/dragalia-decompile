using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionGuideListCell : TableViewCell<MissionGuideListCellData>
	{
		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text desText;

		[SerializeField]
		private GameObject clearObj;

		public override void UpdateContent(MissionGuideListCellData data)
		{
		}
	}
}
