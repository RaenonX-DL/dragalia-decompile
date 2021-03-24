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
	public class GuildMatchingRoomInvitePopup : PopupBase
	{
		// Fields
		[SerializeField]
		private QuestResultMultiFriendList playerInfo;
		private MatchingService.Player player;
		private CommonFriendListCellData commonFriendListCellData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _CreateErrorPopup_b__0();
		}
	
		// Constructors
		public GuildMatchingRoomInvitePopup();
	
		// Methods
		public static void Create(ulong viewerId, AtgenSupportUserDataDetail support, bool isGuildPopup = true);
		private void SetPlayerInfo(MatchingService.Player player, AtgenSupportUserDataDetail support);
		private void onRequestButton(int index);
		private CommonFriendListCellData GetCommonFriendListCellData(UserSupportList support, bool isFriend, bool isFriendApplying);
		private void OnClose(bool onClose);
		private void OnInviteButton(int index);
		public static void CreateErrorPopup();
	}
}
