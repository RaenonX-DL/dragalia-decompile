/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
		[CompilerGenerated]
		private static QuestPrepareData[] _orderPartyData_k__BackingField;
		[CompilerGenerated]
		private static bool _isCurrentOrderParty_k__BackingField;
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
		public static QuestPrepareData[] orderPartyData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool isCurrentOrderParty { [CompilerGenerated] get; [CompilerGenerated] private set; }
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
		private sealed class __c__DisplayClass111_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass111_0();
	
			// Methods
			internal void _ShowReloadPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass122_0
		{
			// Fields
			public EmptyQuestClearUnitPopup popup;
	
			// Constructors
			public __c__DisplayClass122_0();
	
			// Methods
			internal void _ShowEmptyQuestClearUnitPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass123_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass123_0();
	
			// Methods
			internal void _RequestSaveClearPartyMulti_b__0(QuestSetQuestClearPartyMultiResponse res);
		}
	
		[CompilerGenerated]
		private struct _RequestSaveClearPartyMulti_d__124 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<QuestGetQuestClearPartyMultiResponse> __t__builder;
			public int questId;
			private TaskAwaiter<QuestGetQuestClearPartyMultiResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass129_0
		{
			// Fields
			public List<AutoPartySortData> sortList;
	
			// Constructors
			public __c__DisplayClass129_0();
	
			// Methods
			internal void _AutoPartyCharaSelect_b__12();
			internal void _AutoPartyCharaSelect_b__13();
			internal void _AutoPartyCharaSelect_b__14();
			internal void _AutoPartyCharaSelect_b__15();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass129_1
		{
			// Fields
			public AutoPartySortData selected;
	
			// Constructors
			public __c__DisplayClass129_1();
	
			// Methods
			internal bool _AutoPartyCharaSelect_b__40(AutoPartySortData data);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<AutoPartySortData, int> __9__129_0;
			public static Func<AutoPartySortData, int> __9__129_1;
			public static Func<AutoPartySortData, ElementalType> __9__129_2;
			public static Func<AutoPartySortData, WeaponType> __9__129_3;
			public static Func<AutoPartySortData, int> __9__129_4;
			public static Func<AutoPartySortData, ulong> __9__129_5;
			public static Func<AutoPartySortData, int> __9__129_6;
			public static Func<AutoPartySortData, int> __9__129_7;
			public static Func<AutoPartySortData, ElementalType> __9__129_8;
			public static Func<AutoPartySortData, WeaponType> __9__129_9;
			public static Func<AutoPartySortData, int> __9__129_10;
			public static Func<AutoPartySortData, ulong> __9__129_11;
			public static Func<AutoPartySortData, int> __9__129_16;
			public static Func<AutoPartySortData, int> __9__129_17;
			public static Func<AutoPartySortData, ElementalType> __9__129_18;
			public static Func<AutoPartySortData, WeaponType> __9__129_19;
			public static Func<AutoPartySortData, int> __9__129_20;
			public static Func<AutoPartySortData, ulong> __9__129_21;
			public static Func<AutoPartySortData, int> __9__129_22;
			public static Func<AutoPartySortData, int> __9__129_23;
			public static Func<AutoPartySortData, ElementalType> __9__129_24;
			public static Func<AutoPartySortData, WeaponType> __9__129_25;
			public static Func<AutoPartySortData, int> __9__129_26;
			public static Func<AutoPartySortData, ulong> __9__129_27;
			public static Func<AutoPartySortData, int> __9__129_28;
			public static Func<AutoPartySortData, int> __9__129_29;
			public static Func<AutoPartySortData, ElementalType> __9__129_30;
			public static Func<AutoPartySortData, WeaponType> __9__129_31;
			public static Func<AutoPartySortData, int> __9__129_32;
			public static Func<AutoPartySortData, ulong> __9__129_33;
			public static Func<AutoPartySortData, int> __9__129_34;
			public static Func<AutoPartySortData, int> __9__129_35;
			public static Func<AutoPartySortData, ElementalType> __9__129_36;
			public static Func<AutoPartySortData, WeaponType> __9__129_37;
			public static Func<AutoPartySortData, int> __9__129_38;
			public static Func<AutoPartySortData, ulong> __9__129_39;
			public static Func<AutoPartySortData, int> __9__129_41;
			public static Func<AutoPartySortData, int> __9__129_42;
			public static Func<AutoPartySortData, ElementalType> __9__129_43;
			public static Func<AutoPartySortData, WeaponType> __9__129_44;
			public static Func<AutoPartySortData, int> __9__129_45;
			public static Func<AutoPartySortData, ulong> __9__129_46;
			public static Func<AutoPartySortData, int> __9__129_47;
			public static Func<AutoPartySortData, int> __9__129_48;
			public static Func<AutoPartySortData, int> __9__129_49;
			public static Func<AutoPartySortData, ElementalType> __9__129_50;
			public static Func<AutoPartySortData, WeaponType> __9__129_51;
			public static Func<AutoPartySortData, int> __9__129_52;
			public static Func<AutoPartySortData, ulong> __9__129_53;
			public static Func<AutoPartySortData, int> __9__129_54;
			public static Func<AutoPartySortData, int> __9__129_55;
			public static Func<AutoPartySortData, int> __9__129_56;
			public static Func<AutoPartySortData, ElementalType> __9__129_57;
			public static Func<AutoPartySortData, WeaponType> __9__129_58;
			public static Func<AutoPartySortData, int> __9__129_59;
			public static Func<AutoPartySortData, ulong> __9__129_60;
			public static Comparison<AutoPartySortData> __9__129_61;
			public static Comparison<AutoPartySortData> __9__129_62;
			public static Func<AutoPartySortData, int> __9__132_0;
			public static Func<AutoPartySortData, int> __9__132_1;
			public static Func<AutoPartySortData, int> __9__132_2;
			public static Func<AutoPartySortData, int> __9__132_3;
			public static Func<AutoPartySortData, int> __9__132_4;
			public static Func<AutoPartySortData, int> __9__132_5;
			public static Func<AutoPartySortData, int> __9__132_6;
			public static Func<AutoPartySortData, int> __9__132_7;
			public static Func<AutoPartySortData, int> __9__132_8;
			public static Func<AutoPartySortData, int> __9__151_0;
			public static Func<AutoPartySortData, int> __9__151_1;
			public static Func<AutoPartySortData, int> __9__151_2;
			public static Func<AutoPartySortData, ElementalType> __9__151_3;
			public static Func<AutoPartySortData, int> __9__151_4;
			public static Func<AutoPartySortData, int> __9__151_5;
			public static Func<AutoPartySortData, ulong> __9__151_6;
			public static Func<AutoPartySortData, int> __9__151_7;
			public static Func<AutoPartySortData, int> __9__151_8;
			public static Func<AutoPartySortData, int> __9__151_9;
			public static Func<AutoPartySortData, ElementalType> __9__151_10;
			public static Func<AutoPartySortData, int> __9__151_11;
			public static Func<AutoPartySortData, int> __9__151_12;
			public static Func<AutoPartySortData, ulong> __9__151_13;
			public static Func<AutoPartySortData, int> __9__151_14;
			public static Func<AutoPartySortData, int> __9__151_15;
			public static Func<AutoPartySortData, int> __9__151_16;
			public static Func<AutoPartySortData, ElementalType> __9__151_17;
			public static Func<AutoPartySortData, int> __9__151_18;
			public static Func<AutoPartySortData, int> __9__151_19;
			public static Func<AutoPartySortData, ulong> __9__151_20;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _AutoPartyCharaSelect_b__129_0(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_1(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_2(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_3(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_4(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_5(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_6(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_7(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_8(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_9(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_10(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_11(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_16(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_17(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_18(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_19(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_20(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_21(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_22(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_23(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_24(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_25(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_26(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_27(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_28(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_29(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_30(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_31(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_32(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_33(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_34(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_35(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_36(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_37(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_38(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_39(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_41(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_42(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_43(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_44(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_45(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_46(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_47(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_48(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_49(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_50(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_51(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_52(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_53(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_54(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_55(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_56(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__129_57(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__129_58(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_59(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__129_60(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__129_61(AutoPartySortData currData, AutoPartySortData nextData);
			internal int _AutoPartyCharaSelect_b__129_62(AutoPartySortData currData, AutoPartySortData nextData);
			internal int _AutoPartyAbilityCrestSelect_b__132_0(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_1(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_2(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_3(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_4(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_5(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_6(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_7(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__132_8(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_0(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_1(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_2(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__151_3(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_4(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_5(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__151_6(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_7(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_8(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_9(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__151_10(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_11(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_12(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__151_13(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_14(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_15(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_16(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__151_17(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_18(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__151_19(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__151_20(AutoPartySortData p);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass130_0
		{
			// Fields
			public int i;
			public PartyModel __4__this;
	
			// Constructors
			public __c__DisplayClass130_0();
	
			// Methods
			internal bool _AutoPartyDragonSelect_b__0(AutoPartySortData item);
		}
	
		[CompilerGenerated]
		private struct _SendPartySettingRequest_d__146 : IAsyncStateMachine
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
		private struct _SendPartyDataForNeedEditSkillSetting_d__147 : IAsyncStateMachine
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
		private sealed class __c__DisplayClass152_0
		{
			// Fields
			public PartyNameEditPopup popup;
			public int editPartyIndex;
			public int partyIndex;
			public PartyList info;
			public PartyModel __4__this;
			public Action<string> editCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass152_0();
	
			// Methods
			internal void _ShowPartyNameEditPopup_b__0();
			internal void _ShowPartyNameEditPopup_b__1();
		}
	
		[CompilerGenerated]
		private struct _SendPartyName_d__153 : IAsyncStateMachine
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
		public void SetOrderParty(int questOrderPartyGroupId);
		public static void CreateClearPartyData(AtgenQuestClearParty questClearParty);
		public static void CreateClearPartyData(int[] charaIds, ulong[] dragonIds, int[] weaponBodyIds, int[] weaponSkinIds, int[] editSkill3CharaIds, int[] editSkill4CharaIds, int[] crest11Ids, int[] crest12Ids, int[] crest13Ids, int[] crest21Ids, int[] crest22Ids);
		public static ulong GetOwnId<T>(DataManager.GameData<T> data, ulong id)
			where T : class;
		public static int GetOwnId<T>(DataManager.GameData<T> data, int id)
			where T : class;
		public static void CreateClearPartyLostUnitData(AtgenDuplicateEntityList[] lost_unit_list);
		public static void ResetClearParty();
		public static void ResetOrderParty();
		public static void ClearStaticData();
		public static void ShowEmptyQuestClearUnitPopup(EmptyQuestClearUnitData[] emptyUnitData);
		public static void RequestSaveClearPartyMulti(int questId, Action onSuccess);
		public static async Task<QuestGetQuestClearPartyMultiResponse> RequestSaveClearPartyMulti(int questId);
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
		public static void ExcludeClearPartyDragonByElementalType(ElementalType limitedElementalType);
	}
}
