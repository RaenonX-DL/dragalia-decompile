/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InquiryMessageConfirmPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageConfirmPopup";
		[SerializeField]
		private GameObject createHead;
		[SerializeField]
		private UnityEngine.UI.Text inquiryTypeText;
		[SerializeField]
		private UnityEngine.UI.Text occurDatetime;
		[SerializeField]
		private UnityEngine.UI.Text detailTitle;
		[SerializeField]
		private UnityEngine.UI.Text sendText;
		private int inquiryIndex;
		private DateTime occurTime;
		private string detailText;
		private InquiryDetailResponse inquiryDetail;
		[Header]
		[SerializeField]
		public UnityEvent okButtonPressed;
		private MessageType messageType;
	
		// Properties
		public string DetailText { get; set; }
	
		// Nested types
		public enum MessageType
		{
			Create = 0,
			Response = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__19_1;
			public static Action<ErrorType, int> __9__20_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SendInquiry_b__19_1(ErrorType errorType, int resultCode);
			internal void _ReplyInquiry_b__20_1(ErrorType errorType, int resultCode);
		}
	
		// Constructors
		public InquiryMessageConfirmPopup();
	
		// Methods
		public static InquiryMessageConfirmPopup Create();
		public void InitSetting(int InquiryIndex, DateTime occurTime, string detailText, MessageType messageType, InquiryDetailResponse inquiryDetail = null);
		public void OnOKButtonPressed();
		private void SendInquiry();
		private void ReplyInquiry();
		public void OnCloseButtonPressed();
		[CompilerGenerated]
		private void _SendInquiry_b__19_0(InquirySendResponse res);
		[CompilerGenerated]
		private void _SendInquiry_b__19_2();
		[CompilerGenerated]
		private void _ReplyInquiry_b__20_0(InquiryReplyResponse res);
		[CompilerGenerated]
		private void _ReplyInquiry_b__20_2();
	}
}
