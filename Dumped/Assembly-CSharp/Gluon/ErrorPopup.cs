/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UniRx.Async;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ErrorPopup : CommonPopup
	{
		// Fields
		public static bool isPopupOpened;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public ErrorPopup popup;
			public ErrorType errorType;
			public int resultCode;
			public Action onClosedCallback;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _CreateNetworkError_b__0();
			internal void _CreateNetworkError_b__1();
			internal void _CreateNetworkError_b__2();
			internal void _CreateNetworkError_b__4();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__3_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateNetworkError_b__3_3();
		}
	
		[CompilerGenerated]
		private struct _CreateTitleMaintenancePopup_d__4 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public TitleMaintenancePopup popup;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _OnMaintenanceTextSuccess_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_1
		{
			// Fields
			public CommonPopup errorpopup;
	
			// Constructors
			public __c__DisplayClass5_1();
	
			// Methods
			internal void _OnMaintenanceTextSuccess_b__1();
		}
	
		// Constructors
		public ErrorPopup();
		static ErrorPopup();
	
		// Methods
		private static string GetTitle(int resultCode);
		private static string GetMessage(int resultCode);
		public static ErrorPopup CreateNetworkError(ErrorType errorType, int resultCode, Action onClosedCallback = null);
		public static async void CreateTitleMaintenancePopup();
		public static void OnMaintenanceTextSuccess(MaintenanceGetTextResponse res);
		private void OnClose(ErrorType errorType, int resultCode, Action onClosedCallback);
		protected override void OnDestroy();
	}
}
