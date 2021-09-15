/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GameSettingData : IngameData
	{
		// Fields
		public static readonly int MaxUnitCount;
		private List<PartyUnit> partyUnitList;
		private List<PartyUnit> party2UnitList;
		private PartyUnit supportData;
		private PartyUnit guestUnitData;
		private EventBoost eventBoostData;
		private List<GameEventPassive> eventPassiveGrowList;
		[CompilerGenerated]
		private int _areaCount_k__BackingField;
	
		// Properties
		public string DungeonKey { get; }
		public int DungeonType { get; }
		public int PlayType { get; }
		public int QuestId { get; }
		public int BonusType { get; }
		public int ContinueLimit { get; }
		public int RebornLimit { get; }
		public int StartTime { get; }
		public int IsHost { get; }
		public int UseStone { get; }
		public int IsFeverTime { get; }
		public int IsBotMultiTutorial { get; }
		public bool IsUseEventCharaAbility { get; }
		public EventAbilityCharaList[] eventAbilityCharaList { get; }
		public int IsReceivableCarryBonus { get; }
		public ulong[] FirstClearViewerIdList { get; }
		public int MultiDisconnectType { get; }
		public int RequestRepeatState { get; }
		public int WalkerSkill2Level { get; }
		public int areaCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class CharaData
		{
			// Fields
			private CharaList charaList;
	
			// Properties
			public int CharaId { get; }
			public int Level { get; }
			public int Hp { get; }
			public int Attack { get; }
			public int Defence { get; }
			public int ExAbilityLv { get; }
			public int ExAbility2Lv { get; }
			public int Ability1Lv { get; }
			public int Ability2Lv { get; }
			public int Ability3Lv { get; }
			public int Skill1Lv { get; }
			public int Skill2Lv { get; }
			public int BurstAttackLv { get; }
			public int ComboBuildupCount { get; }
			public int StatusPlusCount { get; }
			public int HpPlusCount { get; }
			public int AttackPlusCount { get; }
	
			// Constructors
			public CharaData(CharaList data);
		}
	
		public class DragonData
		{
			// Fields
			private DragonList dragonList;
			private int _skill2Lv;
	
			// Properties
			public int DragonId { get; }
			public ulong DragonKeyId { get; }
			public int Level { get; }
			public int Ability1Lv { get; }
			public int Ability2Lv { get; }
			public int Skill1Lv { get; set; }
			public int Skill2Lv { get; set; }
			public int StatusPlusCount { get; }
			public int HpPlusCount { get; }
			public int AttackPlusCount { get; }
	
			// Constructors
			public DragonData(DragonList data);
		}
	
		public class WeaponCommon
		{
			// Fields
			private GameWeaponBody weaponBodyList;
			private GameWeaponSkin weaponSkinData;
			private WeaponPassiveAbilityList[] passiveAbilityList;
	
			// Properties
			public int WeaponBodyId { get; }
			public int WeaponSkinId { get; }
			public int Buildup { get; }
			public int SkillNo { get; }
			public int SkillLv { get; }
			public int Ability1Lv { get; }
			public int Ability2Lv { get; }
	
			// Constructors
			public WeaponCommon(GameWeaponBody data, GameWeaponSkin skin, WeaponPassiveAbilityList[] abilityList);
	
			// Methods
			public void CheckUsablePassiveAbility(int chara_id);
			public int[] GetWeaponPassiveAbilityIds();
		}
	
		public class AbilityCrest
		{
			// Fields
			private GameAbilityCrest abilityCrest;
	
			// Properties
			public int AbilityCrestId { get; }
			public int AbilityCrestBuildup { get; }
			public int Ability1Lv { get; }
			public int Ability2Lv { get; }
			public int HpPlusCount { get; }
			public int AttackPlusCount { get; }
	
			// Constructors
			public AbilityCrest(GameAbilityCrest data);
		}
	
		public class EditSkillChara
		{
			// Fields
			private EditSkillCharaData editskillChara;
	
			// Properties
			public int EditSkillCharaId { get; }
			public int EditSkillLevel { get; }
	
			// Constructors
			public EditSkillChara(EditSkillCharaData data);
		}
	
		public class GuestData
		{
			// Fields
			private QuestGuestDataElement _guestData;
	
			// Properties
			public int AiType { get; }
			public int IsEnemyTarget { get; }
	
			// Constructors
			public GuestData(QuestGuestDataElement data);
		}
	
		public class UnitBaseParam
		{
			// Fields
			public float Hp;
			public float Attack;
			public float Defense;
	
			// Constructors
			public UnitBaseParam();
			public UnitBaseParam(float hp, float atk, float def);
		}
	
		public class DragonBonusParam
		{
			// Fields
			public float Damage;
			public float TimeBonus;
			public float Hp;
			public float Attack;
			public float Defense;
	
			// Constructors
			public DragonBonusParam(float dmg, float time, float hp, float atk, float def);
		}
	
		public class EventBoost
		{
			// Fields
			public int EventEffectType;
			public float EffectValue;
	
			// Constructors
			public EventBoost(int type, float value);
		}
	
		public class PartyUnit
		{
			// Fields
			private CharaData _charaData;
			private DragonData _dragonData;
			private WeaponCommon _weaponCommon;
			private AbilityCrest[] _abilityCrestList;
			private EditSkillChara _editSkillChara1;
			private EditSkillChara _editSkillChara2;
			private GuestData _guestData;
			private int _originalPosition;
			private int _position;
			private bool _isFriend;
			private int _dragonReliabilityLevel;
	
			// Properties
			public CharaData CharaData { get; }
			public DragonData DragonData { get; }
			public WeaponCommon WeaponCommon { get; }
			public AbilityCrest[] AbilityCrestList { get; }
			public EditSkillChara EditSkillChara1 { get; }
			public EditSkillChara EditSkillChara2 { get; }
			public int OriginalPosition { get; set; }
			public int Position { get; set; }
			public bool IsFriend { get; set; }
			public int DragonReliabilityLevel { get; set; }
			public GuestData GuestData { get; }
	
			// Constructors
			public PartyUnit(CharaList chara, DragonList dragon, GameWeaponSkin weaponSkin, GameWeaponBody weaponBody, GameAbilityCrest[] abilityCrest1List, GameAbilityCrest[] abilityCrest2List, GameAbilityCrest[] abilityCrest3List, EditSkillCharaData editSkillCharaData1 = null, EditSkillCharaData editSkillCharaData2 = null, WeaponPassiveAbilityList[] passiveAbilityList = null, QuestGuestDataElement guest = null);
	
			// Methods
			public void SetDragonData(DragonList dragon);
		}
	
		// Constructors
		public GameSettingData();
		static GameSettingData();
	
		// Methods
		public void Initialize();
		private void CreatePartyUnitList();
		private CharaList CreateSupportCharaParam(CharaList chara, int charaAverageLv);
		public void InitializeBotTutorial();
		public void InitializeParamOverwrite();
		public string GetScenePath(int areaIdx);
		public string GetAreaName(int areaIdx);
		public PartyUnit GetPartyUnit(int partyIdx, InGameDef.SwitchPartyNoList no);
		public int GetPartyUnitCount(InGameDef.SwitchPartyNoList no);
		public PartyUnit GetSupportUnit();
		public PartyUnit GetGuestUnit();
		public EventBoost GetEventBoost();
		public List<GameEventPassive> GetEventPassiveList();
		public void SetProloguePartyDragon(int dragonId, int level = 1);
		public void SetDummyArea(string[] areaList);
		public void SetDummyScene(string[] sceneList);
		public UnitBaseParam GetFortElemetalBonus(ElementalType type);
		public UnitBaseParam GetAlbumElemetalBonus(ElementalType type);
		public UnitBaseParam GetFortBonusPlusValue();
		public UnitBaseParam GetFortDragonAlbumBonus(ElementalType type);
		public UnitBaseParam GetFortWeaponBonus(WeaponType type);
		public DragonBonusParam GetFortDragonBonus(ElementalType type);
		private void SetParamOverwriteChara(CharaList chara, int overwrite_id);
		private void SetParamOverwriteDragon(DragonList dragon);
		private void SetParamOverwriteWeaponBody(GameWeaponBody weapon);
		private void SetParamOverwriteAbilityCrest(GameAbilityCrest crest);
		public void SetGuestData(QuestGuestDataElement guest);
		public PartyUnit GetGuestData(QuestGuestDataElement guest);
		private void SetParamChara(out CharaList chara, int charaId, int charaLv = 1);
		private void SetParamDragon(out DragonList dragon, int dragonId, int dragonLv);
		private void SetParamWeaponBody(out GameWeaponBody weapon, int weaponBodyId, int buildupCount);
		private void SetParamAbilityCrest(out AbilityCrestList abilityCrest, int abilityCrestId, int buildupCount);
		public void SetPrologueParty();
		public void SetLocalParty(int partyIdx);
		private GameAbilityCrest[] CreateAndCopyAbilityCrestList(int[] equipAbilityCrestIdList);
		private EditSkillCharaData CreateEditSkillCharaData(int edit_skill_chara_id);
		public void SetDummyParty(int num, int[] charaIdList, int[] dragonIdList, int[] weaponIdList);
		private void SetDummyChara(out CharaList chara, int charaId);
		private void SetDummyDragon(out DragonList dragon, int dragonId);
		private void SetDummyWeapon(out GameWeaponBody weapon, int weaponBodyId);
	}
}
