/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InquiryMessageDetailPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageDetailPopup";
		[SerializeField]
		private UnityEngine.UI.Text inquiryType;
		[SerializeField]
		private UnityEngine.UI.Text inquiryOccuredAt;
		[SerializeField]
		private InquiryMessageDetailComment userReplyBase;
		[SerializeField]
		private InquiryMessageDetailComment adminReplyBase;
		[SerializeField]
		private DragEventScrollRect scrollRect;
		private InquiryDetailResponse response;
	
		// Constructors
		public InquiryMessageDetailPopup();
	
		// Methods
		public static InquiryMessageDetailPopup Create();
		public void InitSetting(InquiryDetailResponse res);
		public void OnOKButtonPressed();
		public void OnCloseButtonPressed();
	}
}
