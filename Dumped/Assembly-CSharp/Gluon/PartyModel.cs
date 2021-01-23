/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyModel : SingletonInBaseMonoBehaviour<Gluon.PartyModel>
	{
		// Fields
		public const int numOfCharactersInParty = 4;
		public const int maxPartyCountInGroup = 6;
		public const int maxPartyGroupCount = 9;
		public const string prefsKeyWeaponIconOrList = "Party/WeaponListViewIconOrList";
		public const string prefsKeyCrestIconOrList = "Party/CrestListViewIconOrList";
		public static PartySceneState nowSceneState;
		public static PartySceneState prevSceneState;
		public bool isCrestStatusMode;
		private static PartyList _clearPartyData;
		public static EmptyQuestClearUnitData[] clearPartyLostUnitData;
		[CompilerGenerated]
		private static bool _isCurrentClearParty_k__BackingField;
		private List<PartyList> partyData;
		public EquipMode equipMode;
		private int _currentPartyGroupIndex;
		public int _currentPartyIndexInGroup;
		public int currentCharacterIndexInParty;
		public int currentCharacterId;
		private PartyList _oldPartyData;
		public int oldCurrentPartyIndex;
		public int questId;
		[CompilerGenerated]
		private bool _isShowReloadPopup_k__BackingField;
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
	
		// Properties
		public static PartyList clearPartyData { get; }
		public static bool isCurrentClearParty { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int partyCount { get; }
		public int currentPartyGroupIndex { get; set; }
		public int currentPartyIndexInGroup { get; set; }
		public int currentPartyIndex { get; set; }
		public int startPartyIndex { get; }
		public PartyList oldPartyData { get; }
		public bool isShowReloadPopup { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int activeCharaId { get; set; }
		public int activeWeaponId { get; set; }
		public ulong activeDragonId { get; set; }
		public int activeType1Crest1Id { get; set; }
		public int activeType1Crest2Id { get; set; }
		public int activeType1Crest3Id { get; set; }
		public int activeType2Crest1Id { get; set; }
		public int activeType2Crest2Id { get; set; }
		public int activeWeaponSkinId { get; set; }
		public int activeSkill3CharaId { get; set; }
		public int activeSkill4CharaId { get; set; }
		public PartyList activePartyData { get; }
		public PartySettingList activeCharaData { get; }
	
		// Nested types
		public enum EquipMode
		{
			Dragon = 0,
			Weapon = 1,
			Amulet = 2,
			Skill3 = 3,
			Skill4 = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass103_0();
	
			// Methods
			internal void _ShowReloadPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass112_0
		{
			// Fields
			public EmptyQuestClearUnitPopup popup;
	
			// Constructors
			public __c__DisplayClass112_0();
	
			// Methods
			internal void _ShowEmptyQuestClearUnitPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass113_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass113_0();
	
			// Methods
			internal void _RequestSaveClearPartyMulti_b__0(QuestSetQuestClearPartyMultiResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass118_0
		{
			// Fields
			public List<AutoPartySortData> sortList;
	
			// Constructors
			public __c__DisplayClass118_0();
	
			// Methods
			internal void _AutoPartyCharaSelect_b__12();
			internal void _AutoPartyCharaSelect_b__13();
			internal void _AutoPartyCharaSelect_b__14();
			internal void _AutoPartyCharaSelect_b__15();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass118_1
		{
			// Fields
			public AutoPartySortData selected;
	
			// Constructors
			public __c__DisplayClass118_1();
	
			// Methods
			internal bool _AutoPartyCharaSelect_b__40(AutoPartySortData data);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<AutoPartySortData, int> __9__118_0;
			public static Func<AutoPartySortData, int> __9__118_1;
			public static Func<AutoPartySortData, ElementalType> __9__118_2;
			public static Func<AutoPartySortData, WeaponType> __9__118_3;
			public static Func<AutoPartySortData, int> __9__118_4;
			public static Func<AutoPartySortData, ulong> __9__118_5;
			public static Func<AutoPartySortData, int> __9__118_6;
			public static Func<AutoPartySortData, int> __9__118_7;
			public static Func<AutoPartySortData, ElementalType> __9__118_8;
			public static Func<AutoPartySortData, WeaponType> __9__118_9;
			public static Func<AutoPartySortData, int> __9__118_10;
			public static Func<AutoPartySortData, ulong> __9__118_11;
			public static Func<AutoPartySortData, int> __9__118_16;
			public static Func<AutoPartySortData, int> __9__118_17;
			public static Func<AutoPartySortData, ElementalType> __9__118_18;
			public static Func<AutoPartySortData, WeaponType> __9__118_19;
			public static Func<AutoPartySortData, int> __9__118_20;
			public static Func<AutoPartySortData, ulong> __9__118_21;
			public static Func<AutoPartySortData, int> __9__118_22;
			public static Func<AutoPartySortData, int> __9__118_23;
			public static Func<AutoPartySortData, ElementalType> __9__118_24;
			public static Func<AutoPartySortData, WeaponType> __9__118_25;
			public static Func<AutoPartySortData, int> __9__118_26;
			public static Func<AutoPartySortData, ulong> __9__118_27;
			public static Func<AutoPartySortData, int> __9__118_28;
			public static Func<AutoPartySortData, int> __9__118_29;
			public static Func<AutoPartySortData, ElementalType> __9__118_30;
			public static Func<AutoPartySortData, WeaponType> __9__118_31;
			public static Func<AutoPartySortData, int> __9__118_32;
			public static Func<AutoPartySortData, ulong> __9__118_33;
			public static Func<AutoPartySortData, int> __9__118_34;
			public static Func<AutoPartySortData, int> __9__118_35;
			public static Func<AutoPartySortData, ElementalType> __9__118_36;
			public static Func<AutoPartySortData, WeaponType> __9__118_37;
			public static Func<AutoPartySortData, int> __9__118_38;
			public static Func<AutoPartySortData, ulong> __9__118_39;
			public static Func<AutoPartySortData, int> __9__118_41;
			public static Func<AutoPartySortData, int> __9__118_42;
			public static Func<AutoPartySortData, ElementalType> __9__118_43;
			public static Func<AutoPartySortData, WeaponType> __9__118_44;
			public static Func<AutoPartySortData, int> __9__118_45;
			public static Func<AutoPartySortData, ulong> __9__118_46;
			public static Func<AutoPartySortData, int> __9__118_47;
			public static Func<AutoPartySortData, int> __9__118_48;
			public static Func<AutoPartySortData, int> __9__118_49;
			public static Func<AutoPartySortData, ElementalType> __9__118_50;
			public static Func<AutoPartySortData, WeaponType> __9__118_51;
			public static Func<AutoPartySortData, int> __9__118_52;
			public static Func<AutoPartySortData, ulong> __9__118_53;
			public static Func<AutoPartySortData, int> __9__118_54;
			public static Func<AutoPartySortData, int> __9__118_55;
			public static Func<AutoPartySortData, int> __9__118_56;
			public static Func<AutoPartySortData, ElementalType> __9__118_57;
			public static Func<AutoPartySortData, WeaponType> __9__118_58;
			public static Func<AutoPartySortData, int> __9__118_59;
			public static Func<AutoPartySortData, ulong> __9__118_60;
			public static Comparison<AutoPartySortData> __9__118_61;
			public static Comparison<AutoPartySortData> __9__118_62;
			public static Func<AutoPartySortData, int> __9__121_0;
			public static Func<AutoPartySortData, int> __9__121_1;
			public static Func<AutoPartySortData, int> __9__121_2;
			public static Func<AutoPartySortData, int> __9__121_3;
			public static Func<AutoPartySortData, int> __9__121_4;
			public static Func<AutoPartySortData, int> __9__121_5;
			public static Func<AutoPartySortData, int> __9__121_6;
			public static Func<AutoPartySortData, int> __9__121_7;
			public static Func<AutoPartySortData, int> __9__121_8;
			public static Func<AutoPartySortData, int> __9__140_0;
			public static Func<AutoPartySortData, int> __9__140_1;
			public static Func<AutoPartySortData, int> __9__140_2;
			public static Func<AutoPartySortData, ElementalType> __9__140_3;
			public static Func<AutoPartySortData, int> __9__140_4;
			public static Func<AutoPartySortData, int> __9__140_5;
			public static Func<AutoPartySortData, ulong> __9__140_6;
			public static Func<AutoPartySortData, int> __9__140_7;
			public static Func<AutoPartySortData, int> __9__140_8;
			public static Func<AutoPartySortData, int> __9__140_9;
			public static Func<AutoPartySortData, ElementalType> __9__140_10;
			public static Func<AutoPartySortData, int> __9__140_11;
			public static Func<AutoPartySortData, int> __9__140_12;
			public static Func<AutoPartySortData, ulong> __9__140_13;
			public static Func<AutoPartySortData, int> __9__140_14;
			public static Func<AutoPartySortData, int> __9__140_15;
			public static Func<AutoPartySortData, int> __9__140_16;
			public static Func<AutoPartySortData, ElementalType> __9__140_17;
			public static Func<AutoPartySortData, int> __9__140_18;
			public static Func<AutoPartySortData, int> __9__140_19;
			public static Func<AutoPartySortData, ulong> __9__140_20;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _AutoPartyCharaSelect_b__118_0(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_1(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_2(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_3(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_4(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_5(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_6(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_7(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_8(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_9(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_10(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_11(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_16(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_17(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_18(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_19(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_20(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_21(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_22(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_23(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_24(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_25(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_26(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_27(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_28(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_29(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_30(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_31(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_32(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_33(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_34(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_35(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_36(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_37(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_38(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_39(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_41(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_42(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_43(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_44(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_45(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_46(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_47(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_48(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_49(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_50(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_51(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_52(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_53(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_54(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_55(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_56(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__118_57(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__118_58(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_59(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__118_60(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__118_61(AutoPartySortData currData, AutoPartySortData nextData);
			internal int _AutoPartyCharaSelect_b__118_62(AutoPartySortData currData, AutoPartySortData nextData);
			internal int _AutoPartyAbilityCrestSelect_b__121_0(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_1(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_2(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_3(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_4(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_5(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_6(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_7(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__121_8(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_0(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_1(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_2(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__140_3(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_4(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_5(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__140_6(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_7(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_8(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_9(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__140_10(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_11(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_12(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__140_13(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_14(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_15(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_16(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__140_17(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_18(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__140_19(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__140_20(AutoPartySortData p);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_0
		{
			// Fields
			public int i;
			public PartyModel __4__this;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal bool _AutoPartyDragonSelect_b__0(AutoPartySortData item);
		}
	
		[CompilerGenerated]
		private struct _SendPartySettingRequest_d__135 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyModel __4__this;
			public Action onSuccessCallback;
			public Action<ErrorType, int> onErrorCallback;
			private TaskAwaiter<PartySetPartySettingResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SendPartyDataForNeedEditSkillSetting_d__136 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyModel __4__this;
			public Action onCompleteCallback;
			private int _i_5__2;
			private TaskAwaiter<PartySetPartySettingResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass141_0
		{
			// Fields
			public PartyNameEditPopup popup;
			public int editPartyIndex;
			public int partyIndex;
			public PartyList info;
			public PartyModel __4__this;
			public Action<string> editCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass141_0();
	
			// Methods
			internal void _ShowPartyNameEditPopup_b__0();
			internal void _ShowPartyNameEditPopup_b__1();
		}
	
		[CompilerGenerated]
		private struct _SendPartyName_d__142 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public string name;
			public int partyNo;
			public PartyModel __4__this;
			public Action<string> completeCallBack;
			private TaskAwaiter<PartyUpdatePartyNameResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public PartyModel();
		static PartyModel();
	
		// Methods
		public int GetCrestBySlotIndex(PartySettingList chara, int slotIndex);
		public void SetCrestBySlotIndex(PartySettingList chara, int slotIndex, int crestId);
		public int[] GetActiveCrestIds();
		public void SetActiveCrestIdBySlotIndex(int slotIndex, int crestId);
		public PartyList GetPartyDataByIndex(int partyIndex);
		protected override void Awake();
		public void Reload();
		public void ReloadPartyName();
		public bool CompareAllPartyDataWithDataManager();
		public void ShowReloadPopup();
		public void SendPartyDataErrorToFirebase();
		public static void CreateClearPartyData(AtgenQuestClearParty questClearParty);
		public static void CreateClearPartyData(int[] charaIds, ulong[] dragonIds, int[] weaponBodyIds, int[] weaponSkinIds, int[] editSkill3CharaIds, int[] editSkill4CharaIds, int[] crest11Ids, int[] crest12Ids, int[] crest13Ids, int[] crest21Ids, int[] crest22Ids);
		public static ulong GetOwnId<T>(DataManager.GameData<T> data, ulong id)
			where T : class;
		public static int GetOwnId<T>(DataManager.GameData<T> data, int id)
			where T : class;
		public static void CreateClearPartyLostUnitData(AtgenDuplicateEntityList[] lost_unit_list);
		public static void ResetClearParty();
		public static void ClearStaticData();
		public static void ShowEmptyQuestClearUnitPopup(EmptyQuestClearUnitData[] emptyUnitData);
		public static void RequestSaveClearPartyMulti(int questId, Action onSuccess);
		private PartyList GetCurrentPartyCharactersInfo();
		private PartyList GetPartyCharactersInfo(int index);
		public void AutoPartyUnitSelect(AutoPartyConfigData configData);
		public void AutoPartyEquipUnitSelect(AutoPartyConfigData configData);
		private void AutoPartyCharaSelect(ElementalType element, UnitType charaType);
		private void AutoPartyDragonSelect(ElementalType element, UnitType charaType, bool isChangeChara, int partyIndex = -1);
		private void AutoPartyWeaponSelect(ElementalType element, UnitType charaType, bool isChangeChara, int partyIndex);
		private void AutoPartyAbilityCrestSelect(UnitType charaType, int partyIndex = -1, int abilityIndex = 0);
		public int GetEquipCrestId(int partyIndex, int partySettingListIndex);
		public void SetEquipCrestId(int partyIndex, int partySettingListIndex, int setId);
		private int GetUniqeAbilityCrestId(int crestId, List<AutoPartySortData> tempSortDataList, CharaDataElement masterCharaData, UnitType charaType);
		private void SetEquipPriorityList(int index, int partyIndex, WeaponType charaWeaponType, ref List<int> equipPartyPriorityList);
		private int GetAutoSelectCharaElementSortPriority(ElementalType charaElement, ElementalType targetElement, bool isChangeChara, ElementalType selectElement);
		private int GetAutoSelectAbilitySortPriority(int partyPriority, WeaponType targetWeaponType);
		private int GetAutoSelectElementSortPriority(ElementalType selectElement, ElementalType targetElement);
		private int GetAutoSelectAbilityElementSortPriority(ElementalType selectElement, ElementalType targetElement);
		private int GetAutoSelectWeaponTypeSortPriority(WeaponType selectElement, WeaponType targetElement);
		private int GetAutoSelectTypeSortPriority(UnitType selectType, UnitType targetType);
		public void CreateOldPartyData();
		public void CreateOldPartyData(PartyList activeParty);
		public void ResetPartyData();
		public async void SendPartySettingRequest(Action onSuccessCallback, Action<ErrorType, int> onErrorCallback = null);
		public async void SendPartyDataForNeedEditSkillSetting(Action onCompleteCallback = null);
		public string GetDefaultPartyName(int index);
		public void SendMainPartyNoRequest(Action onSuccessCallback, Action<ErrorType, int> onErrorCallback = null);
		private void OnMainPartyNoSuccessCallBack(PartySetMainPartyNoResponse res);
		private void SortDragonWeaponList(UnitType charaType, ref List<AutoPartySortData> sortList);
		public void ShowPartyNameEditPopup(int editPartyIndex = -1, Action<string> editCompleteCallBack = null);
		public async void SendPartyName(string name, int partyNo, Action<string> completeCallBack);
		public string GetPartyName(int partyIndex = -1);
		public string GetCrestSetName(int index);
	}
}
