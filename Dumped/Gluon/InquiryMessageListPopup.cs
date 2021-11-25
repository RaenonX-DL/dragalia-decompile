using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryMessageListPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageListPopup";

		[SerializeField]
		private InquiryMessageListController listController;

		[SerializeField]
		private DragEventScrollRect scrollRect;

		[SerializeField]
		private GameObject scrollCell;

		[SerializeField]
		private Text noInfoText;

		[SerializeField]
		private TabBase typeTab;

		private List<InquiryMessageListCellData> cellDataList;

		private int pagerIndex;

		public static InquiryMessageListPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		private void UpdateMessageList()
		{
		}

		private void OnListClicked(string opinion_id)
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnUpdateButtonPressed()
		{
		}

		private void OnSelectedTypeTab(int typeIndex)
		{
		}
	}
}
