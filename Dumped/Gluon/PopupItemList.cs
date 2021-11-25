using UnityEngine;

namespace Gluon
{
	public class PopupItemList : CommonPopup
	{
		public delegate void ListIconTapCall(GiftType buttonType, int inventoryId);

		public delegate void ContactToParent(int inventoryId, GiftType buttonType);

		public PopupIconListView popupIconListView;

		public GiftType showGiftType;

		public Canvas canvas;

		private PopupIconListData.IconListData[] iconDataList;

		public PopupItemList rootScene;

		public ContactToParent callBack;

		public void Initialize(PopupIconListData.IconListData[] list)
		{
		}

		public static PopupItemList CreateList(PopupIconListData.IconListData[] dataList)
		{
			return null;
		}

		public void DataSetup()
		{
		}

		public void SetRootScene()
		{
		}

		public void SetCallBack(ContactToParent setCallBack)
		{
		}

		public void ListIconPush(GiftType buttonType, int inventoryId)
		{
		}

		public void CallBackToParent(int inventoryId, GiftType buttonType)
		{
		}
	}
}
