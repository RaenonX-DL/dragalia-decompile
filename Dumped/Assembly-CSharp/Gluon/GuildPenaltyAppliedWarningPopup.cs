/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildPenaltyAppliedWarningPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private HyperLinkText content;
		[SerializeField]
		private RectTransform rectTransform;
		[SerializeField]
		private UnityEngine.UI.Text deletedContentSectionComment;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildPenaltyAppliedWarningPopup";
		private const string RegexURL = "https?://(?:[!-~]+\\.)+[!-~]+";
		private readonly string textColor;
		private Action onClose;
		private const float en_us_add_X = 0f;
		private const float en_us_add_Y = -0.8f;
		private const float zn_cn_add_Y = 1.6f;
		private const float en_us_default_X = 0f;
		private const float en_us_default_Y = -2f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public Action onDone;
	
			// Nested types
			private struct __CreateIfNeededAsync_b__0_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass12_0 __4__this;
				private TaskAwaiter<LoginPenaltyConfirmResponse> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal async void _CreateIfNeededAsync_b__0();
		}
	
		// Constructors
		public GuildPenaltyAppliedWarningPopup();
	
		// Methods
		public static bool CreateIfNeededAsync(Action onDone);
		public static GuildPenaltyAppliedWarningPopup Create(string content, int penaltyTextType, Action onClose);
		private void Awake();
		public void OnCloseButtonPressed();
		public void OnHyperLinkClick(string url);
	}
}
