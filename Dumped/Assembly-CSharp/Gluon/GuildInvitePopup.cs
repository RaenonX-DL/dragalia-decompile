/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildInvitePopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform guildInfoParent;
		[SerializeField]
		private CommonSettingToggleBase[] inviteMessageToggles;
		[SerializeField]
		private Transform playerInfoParent;
		private GuildInfoCellData guildInfo;
		private GuildModel.MemberInfo playerInfo;
		private const string prefabPath = "Prefabs/OutGame/Guild/GuildInvitePopup";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public CommonPopup commonPopup;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _OnInviteButtonPressed_b__1();
		}
	
		// Constructors
		public GuildInvitePopup();
	
		// Methods
		public static GuildInvitePopup Create();
		public void Setup(GuildInfoCellData guildInfo, GuildModel.MemberInfo playerInfo);
		private void SetGuildInfoCell(GuildInfoCellData guildInfo);
		private void SetPlayerInfo(GuildModel.MemberInfo playerInfo);
		public void OnToggleChanged(int num);
		public void OnInviteButtonPressed();
		private int GetMessageId();
		[CompilerGenerated]
		private void _OnInviteButtonPressed_b__11_0(GuildInviteInviteSendResponse responce);
	}
}
