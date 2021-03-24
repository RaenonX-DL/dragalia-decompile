/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildMemberAdminPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform memberCellParent;
		[Header]
		[SerializeField]
		public GameObject assignSubMasterGO;
		public GameObject dismissSubMasterGO;
		private GuildMemberTableViewCell cell;
		private GuildModel.MemberInfo data;
		private GuildModel.MemberInfo subMasterData;
		private Action onAnyActionDone;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildMemberAdminPopup";
	
		// Nested types
		[CompilerGenerated]
		private struct __OnAssignAsMasterButtonPressed_b__10_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberAdminPopup __4__this;
			private TaskAwaiter<GuildUpdateGuildPositionTypeResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct __OnDismissSubMasterButtonPressed_b__11_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberAdminPopup __4__this;
			private TaskAwaiter<GuildUpdateGuildPositionTypeResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct __OnFireMemberButtonPressed_b__12_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberAdminPopup __4__this;
			private TaskAwaiter<GuildDropMemberResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct __OnAssignAsSubMasterButtonPressed_b__13_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildMemberAdminPopup __4__this;
			private TaskAwaiter<GuildUpdateGuildPositionTypeResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GuildMemberAdminPopup();
	
		// Methods
		public static GuildMemberAdminPopup Create(GuildModel.MemberInfo data, Action onAnyActionDone, GuildModel.MemberInfo currentSubMasterData);
		protected override void Start();
		public void OnAssignAsMasterButtonPressed();
		public void OnDismissSubMasterButtonPressed();
		public void OnFireMemberButtonPressed();
		public void OnAssignAsSubMasterButtonPressed();
		[CompilerGenerated]
		private async void _OnAssignAsMasterButtonPressed_b__10_0();
		[CompilerGenerated]
		private void _OnAssignAsMasterButtonPressed_b__10_1();
		[CompilerGenerated]
		private async void _OnDismissSubMasterButtonPressed_b__11_0();
		[CompilerGenerated]
		private void _OnDismissSubMasterButtonPressed_b__11_1();
		[CompilerGenerated]
		private async void _OnFireMemberButtonPressed_b__12_0();
		[CompilerGenerated]
		private void _OnFireMemberButtonPressed_b__12_1();
		[CompilerGenerated]
		private async void _OnAssignAsSubMasterButtonPressed_b__13_0();
		[CompilerGenerated]
		private void _OnAssignAsSubMasterButtonPressed_b__13_2();
		[CompilerGenerated]
		private void _OnAssignAsSubMasterButtonPressed_b__13_1();
	}
}
