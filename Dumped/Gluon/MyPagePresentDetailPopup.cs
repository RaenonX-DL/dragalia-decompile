using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPagePresentDetailPopup : CommonPopup
	{
		public MyPagePresentListPopup presentListPopup;

		[SerializeField]
		private CommonIcon itemIcon;

		[SerializeField]
		private Text itemNameText;

		[SerializeField]
		private Text discriptionText;

		[SerializeField]
		private Text DateText;

		private MyPagePresentListCellData cellData;

		private const string prefabPath = "Prefabs/OutGame/Present/MyPagePresentDetailPopup";

		public static MyPagePresentDetailPopup Create()
		{
			return null;
		}

		public void InitSetting(MyPagePresentListCellData data)
		{
		}

		public void OnItemButtonLongPressed()
		{
		}
	}
}
