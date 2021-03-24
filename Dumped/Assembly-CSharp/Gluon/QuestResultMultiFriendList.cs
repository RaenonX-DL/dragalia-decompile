/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultMultiFriendList : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject battleFriendIcon;
		[SerializeField]
		private CommonIcon friendLeaderCommonIcon;
		[SerializeField]
		private Transform friendLeaderCommonIconListSortDecoTrans;
		[SerializeField]
		private UnityEngine.UI.Text charaNameText;
		[SerializeField]
		private Image emblemIcon;
		[SerializeField]
		private UnityEngine.UI.Text userName;
		[SerializeField]
		private UnityEngine.UI.Text userLevel;
		[SerializeField]
		private UnityEngine.UI.Text maxPower;
		[SerializeField]
		private UnityEngine.UI.Text manaPointText;
		[SerializeField]
		private GameObject manaUI;
		[SerializeField]
		private Button requestButton;
		public Button inviteButton;
		[SerializeField]
		private UnityEngine.UI.Text plusText;
		[SerializeField]
		private GameObject abilityCrestPanel;
		public UnityAction<int> onRequest;
		public UnityAction<int> onInvite;
		private int index;
		[Header]
		[SerializeField]
		public GameObject guildGO;
		public UnityEngine.UI.Text guildNameText;
		public RawImage guildEmblem;
		[SerializeField]
		private CommonIcon dragonIcon;
		[SerializeField]
		private GameObject noDragonIcon;
		[SerializeField]
		private Transform dragonSortDecoTrans;
		[SerializeField]
		private CommonIcon weaponIcon;
		[SerializeField]
		private Transform weaponSortDecoTrans;
		[SerializeField]
		private CommonIcon[] amuletIcon;
		[SerializeField]
		private GameObject[] noAmuletMark;
		[SerializeField]
		private Transform[] amuletSortDecoTrans;
		[SerializeField]
		private Material blankMaterial;
		[SerializeField]
		private Image[] exAbility1Icons;
		[SerializeField]
		private Image[] exAbility2Icons;
		private MatchingRoomDetailData detailData;
		private CommonPartyPowerCalculateData[] multiPartyPowerCalculateDatas;
		private List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas;
		public const string emblemAtlasPath = "Prefabs/OutGame/Common/Emblem";
		public const string emblemName = "Icon_Profile_header_{0:D2}";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_1
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass54_1();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__1();
		}
	
		// Constructors
		public QuestResultMultiFriendList();
	
		// Methods
		public void Initialize(int listIndex, MatchingService.Player player, UserSupportList[] helper_list, AtgenHelperDetailList[] helper_detail_list);
		public void Setup(int listIndex, MatchingService.Player player, UserSupportList support, AtgenHelperDetailList supportDetail);
		private void SetCharaData(MatchingRoomPlayerData data, MatchingRoomDetailData charaData, int memberIndex);
		private void SetExAbility(MatchingRoomPlayerData data);
		private void SetExAbility(List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas);
		private void SetAmulet(int abilityCrestNum, MatchingRoomPlayerData data, int memberIndex, UnitDetailModel.AmuletDetailData abilityCrestData, int slotNum, int maxSlotCount);
		public void Setup(MatchingService.Player player, AtgenSupportUserDataDetail support);
		public void SetupSelfForPartySwitch(MatchingService.Player player, MatchingRoomDetailData charaData, int memberIndex, List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas);
		private void SetPlayerData(MatchingService.Player player, MatchingRoomDetailData charaData, int memberIndex);
		private void SetSupportData(AtgenSupportUserDataDetail support);
		private void SetSpriteNameData(int playerAnotherNameId);
		private void SetManaData(AtgenHelperDetailList supportDetail);
		private void SetGuildData(UserSupportList support);
		private void SetPlusText(MatchingRoomPlayerData data);
		public void OnRequestButtonPressed();
		public void OnInviteButtonPressed();
		public void ButtonActive(bool enabled);
		public void OnDetailButtonPressed(int type);
		public void OnExAbilityButtonPressed();
	}
}
