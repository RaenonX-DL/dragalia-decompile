/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InquiryMessageListPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageListPopup";
		[SerializeField]
		private InquiryMessageListController listController;
		[SerializeField]
		private DragEventScrollRect scrollRect;
		[SerializeField]
		private GameObject scrollCell;
		[SerializeField]
		private UnityEngine.UI.Text noInfoText;
		[SerializeField]
		private TabBase typeTab;
		private List<InquiryMessageListCellData> cellDataList;
		private int pagerIndex;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<InquiryMessageListCellData> __9__10_0;
			public static Action<InquiryDetailResponse> __9__11_0;
			public static Action<ErrorType, int> __9__11_1;
			public static Action<ErrorType, int> __9__14_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _UpdateMessageList_b__10_0(InquiryMessageListCellData a, InquiryMessageListCellData b);
			internal void _OnListClicked_b__11_0(InquiryDetailResponse res);
			internal void _OnListClicked_b__11_1(ErrorType errorType, int resultCode);
			internal void _OnUpdateButtonPressed_b__14_1(ErrorType errorType, int resultCode);
		}
	
		// Constructors
		public InquiryMessageListPopup();
	
		// Methods
		public static InquiryMessageListPopup Create();
		public void InitSetting();
		private void UpdateMessageList();
		private void OnListClicked(string opinion_id);
		public void OnOkButtonPressed();
		public void OnCloseButtonPressed();
		public void OnUpdateButtonPressed();
		private void OnSelectedTypeTab(int typeIndex);
		[CompilerGenerated]
		private void _OnUpdateButtonPressed_b__14_0(InquiryTopResponse res);
	}
}
