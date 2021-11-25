using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FaqPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/Inquiry/FaqPopup";

		[SerializeField]
		private Rect margin;

		[SerializeField]
		private RectTransform popupRect;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text noInfoText;

		private readonly Localize.TextId webViewTitleTextId;

		private readonly string webViewUrlFunctionName;

		private const string urlParameterForNoTransition = "?page=title";

		private void Awake()
		{
		}

		public static FaqPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		private void SetMargin()
		{
		}

		public void WebMessageCallBack(string msg)
		{
		}

		public void OnOkButtonPressed()
		{
		}

		private void OnInquiryTopRequestSuccess(InquiryTopResponse res)
		{
		}

		private void OnHttpError(ErrorType errorType, int resultCode)
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
