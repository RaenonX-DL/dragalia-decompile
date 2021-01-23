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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MenuHelpPopup : CommonPopup, ICustomMessage
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text helpText;
		[SerializeField]
		private UnityEngine.UI.Text suggestionBoxText;
		[SerializeField]
		private UnityEngine.UI.Text faqText;
		[SerializeField]
		private Badge inquireBadge;
		public MenuPopup menuPopup;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__9_0;
			public static Action<InquiryTopResponse> __9__11_0;
			public static Action<ErrorType, int> __9__11_1;
			public static Action<SummonGetSummonHistoryResponse> __9__12_0;
			public static Action<ErrorType, int> __9__12_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnSuggestionBoxButtonPressed_b__9_0();
			internal void _OnInquiryButtonPressed_b__11_0(InquiryTopResponse res);
			internal void _OnInquiryButtonPressed_b__11_1(ErrorType errorType, int resultCode);
			internal void _OnSummonHistoryPressed_b__12_0(SummonGetSummonHistoryResponse res);
			internal void _OnSummonHistoryPressed_b__12_1(ErrorType errorType, int resultCode);
		}
	
		// Constructors
		public MenuHelpPopup();
	
		// Methods
		public static MenuHelpPopup Create();
		public void InitSetting();
		private void OnDisable();
		public void OnHelpButtonPressed();
		public void OnSuggestionBoxButtonPressed();
		public void OnFaqButtonPressed();
		public void OnInquiryButtonPressed();
		public void OnSummonHistoryPressed();
		public void UpdateBadge();
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
