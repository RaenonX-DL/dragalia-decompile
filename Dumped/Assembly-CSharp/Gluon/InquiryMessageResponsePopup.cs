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
	public class InquiryMessageResponsePopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageResponsePopup";
		[SerializeField]
		private Button okButton;
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
		[SerializeField]
		private LayoutElement inquiryDetailInputBaseLayout;
		[SerializeField]
		private InputField inquiryDetailInput;
		[SerializeField]
		private UnityEngine.UI.Text inputPlaceHolder;
		[SerializeField]
		private UnityEngine.UI.Text dummyText;
		[SerializeField]
		private UnityEngine.UI.Text inputCharText;
		[SerializeField]
		private UnityEngine.UI.Text maxCharText;
		private const int maxChar = 1000;
		private InquiryDetailResponse inquiryDetail;
	
		// Properties
		public string Detail { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public CommonPopup popup;
			public InquiryMessageResponsePopup __4__this;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _OnCloseButtonPressed_b__0();
			internal void _OnCloseButtonPressed_b__1();
		}
	
		// Constructors
		public InquiryMessageResponsePopup();
	
		// Methods
		public static InquiryMessageResponsePopup Create();
		public void InitSetting(InquiryDetailResponse initResponse, string initDetail);
		private void SetInputChar(int count);
		private void UpdateOkButtonState();
		public void OnOKButtonPressed();
		public void OnCloseButtonPressed();
		public void OnValueChangedDetail(string text);
		public void OnEndEditDetail(string text);
	}
}
