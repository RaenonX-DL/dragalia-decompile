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
	public class GuildOptionPopup : PopupBase
	{
		// Fields
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildOptionPopup";
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text guildNameText;
		public UnityEngine.UI.Text guildMottoText;
		public UnityEngine.UI.Text guildNoticeText;
		public UnityEngine.UI.Text guildIdText;
		public RawImage guildEmblemImage;
		[Header]
		[SerializeField]
		public CommonSettingToggleBase[] approvalRequirementToggles;
		public CommonSettingToggleBase[] activityPreferenceToggles;
		[Header]
		[SerializeField]
		public CommonIcon icon;
		[Header]
		[SerializeField]
		public TabBase pushTab;
		public TabBase nativePushTab;
		[Header]
		[SerializeField]
		public TabBase inviteTab;
		[Header]
		[SerializeField]
		public TabBase voiceOverTab;
		[Header]
		[SerializeField]
		public GameObject nameGO;
		public GameObject mottoGO;
		public GameObject noticeGO;
		public GameObject emblemGO;
		public GameObject approvalRequirementGO;
		public GameObject activityPreferenceGO;
		public GameObject iconGO;
		public GameObject pushGO;
		public GameObject nativePushGO;
		public GameObject voiceOverGO;
		public GameObject guildIdGO;
		public GameObject disbandGuildGO;
		public GameObject leaveGuildGO;
		[Header]
		[SerializeField]
		public Button okButton;
		[Header]
		[SerializeField]
		private GameObject inviteBadge;
		private GuildModel.GuildOption initOption;
		private GuildModel.GuildOption option;
		private GuildModel.ProfileIconData initProfileIconData;
		private GuildModel.ProfileIconData profileIconData;
		private Type popupType;
		private Action onOptionDone;
		private Action onStopPollingAction;
	
		// Nested types
		public enum Type
		{
			GuildCreation = 0,
			GuildMasterEdit = 1,
			GuildMemberEdit = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__48_1;
			public static Action __9__49_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnDisbandGuildButtonPressed_b__48_1();
			internal void _OnLeaveGuildButtonPressed_b__49_1();
		}
	
		[CompilerGenerated]
		private struct _OnApplyButtonPressed_d__53 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildOptionPopup __4__this;
			private TaskAwaiter<GuildEstablishResponse> __u__1;
			private TaskAwaiter<GuildUpdateUserSettingResponse> __u__2;
			private TaskAwaiter<GuildUpdateGuildSettingResponse> __u__3;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct __OnDisbandGuildButtonPressed_b__48_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildOptionPopup __4__this;
			private TaskAwaiter<GuildDisbandResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct __OnLeaveGuildButtonPressed_b__49_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildOptionPopup __4__this;
			private TaskAwaiter<GuildResignResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GuildOptionPopup();
	
		// Methods
		public static GuildOptionPopup Create(GuildModel.Occupation occupation, Action onOptionDone = null, Action onStopPollingAction = null);
		protected override void Start();
		public void SetupForCreation();
		public void SetupForMasterEdit();
		public void SetupForMemberEdit();
		private void ApplyData();
		private void ConvertOptionToDeletedRaw();
		public void OnNameChangeButtonPressed();
		public void OnMottoChangeButtonPressed();
		public void OnNoticeChangeButtonPressed();
		public void OnEmblemChangeButtonPressed();
		public void OnProfileIconButtonPressed();
		public void OnDisbandGuildButtonPressed();
		public void OnLeaveGuildButtonPressed();
		private void OnStopPolling();
		public void OnCopyIdButtonPressed();
		private void Update();
		public async void OnApplyButtonPressed();
		public void OnCheckInviteButtonPressed();
		[CompilerGenerated]
		private void _OnNameChangeButtonPressed_b__43_0(string x);
		[CompilerGenerated]
		private void _OnMottoChangeButtonPressed_b__44_0(string x);
		[CompilerGenerated]
		private void _OnNoticeChangeButtonPressed_b__45_0(string x);
		[CompilerGenerated]
		private void _OnEmblemChangeButtonPressed_b__46_0(int x);
		[CompilerGenerated]
		private void _OnProfileIconButtonPressed_b__47_0(GuildModel.ProfileIconData x);
		[CompilerGenerated]
		private async void _OnDisbandGuildButtonPressed_b__48_0();
		[CompilerGenerated]
		private async void _OnLeaveGuildButtonPressed_b__49_0();
	}
}
