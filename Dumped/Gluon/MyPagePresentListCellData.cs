using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class MyPagePresentListCellData
	{
		public string itemName;

		public MyPagePresentListPopup.ItemCategory itemCategory;

		public MyPagePresentListPopup.TypeTab type;

		public PresentDetailList presentData;

		public PresentHistoryList historyData;

		public UnityAction<MyPagePresentListCellData> detailCallback;

		public UnityAction<MyPagePresentListCellData, Canvas[]> iconLongPressedCallback;
	}
}
