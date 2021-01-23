/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildChatView : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private GuildChatTableViewController tableView;
		[SerializeField]
		private DragEventScrollRect scrolRect;
		[CompilerGenerated]
		private List<GuildChatModel.ContentType> _enableContentType_k__BackingField;
		[SerializeField]
		public CustomInputField textField;
		[SerializeField]
		private Button sendButton;
		[SerializeField]
		private GameObject pageDownButton;
		[SerializeField]
		private float pageDownTimeMinimum;
		[SerializeField]
		private float pageDownTimeMagnification;
		[SerializeField]
		private Ease pageDownEaseType;
		[SerializeField]
		private float newChatAppearTime;
		[SerializeField]
		private Ease newChatAppearEaseType;
		[SerializeField]
		private float scrollBottomSpace;
		[SerializeField]
		private float pageDownButtonSpace;
		[SerializeField]
		private GameObject loadingObject;
		[SerializeField]
		private GameObject newMessageObject;
		private float pollChatInterval;
		private MatchingStampPopup stampPopup;
		private GuildChatModel guildChatModel;
		private float pollingIntervalCount;
		private bool isPollingEnable;
		private bool isViewingLatestChat;
		private Tweener scrollTweener;
		private readonly string stampVoice;
		private bool isOpenStampPopup;
		private bool isLoading;
		private Canvas _canvas;
	
		// Properties
		[SerializeField]
		private List<GuildChatModel.ContentType> enableContentType { [CompilerGenerated] get; [CompilerGenerated] set; }
		private Canvas canvas { get; }
	
		// Nested types
		[CompilerGenerated]
		private struct _PollChat_d__36 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildChatView __4__this;
			private TaskAwaiter<GuildChatGetNewMessageListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _GetPastLog_d__37 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildChatView __4__this;
			private TaskAwaiter<GuildChatGetOldMessageListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _PostChat_d__40 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildChatView __4__this;
			public string text;
			public Action onSucsess;
			private TaskAwaiter<GuildChatPostMessageTextResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _PostStamp_d__41 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildChatView __4__this;
			public int stampId;
			private TaskAwaiter<GuildChatPostMessageStampResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public GuildChatView __4__this;
			public bool isNew;
			public bool isFirst;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _RefreshChat_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public GuildChatView __4__this;
			public bool isNew;
			public bool isFirst;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal bool _UpdateTableViewAfterAnimation_b__0();
			internal void _UpdateTableViewAfterAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateTableViewAfterAnimation_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GuildChatView __4__this;
			public bool isNew;
			public bool isFirst;
			private __c__DisplayClass45_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateTableViewAfterAnimation_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartScrollDown_d__53 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GuildChatView __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartScrollDown_d__53(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public Scrollbar scrollBar;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _GetScrollTweener_b__0(float v);
		}
	
		// Constructors
		public GuildChatView();
	
		// Methods
		public static GuildChatView Create(Transform parent, List<GuildChatModel.ContentType> filter);
		private void Start();
		private void Update();
		private void ResetPollingIntervalCount();
		private bool IsExistPopup();
		private async void PollChat();
		private async void GetPastLog();
		public void StartPoling();
		public void StopPoling();
		public async void PostChat(string text, Action onSucsess = null);
		public async void PostStamp(int stampId);
		private void LoadChat(bool isNew, bool isFirst = false, bool isDisplayNewMessage = true);
		private void RefreshChat(bool isNew, bool isFirst = false);
		private void UpdateTableView(bool isNew, bool isFirst);
		[IteratorStateMachine]
		private IEnumerator UpdateTableViewAfterAnimation(bool isNew, bool isFirst);
		public void OnStampButtonPressed();
		private void OnClickStamp(int stampId);
		public void OnSendButtonPressed();
		private void UpdateSendButton();
		private void CheckViewingLatestChatFlag();
		private void CheckPageDownButtonActive();
		private void SetPageDownButtonActive(bool isActive);
		[IteratorStateMachine]
		public IEnumerator StartScrollDown();
		public void OnPageDownPressed();
		private Tweener GetScrollTweener(Ease ease, float time);
		private void KillScrollTweener();
		private bool IsTween();
		private void SetLoadingObject(bool isActive);
		private void SetNewMessageObject(bool isActive);
		private void OnDestroy();
		[CompilerGenerated]
		private void _Start_b__32_0();
		[CompilerGenerated]
		private void _Start_b__32_1();
		[CompilerGenerated]
		private void _Start_b__32_2();
		[CompilerGenerated]
		private void _OnSendButtonPressed_b__48_0();
	}
}
