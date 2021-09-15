/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Bullet;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameBuffUI : SingletonMonoBehaviour<Gluon.InGameBuffUI>
	{
		// Fields
		[Header]
		[SerializeField]
		private Sprite[] buffIcon;
		[SerializeField]
		private Sprite[] numberIcon;
		[SerializeField]
		private Sprite[] signIcon;
		[SerializeField]
		private Sprite[] statusIcon;
		[Header]
		[SerializeField]
		[Tooltip]
		private float interval;
		private float currentInterval;
		private float currentCollectInterval;
		private List<int> workUniqueBuffIconList;
		private static readonly Dictionary<CharacterBuffType, int> BuffIconDic;
		private static readonly Dictionary<CharacterBuffType, int> DebuffIconDic;
		private static readonly Dictionary<UniqueBuffIconType, int> UniqueBuffIconDic;
		private static readonly Dictionary<EnemyAbilityType, int> EnemyAbilityIconDic;
		private static readonly List<List<UniqueBuffIconType>> BulletLevelIconList;
		private static readonly Dictionary<AuraType, int> AuraIconDic;
		public static readonly int EnumUniqueBuffIconCount;
		public static readonly Color NumberColor;
		public const float ListCollectIntervalTime = 0.16666667f;
		public static readonly int BuffDataReserveNum;
		private Dictionary<CharacterBase, BuffDataList> dictionary;
		private List<StockBulletObject> workStockBulletList;
		private Dictionary<int, int> workStockBulletLevelCountDic;
		private List<CharacterAuraCtrl.Parameter> _workAuraList;
	
		// Nested types
		public enum BuffIconType
		{
			Invalid = -1,
			HPPlus = 0,
			AttackPlus = 1,
			DefensePlus = 2,
			RecoveryPlus = 3,
			CriticalPlus = 4,
			SkillPowerPlus = 5,
			BurstPowerPlus = 6,
			AttackSpeedPlus = 7,
			HPMinus = 8,
			AttackMinus = 9,
			DefenseMinus = 10,
			RecoveryMinus = 11,
			CriticalMinus = 12,
			SkillPowerMinus = 13,
			BurstPowerMinus = 14,
			ResistPoisonPlus = 15,
			ResistBurnPlus = 16,
			ResistFreezePlus = 17,
			ResistParalysisPlus = 18,
			ResistDarknessPlus = 19,
			ResistSwoonPlus = 20,
			ResistCursePlus = 21,
			ResistSlowMovePlus = 22,
			ResistPoisonMinus = 23,
			ResistBurnMinus = 24,
			ResistFreezeMinus = 25,
			ResistParalysisMinus = 26,
			ResistDarknessMinus = 27,
			ResistSwoonMinus = 28,
			ResistCurseMinus = 29,
			ResistSlowMoveMinus = 30,
			DamageShield = 31,
			DamageCutFire = 32,
			DamageCutWater = 33,
			DamageCutWind = 34,
			DamageCutLight = 35,
			DamageCutDark = 36,
			WeakInvalid = 37,
			Reraise = 38,
			Armored = 39,
			RegeneHp = 40,
			EnhancedCritical = 41,
			Mikoto = 42,
			Ezerit = 43,
			Julietta = 44,
			SkillEnhanced = 45,
			SkillGrantedPoison = 46,
			SkillGrantedBurn = 47,
			SkillGrantedFreeze = 48,
			SkillGrantedParalysis = 49,
			SkillGrantedDarkness = 50,
			SkillGrantedSwoon = 51,
			SkillGrantedCurse = 52,
			SkillGrantedRebirth = 53,
			SkillGrantedSlowmove = 54,
			SkillGrantedSleep = 55,
			Naveed = 56,
			Tension = 57,
			SlipHp = 58,
			Ieyasu = 59,
			MartialArt = 60,
			Nicked = 61,
			Albert = 62,
			RecoverySp = 63,
			Mym = 64,
			Verica = 65,
			Malaise = 66,
			AddPoison = 67,
			AddBurn = 68,
			AddFreeze = 69,
			AddParalysis = 70,
			AddDarkness = 71,
			AddSwoon = 72,
			AddCurse = 73,
			AddRebirth = 74,
			AddSlowmove = 75,
			AddSleep = 76,
			DebuffGrantUp = 77,
			Reserve = 78,
			Petrifaction = 79,
			SkillShift = 80,
			SkillGrantedSlipHp = 81,
			ActionDebuffGrantUp = 82,
			HPDrain = 83,
			ActionGrantedPoison = 84,
			ActionGrantedBurn = 85,
			ActionGrantedFreeze = 86,
			ActionGrantedParalysis = 87,
			ActionGrantedDarkness = 88,
			ActionGrantedSwoon = 89,
			ActionGrantedCurse = 90,
			ActionGrantedRebirth = 91,
			ActionGrantedSlowmove = 92,
			ActionGrantedSleep = 93,
			RegeneSpPlus = 94,
			RegeneSpMinus = 95,
			DamageShield2 = 96,
			DragonDamageUp = 97,
			DpChargeMyParty = 98,
			DemeritEnhance = 99,
			Buff_0028 = 100,
			Elisanne = 101,
			LimiterCancel = 102,
			RestrictAct = 103,
			CriticalSet = 104,
			CriticalSet2 = 105,
			CriticalSet3 = 106,
			RemoveDamage = 107,
			DpCharge = 108,
			SkillGrantedHPDrain = 109,
			DamageCut = 110,
			ChargeSpeed = 111,
			GoldenBarrier = 112,
			Mode_1_1 = 113,
			Mode_1_2 = 114,
			Mode_1_3 = 115,
			Mode_2_1 = 116,
			Mode_2_2 = 117,
			Inspiration = 118,
			SacrificeShield = 119,
			KillerPoison = 120,
			KillerBurn = 121,
			KillerFreeze = 122,
			KillerParalysis = 123,
			KillerDarkness = 124,
			KillerSwoon = 125,
			KillerCurse = 126,
			KillerRebirth = 127,
			KillerSlowmove = 128,
			KillerSleep = 129,
			KillerFrostbite = 130,
			Mode_3_1 = 131,
			Mode_3_2 = 132,
			Hunt = 133,
			StackEnhanced = 134,
			MoveSpeedRate = 135,
			StackEnhanced2 = 136,
			Mode_4_1 = 137,
			Mode_4_2 = 138,
			HealInvalid = 139,
			SkillGrantedFrostbite = 140,
			SkillEnhanced2 = 141,
			ChainTimeExtension = 142,
			BAEnhanced_1_1 = 143,
			BAEnhanced_1_2 = 144,
			BAGrantedDispel = 145,
			SkillEnhanced3 = 146,
			Option = 147,
			Piece_1 = 148,
			Piece_2 = 149,
			Piece_3 = 150,
			Piece_4 = 151,
			Combatant = 152,
			SacrificeShield2 = 153,
			SkillEnhanced_4_1 = 154,
			SkillEnhanced_4_2 = 155,
			Mode_5_1 = 156,
			Depression = 157,
			RecoverySpDown = 158,
			Mode_6_1 = 159,
			Enchantment = 160,
			StackEnhanced3 = 161,
			RegeneDpPlus = 162,
			RegeneDpMinus = 163,
			Buff_0001 = 164,
			Debuff_0001 = 165,
			ComboShift = 166,
			Hopelessness = 167,
			OverCharge = 168,
			DamageCutFireMinus = 169,
			DamageCutWaterMinus = 170,
			DamageCutWindMinus = 171,
			DamageCutLightMinus = 172,
			DamageCutDarkMinus = 173,
			Hiding = 174,
			Cartridge = 175,
			Buff_0002 = 176,
			EnhancedFire = 177,
			EnhancedWater = 178,
			EnhancedWind = 179,
			EnhancedLight = 180,
			EnhancedDark = 181,
			Buff_0003 = 182,
			Buff_0004 = 183,
			EnhancedBurstAttack = 184,
			Buff_0005 = 185,
			Buff_0006 = 186,
			Buff_0007 = 187,
			Buff_0008 = 188,
			Buff_0009 = 189,
			Buff_0010 = 190,
			Buff_0011 = 191,
			Buff_0012 = 192,
			Buff_0013 = 193,
			Buff_0014_1 = 194,
			Buff_0014_2 = 195,
			Buff_0015 = 196,
			ResistSleepPlus = 197,
			ResistFrostbitePlus = 198,
			ResistFlashheatPlus = 199,
			ResistCrashwindPlus = 200,
			ResistDarkabsPlus = 201,
			ResistDestroyfirePlus = 202,
			ResistSleepMinus = 203,
			ResistFrostbiteMinus = 204,
			ResistFlashheatMinus = 205,
			ResistCrashwindMinus = 206,
			ResistDarkabsMinus = 207,
			ResistDestroyfireMinus = 208,
			Buff_0016 = 209,
			Buff_0017 = 210,
			Buff_0018 = 211,
			KillerTribeMagicCreature = 212,
			KillerTribeNatural = 213,
			KillerTribeDemiHuman = 214,
			KillerTribeBeast = 215,
			KillerTribeUndead = 216,
			KillerTribeDemon = 217,
			KillerTribeHuman = 218,
			KillerTribeDragon = 219,
			Buff_0019 = 220,
			KillerFlashheat = 221,
			KillerCrashwind = 222,
			KillerDarkabs = 223,
			KillerDestroyfire = 224,
			BurstSpeedPlus = 225,
			BurstSpeedMinus = 226,
			BuffExtension = 227,
			DebuffExtension = 228,
			CurseOfEmptiness = 229,
			Corrosion = 230,
			Buff_0020 = 231,
			Buff_0021 = 232,
			Buff_0022 = 233,
			Buff_0023 = 234,
			Buff_0024 = 235,
			Buff_0025 = 236,
			Buff_0026 = 237,
			Debuff_0002 = 238,
			Buff_0027 = 239,
			Buff_0029 = 240,
			LockedOn = 241,
			IronWall = 242,
			Buff_0030 = 243,
			Buff_0031 = 244,
			Buff_0032 = 245,
			Buff_0033 = 246,
			Buff_0034 = 247,
			Buff_0035 = 248,
			Buff_0036 = 249,
			Buff_0037 = 250,
			Buff_0038 = 251,
			Buff_0039 = 252,
			Buff_0040 = 253,
			Buff_0041 = 254,
			Buff_0042 = 255,
			Buff_0043 = 256,
			Buff_0044 = 257,
			Buff_0045 = 258,
			Buff_0046 = 259,
			Buff_0047 = 260,
			Buff_0048 = 261,
			Buff_0049 = 262,
			Buff_0050 = 263,
			Buff_0051 = 264,
			Buff_0052 = 265,
			Buff_9001 = 266,
			Buff_9002 = 267,
			Buff_9003 = 268,
			Buff_9004 = 269,
			Buff_9005 = 270,
			Buff_9006 = 271,
			Buff_9007 = 272,
			Buff_9008 = 273,
			Buff_9009 = 274,
			AddFrostbite = 275,
			AddFlashheat = 276,
			AddCrashwind = 277,
			AddDarkabs = 278,
			AddDestroyfire = 279,
			Debuff_0003 = 280,
			Debuff_0004 = 281
		}
	
		public enum UniqueBuffIconType
		{
			None = 0,
			Mikoto = 1,
			Ezerit = 2,
			Julietta = 3,
			SkillEnhanced = 4,
			SkillGrantedFreeze = 5,
			Naveed = 6,
			Ieyasu = 7,
			MartialArt = 8,
			SkillGrantedSwoon = 9,
			Albert = 10,
			Mym = 11,
			Verica = 12,
			SkillShift = 13,
			SkillGrantedSlipHp = 14,
			AttackDebuffGrantUp = 15,
			HPDrain = 16,
			ActionGrantedSwoon = 17,
			DemeritEnhance = 18,
			Buff_0028 = 19,
			Elisanne = 20,
			LimiterCancel = 21,
			RestrictAct = 22,
			CriticalSet = 23,
			CriticalSet2 = 24,
			CriticalSet3 = 25,
			RemoveDamage = 26,
			DpCharge = 27,
			SkillGrantedHPDrain = 28,
			Mode_1_1 = 29,
			Mode_1_2 = 30,
			Mode_1_3 = 31,
			Mode_2_1 = 32,
			Mode_2_2 = 33,
			SacrificeShield = 34,
			KillerPoison = 35,
			Mode_3_1 = 36,
			Mode_3_2 = 37,
			Hunt = 38,
			StackEnhanced = 39,
			StackEnhanced2 = 40,
			Mode_4_1 = 41,
			Mode_4_2 = 42,
			HealInvalid = 43,
			SkillGrantedFrostbite = 44,
			SkillEnhanced2 = 45,
			SkillPowerPlus = 46,
			BAEnhanced_1_1 = 47,
			BAEnhanced_1_2 = 48,
			BAGrantedDispel = 49,
			SkillEnhanced3 = 50,
			Option = 51,
			Piece_1 = 52,
			Piece_2 = 53,
			Piece_3 = 54,
			Piece_4 = 55,
			Combatant = 56,
			SacrificeShield2 = 57,
			SkillEnhanced_4_1 = 58,
			SkillEnhanced_4_2 = 59,
			Mode_5_1 = 60,
			Depression = 61,
			RecoverySpDown = 62,
			Mode_6_1 = 63,
			Enchantment = 64,
			StackEnhanced3 = 65,
			Buff_0001 = 66,
			Debuff_0001 = 67,
			ComboShift = 68,
			Hopelessness = 69,
			OverCharge = 70,
			Hiding = 71,
			DebuffGrantUp = 72,
			Cartridge = 73,
			RecoverySpUp = 74,
			Buff_0002 = 75,
			Buff_0003 = 76,
			Buff_0004 = 77,
			Buff_0005 = 78,
			Buff_0006 = 79,
			Buff_0007 = 80,
			Buff_0008 = 81,
			Buff_0009 = 82,
			Buff_0010 = 83,
			Buff_0011 = 84,
			EnhancedBurstAttack = 85,
			Buff_0012 = 86,
			Buff_0013 = 87,
			Buff_0014_1 = 88,
			Buff_0014_2 = 89,
			Buff_0015 = 90,
			Buff_0016 = 91,
			Buff_0017 = 92,
			Buff_0018 = 93,
			KillerTribeMagicCreature = 94,
			Buff_0019 = 95,
			Corrosion = 96,
			Buff_0020 = 97,
			Buff_0021 = 98,
			Buff_0022 = 99,
			Buff_0023 = 100,
			Buff_0024 = 101,
			Buff_0025 = 102,
			Buff_0026 = 103,
			Debuff_0002 = 104,
			EnhancedWater = 105,
			EnhancedWind = 106,
			EnhancedLight = 107,
			Buff_0027 = 108,
			Buff_0029 = 109,
			Buff_0030 = 110,
			Buff_0031 = 111,
			Buff_0032 = 112,
			Buff_0033 = 113,
			Buff_0034 = 114,
			EnhancedFire = 115,
			EnhancedDark = 116,
			Buff_0035 = 117,
			Buff_0036 = 118,
			Buff_0037 = 119,
			Buff_0038 = 120,
			Buff_0039 = 121,
			Buff_0040 = 122,
			Buff_0041 = 123,
			Buff_0042 = 124,
			Buff_0043 = 125,
			Buff_0044 = 126,
			Buff_0045 = 127,
			Buff_0046 = 128,
			Buff_0047 = 129,
			Buff_9001 = 130,
			Buff_9002 = 131,
			Buff_9003 = 132,
			Buff_9004 = 133,
			Buff_9005 = 134,
			Buff_9006 = 135,
			Buff_9007 = 136,
			Buff_9008 = 137,
			Buff_9009 = 138,
			Debuff_0003 = 139,
			Debuff_0004 = 140
		}
	
		public enum SignIconType
		{
			Plus = 0,
			Minus = 1,
			Multiple = 2,
			Percent = 3,
			Level = 4
		}
	
		public class BuffData
		{
			// Fields
			[CompilerGenerated]
			private bool _IsNew_k__BackingField;
			[CompilerGenerated]
			private BuffIconType _BuffIcon_k__BackingField;
			[CompilerGenerated]
			private UniqueBuffIconType _UniqueBuffIcon_k__BackingField;
			[CompilerGenerated]
			private int _ProductId_k__BackingField;
			[CompilerGenerated]
			private int _Count_k__BackingField;
			[CompilerGenerated]
			private int _Percent_k__BackingField;
			[CompilerGenerated]
			private int _Quantity_k__BackingField;
			[CompilerGenerated]
			private int _Level_k__BackingField;
			[CompilerGenerated]
			private float _DurationTime_k__BackingField;
			[CompilerGenerated]
			private int _DurationTimeScale_k__BackingField;
			[CompilerGenerated]
			private float _DurationTimeRate_k__BackingField;
			[CompilerGenerated]
			private float _LifeTime_k__BackingField;
			[CompilerGenerated]
			private int _CreateFrame_k__BackingField;
			[CompilerGenerated]
			private Sprite _IconImage_k__BackingField;
			public Tweener[] tweener;
			public float alpha;
			private const float AnimDuration = 0.5f;
	
			// Properties
			public bool IsNew { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public BuffIconType BuffIcon { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public UniqueBuffIconType UniqueBuffIcon { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int ProductId { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int Count { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int Percent { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int Quantity { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int Level { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float DurationTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int DurationTimeScale { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float DurationTimeRate { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float LifeTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int CreateFrame { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Sprite IconImage { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public BuffData();
	
			// Methods
			public void SetBuffData(Sprite iconImage, BuffIconType buffIcon, UniqueBuffIconType uniqueBuffIcon, int productId, int count, int percent, int level, float durationTime, float lifeTime, int quantity, int durationTimeScale);
			public void UpdateBuffData(int count, int percent, int level, float durationTime, float lifeTime, int quantity, int durationTimeScale);
			public void SetIconImage(Sprite iconImage);
			public void SetAlphaAnimation(bool visible);
			public void ClearValue();
			[CompilerGenerated]
			private void _.ctor_b__59_0(float v);
			[CompilerGenerated]
			private void _.ctor_b__59_1(float v);
		}
	
		private class BuffDataList
		{
			// Fields
			public List<BuffData> buffList;
			public List<BuffData> debuffList;
			public List<BuffData> bulletBuffList;
			public List<BuffData> standbyList;
			public bool isRequestUpdate;
			public List<BuffData> allBuffDebuffList;
			public List<BuffData> statusInfoAllBuffDebuffList;
			private List<BuffData> workList;
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Predicate<BuffData> __9__11_0;
				public static Predicate<BuffData> __9__11_1;
				public static Predicate<BuffData> __9__11_2;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _RemoveBuffDebuff_b__11_0(BuffData d);
				internal bool _RemoveBuffDebuff_b__11_1(BuffData d);
				internal bool _RemoveBuffDebuff_b__11_2(BuffData d);
			}
	
			// Constructors
			public BuffDataList();
	
			// Methods
			public void ClearAll();
			public void ClearValue();
			public void RemoveBuffDebuff();
			private void SetAnimation(List<BuffData> list);
			public void SetBuffAnimation();
			public void SetDebuffAnimation();
			private void SwapList(List<BuffData> list);
			public void Swap();
			public void UpdateAllBuffDebuffList();
			private void CollectAllBuffDebuffList();
			private void SortBuffDebuffList(ref List<BuffData> src, ref List<BuffData> dest);
			private static int CompareBuffData(BuffData x, BuffData y);
		}
	
		// Constructors
		public InGameBuffUI();
		static InGameBuffUI();
	
		// Methods
		public void SetCharacter(CharacterBase chara, bool isPlayerCharacter);
		private void Update();
		private bool SetBuffList(List<BuffData> list, List<BuffData> standbyList, BuffIconType buffIconType, UniqueBuffIconType uniqueBuffIconType, int productId, int count, int percent, int level, float durationTime, float lifeTime, int quantity, int durationTimeScale);
		private Sprite GetIconImage(BuffIconType buffIconType, UniqueBuffIconType uniqueBuffIconType, int level);
		public void CollectBuffCharacter(CharacterBase chara);
		private void CollectBuff(CharacterBase chara, BuffDataList list, out bool isBuffAnim, out bool isDebuffAnim);
		private bool CollectBuff(CharacterBuffType type, bool isBuff, ref CharacterBuff charaBuff, ref BuffDataList list, out bool isNewData);
		private bool IsValidValue(CharacterBuffType type, bool isBuff, int value);
		private static int GetSign(float rate);
		public Sprite GetBuffSprite(CharacterBase chara, int index, out float alpha, out int count);
		public Sprite GetDebuffSprite(CharacterBase chara, int index, out float alpha, out int count);
		public bool GetCountSprite(int count, out Sprite sprt10, out Sprite sprt01);
		public Sprite GetBuffSprite(CharacterBuffType type, float rate);
		public Sprite GetBuffSprite(BuffIconType type);
		public Sprite GetUniqueBuffSprite(UniqueBuffIconType type);
		public Sprite GetStatusSprite(AbnormalStatusType type);
		public Sprite GetEnemyAbilitySprite(EnemyAbilityType type);
		public Sprite GetAuraSprite(AuraType type);
		public Sprite GetNumberImage(int value);
		public Sprite GetSignImage(SignIconType type);
		public bool GetAllBuffDebuffInfo(CharacterBase chara, out List<BuffData> list);
		public bool GetStatusInfoAllBuffDebuffInfo(CharacterBase chara, out List<BuffData> list);
		public bool GetBulletBuffInfo(CharacterBase chara, out List<BuffData> list);
		public bool GetAuraInfo(CharacterBase chara, ref List<CharacterAuraCtrl.Parameter> selfList, ref List<CharacterAuraCtrl.Parameter> partyList);
		private static int CompareAuraData(CharacterAuraCtrl.Parameter x, CharacterAuraCtrl.Parameter y);
		public static bool IsDisplayTypeCount(BuffIconType buffIconType, UniqueBuffIconType uniqueBuffIconType);
		public static bool IsDisplayTypeQuantity(BuffIconType type);
		public static bool IsDisplayTypeLevel(UniqueBuffIconType uniqueBuffIconType);
		public static bool IsDisplayTypeBuffLevel(UniqueBuffIconType uniqueBuffIconType);
		public static bool IsDisplayTypeNone(BuffIconType type);
		public static bool IsBuffTypePlus(BuffIconType type);
		public static bool IsBuffTypeMinus(BuffIconType type);
		public static bool IsBuffTypeMinus(UniqueBuffIconType uniqueBuffIconType);
		public static bool IsUniqueBuffType(BuffIconType type);
		public static bool IsEnemyAbilityType(BuffIconType type);
		public static int GetBuffIconTypeId(CharacterBuffType type);
		public static bool GetBuffIconTypeId(CharacterBuffType type, float rate, out BuffIconType buffIcon);
		public static bool GetBulletLevelIconTypeId(UniqueBuffIconType uniqueBuffIconType, int level, out UniqueBuffIconType bulletLevelIconType);
		public static bool HasLockedOn(CharacterBase chara);
		public static bool HasIronWall(CharacterBase chara);
	}
}
