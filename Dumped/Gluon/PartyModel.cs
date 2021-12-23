using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class PartyModel : SingletonInBaseMonoBehaviour<PartyModel>
	{
		public enum PartySceneUnitStatusMode
		{
			Basic,
			Crest1,
			Crest2
		}

		public enum EquipMode
		{
			Dragon,
			Weapon,
			Amulet,
			Skill3,
			Skill4
		}

		public const int numOfCharactersInParty = 4;

		public const int maxPartyCountInGroup = 6;

		public const int maxPartyGroupCount = 9;

		public const string prefsKeyWeaponIconOrList = "Party/WeaponListViewIconOrList";

		public const string prefsKeyCrestIconOrList = "Party/CrestListViewIconOrList";

		public static PartySceneState nowSceneState;

		public static PartySceneState prevSceneState;

		public PartySceneUnitStatusMode unitStatusMode;

		public PartySceneUnitStatusMode endStatusMode;

		private static PartyList _clearPartyData;

		private static PartyList _clearPartyData2;

		public static EmptyQuestClearUnitData[] clearPartyLostUnitData;

		private static PartyList fromMatchingPartyData;

		private List<PartyList> partyData;

		public EquipMode equipMode;

		private int _currentPartyGroupIndex;

		public int _currentPartyIndexInGroup;

		public int currentPartySwitchIndex;

		public int currentCharacterIndexInParty;

		public int currentCharacterId;

		private PartyList _oldPartyData;

		public int oldCurrentPartyIndex;

		public int questId;

		private Action onMainPartyNoSuccessCallBack;

		private StringBuilder partyErrorBuilder;

		private bool isEntrust;

		private ElementalType entrustElementalType;

		private ElementalType[,] elementPriorityMatrix;

		public const float autoPartyAtkWeight = 1f;

		public const float autoPartyDefWeight = 1f;

		public const float autoPartyHpWeight = 1f;

		private const int topPriority = 1;

		private const int normalPriority = 2;

		private const int bottomPriority = 3;

		public const int otherAbilityPriority = 99999;

		private const string prefsKeyPartySwitchIndex = "Party/PartySwitchIndex_{0}_{1}";

		public PartySceneUnitStatusMode nextUnitStatusMode => default(PartySceneUnitStatusMode);

		public static PartyList clearPartyData => null;

		public static PartyList clearPartyData2 => null;

		public static bool isCurrentClearParty
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool isCurrentClearParty2
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static QuestPrepareData[] orderPartyData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool isCurrentOrderParty
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int partyCount => default(int);

		public int currentPartyGroupIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int currentPartyIndexInGroup
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int currentPartyIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int startPartyIndex => default(int);

		public PartyList oldPartyData => null;

		public bool isShowReloadPopup
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int activeCharaId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeWeaponId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public ulong activeDragonId
		{
			get
			{
				return default(ulong);
			}
			set
			{
			}
		}

		public int activeType1Crest1Id
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeType1Crest2Id
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeType1Crest3Id
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeType2Crest1Id
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeType2Crest2Id
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeType3Crest1Id
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeType3Crest2Id
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public ulong activeTalismanKeyId
		{
			get
			{
				return default(ulong);
			}
			set
			{
			}
		}

		public int activeWeaponSkinId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeSkill3CharaId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int activeSkill4CharaId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public PartyList activePartyData => null;

		public PartySettingList activeCharaData => null;

		public static bool IsSelectedCurrentClearParty()
		{
			return default(bool);
		}

		public int GetCrestBySlotIndex(PartySettingList chara, int slotIndex)
		{
			return default(int);
		}

		public void SetCrestBySlotIndex(PartySettingList chara, int slotIndex, int crestId)
		{
		}

		public int[] GetActiveCrestIds()
		{
			return null;
		}

		public void SetActiveCrestIdBySlotIndex(int slotIndex, int crestId)
		{
		}

		public PartyList GetPartyDataByIndex(int partyIndex)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		public void Reload()
		{
		}

		public void ReloadPartyName()
		{
		}

		public bool CompareAllPartyDataWithDataManager()
		{
			return default(bool);
		}

		public void ShowReloadPopup()
		{
		}

		public void SendPartyDataErrorToFirebase()
		{
		}

		public void SetOrderParty(int questOrderPartyGroupId)
		{
		}

		public static void CreateClearPartyData(PartySettingList[] questClearParty)
		{
		}

		public static void CreateClearPartyData(int[] charaIds, ulong[] dragonIds, int[] weaponBodyIds, int[] weaponSkinIds, int[] editSkill3CharaIds, int[] editSkill4CharaIds, int[] crest11Ids, int[] crest12Ids, int[] crest13Ids, int[] crest21Ids, int[] crest22Ids, int[] crest31Ids, int[] crest32Ids, ulong[] talismanIds)
		{
		}

		public static ulong GetOwnId<T>(DataManager.GameData<T> data, ulong id) where T : class
		{
			return default(ulong);
		}

		public static int GetOwnId<T>(DataManager.GameData<T> data, int id) where T : class
		{
			return default(int);
		}

		public static void CreateClearPartyLostUnitData(AtgenLostUnitList[] lost_unit_list)
		{
		}

		public static void ResetTemporaryPartyData()
		{
		}

		public static void ResetClearParty()
		{
		}

		public static void ResetOrderParty()
		{
		}

		public static void ClearStaticData()
		{
		}

		public static void ShowEmptyQuestClearUnitPopup(EmptyQuestClearUnitData[] emptyUnitData)
		{
		}

		public static void RequestSaveClearPartyMulti(int questId, Action onSuccess)
		{
		}

		public static Task<QuestGetQuestClearPartyMultiResponse> RequestSaveClearPartyMulti(int questId)
		{
			return null;
		}

		private PartyList GetCurrentPartyCharactersInfo()
		{
			return null;
		}

		private PartyList GetPartyCharactersInfo(int index)
		{
			return null;
		}

		public void AutoPartyUnitSelect(AutoPartyConfigData configData)
		{
		}

		public void AutoPartyEquipUnitSelect(AutoPartyConfigData configData)
		{
		}

		private void AutoPartyCharaSelect(ElementalType element, UnitType charaType)
		{
		}

		public bool Is2ndPartySelected()
		{
			return default(bool);
		}

		private void AutoPartyDragonSelect(ElementalType element, UnitType charaType, bool isChangeChara, int partyIndex = -1)
		{
		}

		private void AutoPartyWeaponSelect(ElementalType element, UnitType charaType, bool isChangeChara, int partyIndex)
		{
		}

		private void AutoPartyAbilityCrestSelect(UnitType charaType, int partyIndex = -1, int abilityIndex = 0)
		{
		}

		private void AutoPartyTalismanSelect(UnitType charaType, int partyIndex)
		{
		}

		public int GetEquipCrestId(int partyIndex, int partySettingListIndex)
		{
			return default(int);
		}

		public void SetEquipCrestId(int partyIndex, int partySettingListIndex, int setId)
		{
		}

		private int GetUniqeAbilityCrestId(int crestId, List<AutoPartySortData> tempSortDataList, CharaDataElement masterCharaData, UnitType charaType)
		{
			return default(int);
		}

		private void SetEquipPriorityList(int index, int partyIndex, WeaponType charaWeaponType, ref List<int> equipPartyPriorityList)
		{
		}

		private int GetAutoSelectCharaElementSortPriority(ElementalType charaElement, ElementalType targetElement, bool isChangeChara, ElementalType selectElement)
		{
			return default(int);
		}

		private int GetAutoSelectAbilitySortPriority(int partyPriority, WeaponType targetWeaponType)
		{
			return default(int);
		}

		private int GetAutoSelectElementSortPriority(ElementalType selectElement, ElementalType targetElement)
		{
			return default(int);
		}

		private int GetAutoSelectAbilityElementSortPriority(ElementalType selectElement, ElementalType targetElement)
		{
			return default(int);
		}

		private int GetAutoSelectWeaponTypeSortPriority(WeaponType selectElement, WeaponType targetElement)
		{
			return default(int);
		}

		private int GetAutoSelectTypeSortPriority(UnitType selectType, UnitType targetType)
		{
			return default(int);
		}

		public void CreateOldPartyData()
		{
		}

		public void CreateOldPartyData(PartyList activeParty)
		{
		}

		public void ResetPartyData()
		{
		}

		public void CreateFromMatchingPartyData()
		{
		}

		public void ResetPartyDataByFromMatchingPartyData()
		{
		}

		public void SendPartySettingRequest(Action onSuccessCallback, [Optional] Action<ErrorType, int> onErrorCallback)
		{
		}

		public void SendPartyDataForNeedEditSkillSetting([Optional] Action onCompleteCallback)
		{
		}

		public string GetDefaultPartyName(int index)
		{
			return null;
		}

		public void SendMainPartyNoRequest(Action onSuccessCallback, [Optional] Action<ErrorType, int> onErrorCallback)
		{
		}

		private void OnMainPartyNoSuccessCallBack(PartySetMainPartyNoResponse res)
		{
		}

		private void SortDragonWeaponList(UnitType charaType, ref List<AutoPartySortData> sortList)
		{
		}

		public void ShowPartyNameEditPopup(int editPartyIndex = -1, [Optional] Action<string> editCompleteCallBack)
		{
		}

		public void SendPartyName(string name, int partyNo, Action<string> completeCallBack)
		{
		}

		public void CopyPartyData(int srcPartyNo, int dstPartyNo, Action onSuccessCallback, [Optional] Action<ErrorType, int> onErrorCallback)
		{
		}

		public void CopyPartyDataToLocal(int srcPartyNo, int dstPartyNo)
		{
		}

		public string GetPartyName(int partyIndex = -1)
		{
			return null;
		}

		public string GetCrestSetName(int index)
		{
			return null;
		}

		public static void ExcludeClearPartyDragonByElementalType(ElementalType limitedElementalType)
		{
		}

		public static AtgenCharaUnitSetDetailList GetEquipSetData(int charaId, int setIndex)
		{
			return null;
		}

		public string GetEquipSetSetName(int charaId, int index)
		{
			return null;
		}

		public static PartyList GetActivePartyCopyData()
		{
			return null;
		}

		public static int GetPartySwitchIndex(int questId, int index)
		{
			return default(int);
		}

		public static void SetPartySwitchIndex(int questId, int partyIndex, int cellIndex)
		{
		}

		public static PartySettingList[] GetPartySwtichClearParty(int questId)
		{
			return null;
		}

		public static void FixDuplicateCrest(PartySettingList partyData)
		{
		}

		public static bool HasUnitData(GiftType type, int unitId, int count)
		{
			return default(bool);
		}

		public static bool RemoveDuplicateAbilityCrestByPartyList(PartyList partyInfo)
		{
			return default(bool);
		}

		public static bool IsIncludingDuplicateAbilityCrestByPartyList(PartyList partyInfo)
		{
			return default(bool);
		}

		public static bool IsIncludingDuplicateAbilityCrestByPartySettingList(PartySettingList partyList)
		{
			return default(bool);
		}
	}
}
