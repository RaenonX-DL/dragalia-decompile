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
	public class GuildInviteConfirmPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform guildInfoParent;
		[SerializeField]
		private UnityEngine.UI.Text inviteText;
		[SerializeField]
		private Transform playerInfoParent;
		[SerializeField]
		private GameObject cautionMessageObject;
		private Action onConfirmInvite;
		private GuildInfoCellData guildInfo;
		private GuildModel.MemberInfo playerInfo;
		private const string prefabPath = "Prefabs/OutGame/Guild/GuildInviteConfirmPopup";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public Action onApplyDone;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _Apply_b__0(GuildInviteInviteReplyResponse res);
		}
	
		// Constructors
		public GuildInviteConfirmPopup();
	
		// Methods
		public static GuildInviteConfirmPopup Create();
		public void Setup(GuildInfoCellData guildInfo, GuildModel.MemberInfo playerInfo, Action onConfirmInvite);
		private void SetGuildInfoCell(GuildInfoCellData guildInfo);
		private void SetInviteText(int num);
		private void SetPlayerInfo(GuildModel.MemberInfo playerInfo);
		private void SetCautionButtonState();
		public void OnInviteConfirmButtonPressed();
		private void Apply(GuildInfoCellData data, Action onApplyDone = null);
		[CompilerGenerated]
		private void _OnInviteConfirmButtonPressed_b__14_0();
		[CompilerGenerated]
		private void _OnInviteConfirmButtonPressed_b__14_1();
	}
}
