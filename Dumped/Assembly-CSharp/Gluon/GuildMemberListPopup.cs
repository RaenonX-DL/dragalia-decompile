/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildMemberListPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text titleText;
		[Header]
		[SerializeField]
		public TabBase tabView;
		public GameObject tabViewLine;
		private int activeTabIndex;
		[Header]
		[SerializeField]
		public GuildMemberTableViewController memberController;
		public GuildMemberTableViewController waitingController;
		public GuildMemberTableViewController invitingController;
		[Header]
		[SerializeField]
		public Button rejectAllButton;
		public GameObject rejectAllGO;
		[Header]
		[SerializeField]
		public Badge waitingListBadge;
		public GameObject invitingListBadge;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildMemberListPopup";
		private TabType currentTab;
		private List<GuildModel.MemberInfo> memberDataList;
		private List<GuildModel.MemberInfo> waitingDataList;
		private List<GuildModel.MemberInfo> invitingDataList;
		private GuildModel.Occupation occupation;
		[SerializeField]
		private UnityEngine.UI.Text inviteNumText;
	
		// Nested types
		private enum TabType
		{
			Member = 0,
			Waiting = 1,
			Inviting = 2
		}
	
		[CompilerGenerated]
		private struct _CreateModule_d__19 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildModel.Occupation occupation;
			public UnityAction onClose;
			private TaskAwaiter<GuildGetGuildMemberDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestMemberList_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildGetGuildMemberDataResponse> __t__builder;
			private TaskAwaiter<GuildGetGuildMemberDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestWaitingList_d__22 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildGetGuildApplyDataResponse> __t__builder;
			public GuildMemberListPopup __4__this;
			private TaskAwaiter<GuildGetGuildApplyDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestInvitingList_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildInviteGetGuildInviteSendDataResponse> __t__builder;
			public GuildMemberListPopup __4__this;
			private TaskAwaiter<GuildInviteGetGuildInviteSendDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestUpdateMemberList_d__24 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberListPopup __4__this;
			private CanvasGroup _canvasGroup_5__2;
			private TaskAwaiter<GuildGetGuildMemberDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestUpdateWaitingList_d__25 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberListPopup __4__this;
			public bool updateData;
			private CanvasGroup _canvasGroup_5__2;
			private TaskAwaiter<GuildGetGuildApplyDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestUpdateInvitingList_d__26 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberListPopup __4__this;
			public bool updateData;
			private CanvasGroup _canvasGroup_5__2;
			private TaskAwaiter<GuildInviteGetGuildInviteSendDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<GuildModel.MemberInfo, ulong> __9__27_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal ulong _OnRejectAllButtonPressed_b__27_0(GuildModel.MemberInfo x);
		}
	
		[CompilerGenerated]
		private struct _OnRejectAllButtonPressed_d__27 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberListPopup __4__this;
			private TaskAwaiter<GuildJoinReplyAllDenyResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class _EnterCoroutine_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GuildMemberListPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnterCoroutine_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GuildMemberListPopup();
	
		// Methods
		public static async void CreateModule(GuildModel.Occupation occupation, UnityAction onClose);
		private void SetupWithOccupation(GuildModel.Occupation occupation);
		private static async Task<GuildGetGuildMemberDataResponse> RequestMemberList();
		private async Task<GuildGetGuildApplyDataResponse> RequestWaitingList();
		private async Task<GuildInviteGetGuildInviteSendDataResponse> RequestInvitingList();
		private async void RequestUpdateMemberList();
		private async void RequestUpdateWaitingList(bool updateData = true);
		private async void RequestUpdateInvitingList(bool updateData = true);
		public async void OnRejectAllButtonPressed();
		private void Update();
		private void SetTitleText();
		protected override void Start();
		[IteratorStateMachine]
		private IEnumerator EnterCoroutine();
		[CompilerGenerated]
		private void _OnRejectAllButtonPressed_b__27_1();
		[CompilerGenerated]
		private void _Start_b__30_0();
		[CompilerGenerated]
		private void _Start_b__30_1();
		[CompilerGenerated]
		private void _EnterCoroutine_b__31_0(int index, bool isCalledBySystem);
	}
}
