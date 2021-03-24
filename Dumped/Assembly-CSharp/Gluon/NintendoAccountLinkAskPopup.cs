/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NintendoAccountLinkAskPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/TitleMenu/NintendoAccountLinkAskPopupPreIn";
		private const string prefsKeyNotDisplayTodaySettingKey = "NALinkAskNotDisplayTodaySetting";
		[SerializeField]
		private Toggle notDisplayTodayToggle;
		[SerializeField]
		private PointerEventHandler okButtonHandler;
		[SerializeField]
		private PointerEventHandler cancelButtonHandler;
		private Action onNALinkSucceed;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__11_0;
			public static Action<ErrorType, int> __9__11_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnFaqButton_b__11_0();
			internal void _OnFaqButton_b__11_1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public CommonPopup popup;
			public NintendoAccountLinkAskPopup __4__this;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _CreateLinkNintendoAccountSucceedPopup_b__1();
		}
	
		// Constructors
		public NintendoAccountLinkAskPopup();
	
		// Methods
		public static bool IsAsk();
		private static int GetCurrentDays();
		public static NintendoAccountLinkAskPopup Create(Action onNALinkSucceed);
		private void Setup(Action onNALinkSucceed);
		public void OnAccountButton();
		public void OnFaqButton();
		private void CreateLinkNintendoAccountSucceedPopup();
		private void OpenLoadingPopup();
		private void CloseLoadingPopup();
		[CompilerGenerated]
		private void _Setup_b__9_0();
		[CompilerGenerated]
		private void _Setup_b__9_1();
		[CompilerGenerated]
		private void _CreateLinkNintendoAccountSucceedPopup_b__12_0(UserLinkedNAccountResponse res);
	}
}
