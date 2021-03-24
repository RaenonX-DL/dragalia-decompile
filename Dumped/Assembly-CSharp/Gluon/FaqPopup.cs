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
	public class FaqPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Inquiry/FaqPopup";
		[SerializeField]
		private Rect margin;
		[SerializeField]
		private RectTransform popupRect;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text noInfoText;
		private readonly Localize.TextId webViewTitleTextId;
		private readonly string webViewUrlFunctionName;
		private const string urlParameterForNoTransition = "?page=title";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public CommonPopup popup;
			public FaqPopup __4__this;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _InitSetting_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _WebMessageCallBack_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public FaqPopup __4__this;
			public UnityAction sendInquiryTopRequest;
			public Action<InquiryTopResponse> __9__2;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _OnOkButtonPressed_b__0();
			internal void _OnOkButtonPressed_b__2(InquiryTopResponse res);
			internal void _OnOkButtonPressed_b__1();
			internal void _OnOkButtonPressed_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__15_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnHttpError_b__15_0();
		}
	
		// Constructors
		public FaqPopup();
	
		// Methods
		private void Awake();
		public static FaqPopup Create();
		public void InitSetting();
		private void SetMargin();
		public void WebMessageCallBack(string msg);
		public void OnOkButtonPressed();
		private void OnInquiryTopRequestSuccess(InquiryTopResponse res);
		private void OnHttpError(ErrorType errorType, int resultCode);
		public void OnCloseButtonPressed();
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _InitSetting_b__10_0(string err);
	}
}
