using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class GameSettingData : IngameData
	{
		public class CharaData
		{
			private CharaList charaList;

			public int CharaId => default(int);

			public int Level => default(int);

			public int Hp => default(int);

			public int Attack => default(int);

			public int Defence => default(int);

			public int ExAbilityLv => default(int);

			public int ExAbility2Lv => default(int);

			public int Ability1Lv => default(int);

			public int Ability2Lv => default(int);

			public int Ability3Lv => default(int);

			public int Skill1Lv => default(int);

			public int Skill2Lv => default(int);

			public int BurstAttackLv => default(int);

			public int ComboBuildupCount => default(int);

			public int StatusPlusCount => default(int);

			public int HpPlusCount => default(int);

			public int AttackPlusCount => default(int);

			public CharaData(CharaList data)
			{
			}
		}

		public class DragonData
		{
			private DragonList dragonList;

			private int _skill2Lv;

			public int DragonId => default(int);

			public ulong DragonKeyId => default(ulong);

			public int Level => default(int);

			public int Ability1Lv => default(int);

			public int Ability2Lv => default(int);

			public int Skill1Lv
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int Skill2Lv
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int StatusPlusCount => default(int);

			public int HpPlusCount => default(int);

			public int AttackPlusCount => default(int);

			public DragonData(DragonList data)
			{
			}
		}

		public class WeaponCommon
		{
			private GameWeaponBody weaponBodyList;

			private GameWeaponSkin weaponSkinData;

			private WeaponPassiveAbilityList[] passiveAbilityList;

			public int WeaponBodyId => default(int);

			public int WeaponSkinId => default(int);

			public int Buildup => default(int);

			public int SkillNo => default(int);

			public int SkillLv => default(int);

			public int Ability1Lv => default(int);

			public int Ability2Lv => default(int);

			public WeaponCommon(GameWeaponBody data, GameWeaponSkin skin, WeaponPassiveAbilityList[] abilityList)
			{
			}

			public void CheckUsablePassiveAbility(int chara_id)
			{
			}

			public int[] GetWeaponPassiveAbilityIds()
			{
				return null;
			}
		}

		public class AbilityCrest
		{
			private GameAbilityCrest abilityCrest;

			public int AbilityCrestId => default(int);

			public int AbilityCrestBuildup => default(int);

			public int Ability1Lv => default(int);

			public int Ability2Lv => default(int);

			public int HpPlusCount => default(int);

			public int AttackPlusCount => default(int);

			public AbilityCrest(GameAbilityCrest data)
			{
			}
		}

		public class EditSkillChara
		{
			private EditSkillCharaData editskillChara;

			public int EditSkillCharaId => default(int);

			public int EditSkillLevel => default(int);

			public EditSkillChara(EditSkillCharaData data)
			{
			}
		}

		public class GuestData
		{
			private QuestGuestDataElement _guestData;

			public int AiType => default(int);

			public int IsEnemyTarget => default(int);

			public GuestData(QuestGuestDataElement data)
			{
			}
		}

		public class UnitBaseParam
		{
			public float Hp;

			public float Attack;

			public float Defense;

			public UnitBaseParam()
			{
			}

			public UnitBaseParam(float hp, float atk, float def)
			{
			}
		}

		public class DragonBonusParam
		{
			public float Damage;

			public float TimeBonus;

			public float Hp;

			public float Attack;

			public float Defense;

			public DragonBonusParam(float dmg, float time, float hp, float atk, float def)
			{
			}
		}

		public class EventBoost
		{
			public int EventEffectType;

			public float EffectValue;

			public EventBoost(int type, float value)
			{
			}
		}

		public class PartyUnit
		{
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

			public CharaData CharaData => null;

			public DragonData DragonData => null;

			public WeaponCommon WeaponCommon => null;

			public AbilityCrest[] AbilityCrestList => null;

			public EditSkillChara EditSkillChara1 => null;

			public EditSkillChara EditSkillChara2 => null;

			public int OriginalPosition
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int Position
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public bool IsFriend
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public int DragonReliabilityLevel
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public GuestData GuestData => null;

			public PartyUnit(CharaList chara, DragonList dragon, GameWeaponSkin weaponSkin, GameWeaponBody weaponBody, GameAbilityCrest[] abilityCrest1List, GameAbilityCrest[] abilityCrest2List, GameAbilityCrest[] abilityCrest3List, [Optional] EditSkillCharaData editSkillCharaData1, [Optional] EditSkillCharaData editSkillCharaData2, [Optional] WeaponPassiveAbilityList[] passiveAbilityList, [Optional] QuestGuestDataElement guest)
			{
			}

			public void SetDragonData(DragonList dragon)
			{
			}
		}

		public static readonly int MaxUnitCount;

		private List<PartyUnit> partyUnitList;

		private List<PartyUnit> party2UnitList;

		private PartyUnit supportData;

		private PartyUnit guestUnitData;

		private EventBoost eventBoostData;

		private List<GameEventPassive> eventPassiveGrowList;

		public string DungeonKey => null;

		public int DungeonType => default(int);

		public int PlayType => default(int);

		public int QuestId => default(int);

		public int BonusType => default(int);

		public int ContinueLimit => default(int);

		public int RebornLimit => default(int);

		public int StartTime => default(int);

		public int IsHost => default(int);

		public int UseStone => default(int);

		public int IsFeverTime => default(int);

		public int IsBotMultiTutorial => default(int);

		public bool IsUseEventCharaAbility => default(bool);

		public EventAbilityCharaList[] eventAbilityCharaList => null;

		public int IsReceivableCarryBonus => default(int);

		public ulong[] FirstClearViewerIdList => null;

		public int MultiDisconnectType => default(int);

		public int RequestRepeatState => default(int);

		public int WalkerSkill2Level => default(int);

		public int areaCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize()
		{
		}

		private void CreatePartyUnitList()
		{
		}

		private CharaList CreateSupportCharaParam(CharaList chara, int charaAverageLv)
		{
			return null;
		}

		public void InitializeBotTutorial()
		{
		}

		public void InitializeParamOverwrite()
		{
		}

		public string GetScenePath(int areaIdx)
		{
			return null;
		}

		public string GetAreaName(int areaIdx)
		{
			return null;
		}

		public PartyUnit GetPartyUnit(int partyIdx, InGameDef.SwitchPartyNoList no)
		{
			return null;
		}

		public int GetPartyUnitCount(InGameDef.SwitchPartyNoList no)
		{
			return default(int);
		}

		public PartyUnit GetSupportUnit()
		{
			return null;
		}

		public PartyUnit GetGuestUnit()
		{
			return null;
		}

		public EventBoost GetEventBoost()
		{
			return null;
		}

		public List<GameEventPassive> GetEventPassiveList()
		{
			return null;
		}

		public void SetProloguePartyDragon(int dragonId, int level = 1)
		{
		}

		public void SetDummyArea(string[] areaList)
		{
		}

		public void SetDummyScene(string[] sceneList)
		{
		}

		public UnitBaseParam GetFortElemetalBonus(ElementalType type)
		{
			return null;
		}

		public UnitBaseParam GetAlbumElemetalBonus(ElementalType type)
		{
			return null;
		}

		public UnitBaseParam GetFortBonusPlusValue()
		{
			return null;
		}

		public UnitBaseParam GetFortDragonAlbumBonus(ElementalType type)
		{
			return null;
		}

		public UnitBaseParam GetFortWeaponBonus(WeaponType type)
		{
			return null;
		}

		public DragonBonusParam GetFortDragonBonus(ElementalType type)
		{
			return null;
		}

		private void SetParamOverwriteChara(CharaList chara, int overwrite_id)
		{
		}

		private void SetParamOverwriteDragon(DragonList dragon)
		{
		}

		private void SetParamOverwriteWeaponBody(GameWeaponBody weapon)
		{
		}

		private void SetParamOverwriteAbilityCrest(GameAbilityCrest crest)
		{
		}

		public void SetGuestData(QuestGuestDataElement guest)
		{
		}

		public PartyUnit GetGuestData(QuestGuestDataElement guest)
		{
			return null;
		}

		private void SetParamChara(out CharaList chara, int charaId, int charaLv = 1)
		{
		}

		private void SetParamDragon(out DragonList dragon, int dragonId, int dragonLv)
		{
		}

		private void SetParamWeaponBody(out GameWeaponBody weapon, int weaponBodyId, int buildupCount)
		{
		}

		private void SetParamAbilityCrest(out AbilityCrestList abilityCrest, int abilityCrestId, int buildupCount)
		{
		}

		public void SetPrologueParty()
		{
		}

		public void SetLocalParty(int partyIdx)
		{
		}

		private GameAbilityCrest[] CreateAndCopyAbilityCrestList(int[] equipAbilityCrestIdList)
		{
			return null;
		}

		private EditSkillCharaData CreateEditSkillCharaData(int edit_skill_chara_id)
		{
			return null;
		}

		public void SetDummyParty(int num, int[] charaIdList, int[] dragonIdList, int[] weaponIdList)
		{
		}

		private void SetDummyChara(out CharaList chara, int charaId)
		{
		}

		private void SetDummyDragon(out DragonList dragon, int dragonId)
		{
		}

		private void SetDummyWeapon(out GameWeaponBody weapon, int weaponBodyId)
		{
		}
	}
}
