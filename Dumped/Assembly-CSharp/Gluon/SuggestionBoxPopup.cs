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
	public class SuggestionBoxPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/SuggestionBox/SuggestionBoxPopup";
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private Button okButton;
		[SerializeField]
		private UnityEngine.UI.Text okText;
		[SerializeField]
		private Button closeButton;
		[SerializeField]
		private UnityEngine.UI.Text closeText;
		[SerializeField]
		private InputField suggestionInput;
		[SerializeField]
		private UnityEngine.UI.Text inputPlaceHolder;
		[SerializeField]
		private UnityEngine.UI.Text inputCharText;
		[SerializeField]
		private UnityEngine.UI.Text maxCharText;
		[SerializeField]
		private UnityEngine.UI.Text selectCategoryText;
		private const int maxChar = 200;
		private int selectCategoryListIndex;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CommonPopup popup;
			public SuggestionBoxPopup __4__this;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _OnCloseButtonPressed_b__0();
			internal void _OnCloseButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public CommonPopup confirmPopup;
			public SuggestionBoxPopup __4__this;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _OnOkButtonPressed_b__0();
			internal void _OnOkButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_1
		{
			// Fields
			public CommonPopup resultPopup;
			public __c__DisplayClass16_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass16_1();
	
			// Methods
			internal void _OnOkButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public UnityAction successCallback;
			public Action<SuggestionGetCategoryListResponse> __9__1;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _RequestSuggestionGetCategoryList_b__0();
			internal void _RequestSuggestionGetCategoryList_b__1(SuggestionGetCategoryListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public string message;
			public int cateoryId;
			public UnityAction successCallback;
			public Action<SuggestionSetResponse> __9__1;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _RequestSuggestionSet_b__0();
			internal void _RequestSuggestionSet_b__1(SuggestionSetResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public UnityAction successCallback;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _CalledAfterLoginChecked_b__0();
			internal void _CalledAfterLoginChecked_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public DataManager.GameData<AtgenCategoryList> list;
			public DrumScrollPopup popup;
			public SuggestionBoxPopup __4__this;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _OnCategorySelectButtonPressed_b__0(int index, GameObject obj);
			internal void _OnCategorySelectButtonPressed_b__1();
		}
	
		// Constructors
		public SuggestionBoxPopup();
	
		// Methods
		public static SuggestionBoxPopup Create();
		public void InitSetting();
		public void OnCloseButtonPressed();
		public void OnOkButtonPressed();
		private bool IsInputTextValid(string inputText);
		public static string ConvertInvalidText(string inputText);
		public void OnValueChangedSuggestion(string text);
		public void OnEndEditSuggestion(string text);
		private void SetInputChar(int count);
		public static void RequestSuggestionGetCategoryList(UnityAction successCallback);
		private void RequestSuggestionSet(string message, int cateoryId, UnityAction successCallback);
		private static void CalledAfterLoginChecked(UnityAction successCallback);
		private static void OnError(ErrorType errorType, int resultCode);
		public void OnCategorySelectButtonPressed();
	}
}
