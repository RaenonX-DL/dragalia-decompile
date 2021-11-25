using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryMessageResponsePopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageResponsePopup";

		[SerializeField]
		private Button okButton;

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

		[SerializeField]
		private LayoutElement inquiryDetailInputBaseLayout;

		[SerializeField]
		private InputField inquiryDetailInput;

		[SerializeField]
		private Text inputPlaceHolder;

		[SerializeField]
		private Text dummyText;

		[SerializeField]
		private Text inputCharText;

		[SerializeField]
		private Text maxCharText;

		private const int maxChar = 1000;

		private InquiryDetailResponse inquiryDetail;

		public string Detail => null;

		public static InquiryMessageResponsePopup Create()
		{
			return null;
		}

		public void InitSetting(InquiryDetailResponse initResponse, string initDetail)
		{
		}

		private void SetInputChar(int count)
		{
		}

		private void UpdateOkButtonState()
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnValueChangedDetail(string text)
		{
		}

		public void OnEndEditDetail(string text)
		{
		}
	}
}
