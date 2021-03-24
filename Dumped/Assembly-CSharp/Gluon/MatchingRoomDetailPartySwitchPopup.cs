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
	public class MatchingRoomDetailPartySwitchPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private RectTransform playerInfoRoot;
		[SerializeField]
		private Image emblemIcon;
		[SerializeField]
		private UnityEngine.UI.Text userName;
		[SerializeField]
		private UnityEngine.UI.Text userLevel;
		[SerializeField]
		private UnityEngine.UI.Text maxPower;
		[Header]
		[SerializeField]
		public GameObject guildGO;
		public UnityEngine.UI.Text guildNameText;
		public RawImage guildEmblem;
		[SerializeField]
		private QuestResultMultiFriendList playerInfo1;
		[SerializeField]
		private QuestResultMultiFriendList playerInfo2;
		public UnityEngine.UI.Text partyPower1;
		public UnityEngine.UI.Text partyPower2;
		[SerializeField]
		private Button friendRequestButton;
		public Button guildInviteButton;
		public float playerInfoPositionYForNoInviteButton;
		private MatchingService.Player player;
		private CommonFriendListCellData commonFriendListCellData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _CreateErrorPopup_b__0();
		}
	
		// Constructors
		public MatchingRoomDetailPartySwitchPopup();
	
		// Methods
		public static void Create(MatchingService.Player player, AtgenSupportUserDataDetail support, int memberIndex);
		public static void CreateSelf(MatchingService.Player player, int memberIndex);
		private void SetSelfInfo(MatchingService.Player player, int memberIndex);
		private void SetCharaInfo(MatchingService.Player player, AtgenSupportUserDataDetail support, int memberIndex);
		public void onRequestButton();
		private CommonFriendListCellData GetCommonFriendListCellData(UserSupportList support, bool isFriend, bool isFriendApplying);
		private void OnClose(bool onClose);
		public void OnInviteButton(int index);
		public static void CreateErrorPopup();
		private void SetSpriteNameData(int playerAnotherNameId);
		private void SetGuildData(int guildId, string guildName, int guildEmblemId, bool isPenaltyGuildName);
	}
}
