using System;
using System.Collections.Generic;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;

namespace Gluon
{
	public class MissionAllReceiveConfirmPopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/Mission/Popup/MissionAllReceiveConfirmPopup";

		private List<MyPagePresentGroupListCellData> groupCellDataList;

		[SerializeField]
		private MyPagePresentGroupListController groupListController;

		public static MissionAllReceiveConfirmPopup Create()
		{
			return null;
		}

		public void InitSetting(TabCategory category, List<MissionTableViewData> missionList, Action onReceivedCallback, Action onPressedSceneButtonCallback)
		{
		}

		public static void CreateReceiveGroupList(List<MissionTableViewData> missionList, List<MyPagePresentGroupListCellData> refGroupCellDataList, bool isConfirm = false)
		{
		}

		private static MyPagePresentGroupListCellData CreateCellDataWithDuplicateText(GiftType entityType, int entityId, int entityQuantity, Reward reward, MyPagePresentListPopup.ItemCategory itemCategory, Localize.TextId textId)
		{
			return null;
		}
	}
}
