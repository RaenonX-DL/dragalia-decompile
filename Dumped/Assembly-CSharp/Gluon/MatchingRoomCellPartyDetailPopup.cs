/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomCellPartyDetailPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public MatchingRoomCellPartyDetailPopupCell originalCell;
		public Transform[] cellParents;
		private MatchingRoomCellPartyDetailPopupCell[] cells;
		[CompilerGenerated]
		private int _questId_k__BackingField;
		[SerializeField]
		private GameObject raidBoostButton;
		[SerializeField]
		private GameObject oneButtonObj;
		[SerializeField]
		private GameObject twoButtonObj;
		private ulong viewerId;
		private List<RaidBoostPopup.RaidBoostModel.CellData> raidBoostList;
		private List<RaidBoostPopup.RaidBoostModel.CellData> rareRaidBoostList;
		private const string popupPrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingRoomCellPartyDetailPopup";
	
		// Properties
		public int questId { [CompilerGenerated] private get; [CompilerGenerated] set; }
	
		// Constructors
		public MatchingRoomCellPartyDetailPopup();
	
		// Methods
		private void Awake();
		private new void Start();
		public static MatchingRoomCellPartyDetailPopup CreateWithMatchingData(MatchingRoomPlayerData data);
		private void InitWithMatchingData(MatchingRoomPlayerData data);
		public void OnPlayerInfoButton();
		public void OnCloseButton();
		public void OnPressedRaidPowerButton();
		[CompilerGenerated]
		private void _OnPlayerInfoButton_b__18_0(FriendGetSupportCharaDetailResponse responce);
	}
}
