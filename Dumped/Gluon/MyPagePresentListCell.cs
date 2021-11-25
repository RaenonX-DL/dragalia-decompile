using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPagePresentListCell : TableViewCell<MyPagePresentListCellData>
	{
		[SerializeField]
		private CommonIcon itemIcon;

		[SerializeField]
		private Text itemNameText;

		[SerializeField]
		private Text discriptionText;

		[SerializeField]
		private Button listOnButton;

		[SerializeField]
		private Text listOnButtonText;

		[SerializeField]
		private Text dateAreaText;

		private bool isInitialized;

		private PreferredSizeFitter itemNameTextFitter;

		private Vector2 itemNameTextBaseSizeDelta;

		private MyPagePresentListCellData cellData;

		private void Start()
		{
		}

		public override void UpdateContent(MyPagePresentListCellData data)
		{
		}

		public void OnItemIconLongPressed()
		{
		}

		public void OnListOnButtonPressed()
		{
		}
	}
}
