using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryMessageDetailPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageDetailPopup";

		[SerializeField]
		private Text inquiryType;

		[SerializeField]
		private Text inquiryOccuredAt;

		[SerializeField]
		private InquiryMessageDetailComment userReplyBase;

		[SerializeField]
		private InquiryMessageDetailComment adminReplyBase;

		[SerializeField]
		private DragEventScrollRect scrollRect;

		private InquiryDetailResponse response;

		public static InquiryMessageDetailPopup Create()
		{
			return null;
		}

		public void InitSetting(InquiryDetailResponse res)
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
