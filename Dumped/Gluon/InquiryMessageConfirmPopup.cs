using System;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryMessageConfirmPopup : PopupBase
	{
		public enum MessageType
		{
			Create,
			Response
		}

		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageConfirmPopup";

		[SerializeField]
		private GameObject createHead;

		[SerializeField]
		private Text inquiryTypeText;

		[SerializeField]
		private Text occurDatetime;

		[SerializeField]
		private Text detailTitle;

		[SerializeField]
		private Text sendText;

		private int inquiryIndex;

		private DateTime occurTime;

		private string detailText;

		private InquiryDetailResponse inquiryDetail;

		[SerializeField]
		[Header("Callbacks")]
		public UnityEvent okButtonPressed;

		private MessageType messageType;

		public string DetailText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static InquiryMessageConfirmPopup Create()
		{
			return null;
		}

		public void InitSetting(int InquiryIndex, DateTime occurTime, string detailText, MessageType messageType, [Optional] InquiryDetailResponse inquiryDetail)
		{
		}

		public void OnOKButtonPressed()
		{
		}

		private void SendInquiry()
		{
		}

		private void ReplyInquiry()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
