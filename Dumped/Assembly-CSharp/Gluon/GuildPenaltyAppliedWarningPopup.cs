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
	public class GuildPenaltyAppliedWarningPopup : PopupBase
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text content;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildPenaltyAppliedWarningPopup";
		private Action onClose;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Action onDone;
	
			// Nested types
			private struct __CreateIfNeededAsync_b__0_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass3_0 __4__this;
				private TaskAwaiter<LoginPenaltyConfirmResponse> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal async void _CreateIfNeededAsync_b__0();
		}
	
		// Constructors
		public GuildPenaltyAppliedWarningPopup();
	
		// Methods
		public static bool CreateIfNeededAsync(Action onDone);
		public static GuildPenaltyAppliedWarningPopup Create(string content, Action onClose);
		public void OnCloseButtonPressed();
	}
}
