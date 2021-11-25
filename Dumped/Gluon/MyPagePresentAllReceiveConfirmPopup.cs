using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class MyPagePresentAllReceiveConfirmPopup : CommonPopup
	{
		public MyPagePresentListPopup presentListPopup;

		[SerializeField]
		private MyPagePresentGroupListController groupListController;

		private List<MyPagePresentGroupListCellData> groupCellDataList;

		private const string prefabPath = "Prefabs/OutGame/Present/MyPagePresentAllReceiveConfirmPopup";

		public static MyPagePresentAllReceiveConfirmPopup Create()
		{
			return null;
		}

		public void InitSetting(List<MyPagePresentListCellData> presentCellDataList)
		{
		}
	}
}
