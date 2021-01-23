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
	public class GuildMemberTableViewCell : TableViewCell<Gluon.GuildModel.MemberInfo>
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text levelText;
		public UnityEngine.UI.Text playerNameText;
		public UnityEngine.UI.Text lastLoginText;
		public UnityEngine.UI.Text maxPowerText;
		[Header]
		[SerializeField]
		public GameObject masterGO;
		public GameObject subMasterGO;
		[Header]
		[SerializeField]
		public GameObject adminButtonGO;
		public GameObject approveButtonGO;
		public GameObject rejectButtonGO;
		public GameObject cancelInviteButtonGO;
		[Header]
		[SerializeField]
		public GameObject waitingInviteGO;
		private GuildMemberTableViewController _controller;
		[CompilerGenerated]
		private Action _onRequestLatestData_k__BackingField;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildMemberTableViewCell";
	
		// Properties
		public GuildMemberTableViewController controller { get; set; }
		public Action onRequestLatestData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private struct _OnApproveButtonPressed_d__25 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberTableViewCell __4__this;
			private TaskAwaiter<GuildJoinReplyResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _OnRejectButtonPressed_d__26 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberTableViewCell __4__this;
			private TaskAwaiter<GuildJoinReplyResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _OnIconPressed_d__28 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberTableViewCell __4__this;
			private TaskAwaiter<FriendGetSupportCharaDetailResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GuildMemberTableViewCell();
	
		// Methods
		public override void UpdateContent(GuildModel.MemberInfo data);
		private void ApplyOnlineStatus();
		private void OnControllerAssigned();
		public void OnAdminButtonPressed();
		public async void OnApproveButtonPressed();
		public async void OnRejectButtonPressed();
		public void OnCancelInviteButtonPressed();
		public async void OnIconPressed();
		[CompilerGenerated]
		private void _OnApproveButtonPressed_b__25_0();
		[CompilerGenerated]
		private void _OnRejectButtonPressed_b__26_0();
		[CompilerGenerated]
		private void _OnCancelInviteButtonPressed_b__27_0(GuildInviteInviteCancelResponse res);
		[CompilerGenerated]
		private void _OnCancelInviteButtonPressed_b__27_1();
	}
}
