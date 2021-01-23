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
	public class LinkNintendoAccountMenu : CommonPopup
	{
		// Fields
		private const string path = "Prefabs/OutGame/DataTransition/LinkNintendoAccountMenu";
		private const string titleScene = "Title";
		private const string loadIndexScene = "LoadIndex";
		private UnityAction onCompleted;
		[SerializeField]
		private UnityEngine.UI.Text DataTransitionText;
		[SerializeField]
		private UnityEngine.UI.Text NotNow;
		[SerializeField]
		private UnityEngine.UI.Text TransitionByNA;
		[SerializeField]
		private UnityEngine.UI.Text Title;
	
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
			internal void _OnFAQButton_b__11_0();
			internal void _OnFAQButton_b__11_1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public TransitionTransitionByNAccountRequest req;
			public LinkNintendoAccountMenu __4__this;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _CreateSwitchNintendoAccountSucceedPopup_b__0(TransitionTransitionByNAccountResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _CreateAlreadyLinkToNAPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public LinkNintendoAccountMenu __4__this;
			public CommonPopup popup;
			public Action<EulaGetVersionResponse> __9__1;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _CreateTransitionAlreadyDonePopup_b__0();
			internal void _CreateTransitionAlreadyDonePopup_b__1(EulaGetVersionResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public LinkNintendoAccountMenu __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _CreateLinkNintendoAccountSucceedPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CommonPopup popup;
			public LinkNintendoAccountMenu __4__this;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _CreateLinkNintendoAccountInGameSucceedPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public UnityAction onCompleted;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _GetEulaVersion_b__0(EulaGetVersionResponse res);
		}
	
		// Constructors
		public LinkNintendoAccountMenu();
	
		// Methods
		public static void Create(UnityAction onCompleted, string transactionText);
		private static LinkNintendoAccountMenu CreateWithPrefabPath(string prefabPath, UnityAction onCompleted);
		public void OnCloseButton();
		public void OnFAQButton();
		public void OnAccountButton();
		private void CreateSwitchNintendoAccountSucceedPopup();
		private void CreateAlreadyLinkToNAPopup();
		private void OnError(ErrorType type, int code);
		public void CreateTransitionAlreadyDonePopup();
		private void CreateLinkNintendoAccountSucceedPopup();
		private void CreateLinkNintendoAccountInGameSucceedPopup();
		private static void GetEulaVersion(UnityAction onCompleted);
		private void OpenLoadingPopup();
		private void CloseLoadingPopup();
		[CompilerGenerated]
		private void _CreateLinkNintendoAccountInGameSucceedPopup_b__18_0(UserLinkedNAccountResponse res);
		[CompilerGenerated]
		private void _CreateLinkNintendoAccountInGameSucceedPopup_b__18_2();
	}
}
