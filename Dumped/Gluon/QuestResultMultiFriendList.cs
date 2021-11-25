using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultMultiFriendList : MonoBehaviour
	{
		[SerializeField]
		private GameObject battleFriendIcon;

		[SerializeField]
		private CommonIcon friendLeaderCommonIcon;

		[SerializeField]
		private Transform friendLeaderCommonIconListSortDecoTrans;

		[SerializeField]
		private Text charaNameText;

		[SerializeField]
		private Image emblemIcon;

		[SerializeField]
		private Text userName;

		[SerializeField]
		private Text userLevel;

		[SerializeField]
		private Text maxPower;

		[SerializeField]
		private Text manaPointText;

		[SerializeField]
		private GameObject manaUI;

		[SerializeField]
		private Button requestButton;

		public Button inviteButton;

		[SerializeField]
		private Text plusText;

		[SerializeField]
		private GameObject abilityCrestPanel;

		public UnityAction<int> onRequest;

		public UnityAction<int> onInvite;

		private int index;

		[SerializeField]
		[Header("Guild")]
		public GameObject guildGO;

		public Text guildNameText;

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

		private int partyMemberIndex;

		private int matchingMemberIndex;

		public const string emblemAtlasPath = "Prefabs/OutGame/Common/Emblem";

		public const string emblemName = "Icon_Profile_header_{0:D2}";

		public void Initialize(int listIndex, MatchingService.Player player, UserSupportList[] helper_list, AtgenHelperDetailList[] helper_detail_list)
		{
		}

		public void Setup(int listIndex, MatchingService.Player player, UserSupportList support, AtgenHelperDetailList supportDetail)
		{
		}

		private void SetCharaData(MatchingRoomPlayerData data, MatchingRoomDetailData charaData)
		{
		}

		private void SetExAbility(MatchingRoomPlayerData data)
		{
		}

		private void SetExAbility(List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas)
		{
		}

		private void SetAmulet(int abilityCrestNum, MatchingRoomPlayerData data, UnitDetailModel.AmuletDetailData abilityCrestData, int slotNum, int maxSlotCount)
		{
		}

		public void Setup(MatchingService.Player player, AtgenSupportUserDataDetail support)
		{
		}

		public void SetupForPartySwitch(MatchingService.Player player, MatchingRoomDetailData charaData, int partyMemberIndex, int matchingMemberIndex, List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas)
		{
		}

		private void SetPlayerData(MatchingService.Player player, MatchingRoomDetailData charaData)
		{
		}

		private void SetSupportData(AtgenSupportUserDataDetail support)
		{
		}

		private void SetSpriteNameData(int playerAnotherNameId)
		{
		}

		private void SetManaData(AtgenHelperDetailList supportDetail)
		{
		}

		private void SetGuildData(UserSupportList support)
		{
		}

		private void SetPlusText(MatchingRoomDetailData charaData)
		{
		}

		public void OnRequestButtonPressed()
		{
		}

		public void OnInviteButtonPressed()
		{
		}

		public void ButtonActive(bool enabled)
		{
		}

		public void OnDetailButtonPressed(int type)
		{
		}

		public void OnExAbilityButtonPressed()
		{
		}
	}
}
