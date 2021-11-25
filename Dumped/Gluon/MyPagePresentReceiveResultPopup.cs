using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPagePresentReceiveResultPopup : CommonPopup
	{
		private enum State
		{
			None = -1,
			Delete,
			NoReceive,
			LimitOver,
			Converted,
			Receive
		}

		public MyPagePresentListPopup presentListPopup;

		[SerializeField]
		private MyPagePresentGroupListController successGroupListController;

		[SerializeField]
		private GameObject failedRoot;

		[SerializeField]
		private Text failedText;

		[SerializeField]
		private MyPagePresentGroupListController failedGroupListController;

		[SerializeField]
		private GameObject failedOneItemCell;

		[SerializeField]
		private CommonIcon failedOneItem;

		[SerializeField]
		private Text failedOneItemNameText;

		private List<MyPagePresentGroupListCellData> groupCellDataList;

		private MyPagePresentGroupListController groupListController;

		private State popupState;

		private bool isTransition;

		private const string prefabPath = "Prefabs/OutGame/Present/MyPagePresentReceiveResultPopup";

		public static MyPagePresentReceiveResultPopup Create()
		{
			return null;
		}

		public void InitSetting(List<ulong> noReceiveIds, List<ulong> deleteIds, List<ulong> limitOverIds, List<ulong> receiveIds, List<MyPagePresentListCellData> reqCellDataList, MyPagePresentListPopup.TypeTab tabType, List<ConvertedEntityList> convertedList)
		{
		}

		private MyPagePresentListCellData[] GetCellDataListFromPresentIds(List<ulong> resPresentIds, List<MyPagePresentListCellData> reqCellDataList)
		{
			return null;
		}

		private MyPagePresentListCellData[] GetCellDataListFromConvertedList(List<ConvertedEntityList> convertedList, List<ulong> resPresentIds, List<MyPagePresentListCellData> reqCellDataList)
		{
			return null;
		}

		private MyPagePresentListCellData CreateReceivedCellData(ConvertedEntityList convertedItem)
		{
			return null;
		}

		private void LoadNoReceivePresentList(MyPagePresentListCellData[] presentCellDataList)
		{
		}

		private void LoadReceivePresentList(MyPagePresentListCellData[] presentCellDataList)
		{
		}

		private void OnPressedSceneButtonCallback(MyPagePresentListPopup.NextScenePattern nextScenePattern)
		{
		}
	}
}
