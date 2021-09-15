/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Bullet;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameBuffUI : SingletonMonoBehaviour<Gluon.InGameBuffUI>
	{
		// Fields
		[Header]
		[SerializeField]
		private Sprite[] numberIcon;
		[SerializeField]
		private Sprite[] signIcon;
		[Header]
		[SerializeField]
		[Tooltip]
		private float interval;
		private Dictionary<CharacterBase, BuffDataInfo> _charaBuffDataInfoDic;
		private Dictionary<CharacterBuffType, BuffIconDataElement> _buffIconDataDic;
		private Dictionary<CharacterBuffType, BuffIconDataElement> _debuffIconDataDic;
		private List<StockBulletObject> _workStockBulletList;
		private List<CharacterAuraCtrl.Parameter> _workAuraList;
		private List<int> _workBuffIconIdList;
		private Dictionary<int, int> _workStockBulletLevelCountDic;
		private float currentInterval;
		private float currentCollectInterval;
		private static readonly Dictionary<CharacterBuffType, int> BuffIconIdDic;
		private static readonly Dictionary<CharacterBuffType, int> DebuffIconIdDic;
		private static readonly Dictionary<UniqueBuffIconType, int> UniqueBuffIconIdDic;
		private static readonly Dictionary<AuraType, int> AuraIconIdDic;
		private static readonly List<List<int>> BulletLevelIconIdList;
		public static readonly Color NumberColor;
		public static readonly int DefinBuffIconID_Petrifaction;
		public static readonly int DefinBuffIconID_LimiterCancel;
		public static readonly int DefinBuffIconID_Enchantment;
		public static readonly int DefinBuffIconID_Cartridge;
		public static readonly int DefinBuffIconID_Corrosion;
		public static readonly int DefinBuffIconID_LockedOn;
		public static readonly float ListCollectIntervalTime;
		public static readonly int BuffDataReserveNum;
	
		// Nested types
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
	
		public enum ValueDisplayType
		{
			None = 0,
			Percent = 1,
			Count = 2,
			Quantity = 3,
			Level = 4
		}
	
		public enum GaugeDisplayType
		{
			Both = 0,
			Buff = 1,
			Debuff = 2
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
			private CharacterBuffType _BuffType_k__BackingField;
			[CompilerGenerated]
			private bool _IsBuff_k__BackingField;
			[CompilerGenerated]
			private int _ConditionId_k__BackingField;
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
			private int _InitBuffIconId_k__BackingField;
			[CompilerGenerated]
			private int _BuffIconId_k__BackingField;
			[CompilerGenerated]
			private Sprite _IconImage_k__BackingField;
			[CompilerGenerated]
			private ValueDisplayType _ValueDispType_k__BackingField;
			[CompilerGenerated]
			private GaugeDisplayType _GaugeDispType_k__BackingField;
			public Tweener[] tweener;
			public float alpha;
			private const float AnimDuration = 0.5f;
	
			// Properties
			public bool IsNew { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public CharacterBuffType BuffType { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsBuff { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int ConditionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
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
			public int InitBuffIconId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int BuffIconId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Sprite IconImage { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public ValueDisplayType ValueDispType { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public GaugeDisplayType GaugeDispType { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public BuffData();
	
			// Methods
			public void Set(CharacterBase chara, CharacterBuffType buffType, bool isBuff, int conditionId, int productId, int count, int percent, int level, float durationTime, float lifeTime, int quantity, int durationTimeScale);
			public void Update(CharacterBase chara, int count, int percent, int level, float durationTime, float lifeTime, int quantity, int durationTimeScale);
			public void SetAlphaAnimation(bool visible);
			public void ClearValue();
			[CompilerGenerated]
			private void _.ctor_b__79_0(float v);
			[CompilerGenerated]
			private void _.ctor_b__79_1(float v);
		}
	
		public class BuffDataInfo
		{
			// Fields
			public List<BuffData> buffList;
			public List<BuffData> debuffList;
			public List<BuffData> bulletBuffList;
			public List<BuffData> standbyList;
			public List<BuffData> allBuffDebuffList;
			public List<BuffData> statusInfoAllBuffDebuffList;
			private List<BuffData> workBuffList;
			public bool isRequestUpdate;
	
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
			public BuffDataInfo();
	
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
		public void NotifyBuffDebuffStatusChange(CharacterBase chara);
		private void CollectBuff(CharacterBase chara, BuffDataInfo buffInfo, out bool isBuffAnim, out bool isDebuffAnim);
		private bool CollectBuff(CharacterBase chara, CharacterBuff buffCtrl, BuffDataInfo buffInfo, CharacterBuffType buffType, out bool isNewData);
		private bool CollectBuff(CharacterBase chara, CharacterBuff buffCtrl, BuffDataInfo buffInfo, CharacterBuffType buffType, bool isBuff, out bool isNewData);
		private bool SetBuffList(CharacterBase chara, List<BuffData> buffList, List<BuffData> standbyBuffList, CharacterBuffType buffType, bool isBuff, int buffIconId, int conditionId, int productId, int count, int percent, int level, float durationTime, float lifeTime, int quantity, int durationTimeScale);
		private bool IsValidValue(CharacterBuffType type, bool isBuff, int value);
		private static int GetSign(float rate);
		public Sprite GetBuffSpriteForBuffData(CharacterBase chara, int index, out float alpha, out int count);
		public Sprite GetDebuffSpriteForDebuffData(CharacterBase chara, int index, out float alpha, out int count);
		public Sprite GetBuffSprite(int buffIconId);
		private bool GetBuffSprite(int buffIconId, int level, out Sprite sprite, out int destBuffIconId);
		public Sprite GetBuffSprite(CharacterBuffType buffType, int conditionId, bool isBuff);
		public Sprite GetUniqueBuffSprite(UniqueBuffIconType uniqueIconType);
		public Sprite GetAuraSprite(AuraType auraType);
		public Sprite GetCountSprite(int value);
		public bool GetCountSprite(int count, out Sprite sprt10, out Sprite sprt01);
		public Sprite GetSignImage(SignIconType type);
		public bool GetAllBuffDebuffInfo(CharacterBase chara, out List<BuffData> list);
		public bool GetStatusInfoAllBuffDebuffInfo(CharacterBase chara, out List<BuffData> list);
		public bool GetAuraInfo(CharacterBase chara, ref List<CharacterAuraCtrl.Parameter> selfList, ref List<CharacterAuraCtrl.Parameter> partyList);
		private static int CompareAuraData(CharacterAuraCtrl.Parameter x, CharacterAuraCtrl.Parameter y);
		public static bool IsDisplayTypeBuffLevel(int buffIconId);
		public static bool GetBulletLevelBuffIconId(int srcBuffIconId, int level, out int destBuffIconId);
		public static bool HasLockedOn(CharacterBase chara);
		public static bool HasIronWall(CharacterBase chara);
		public bool GetDispData(int id, out string iconName, out ValueDisplayType valueDispType, out GaugeDisplayType gaugeDispType);
		public bool GetDispData(CharacterBuffType buffType, int conditionId, bool isBuff, out bool isSpecifyBuffIconId, out int buffIconId, out string iconName, out ValueDisplayType valueDispType, out GaugeDisplayType gaugeDispType);
		private bool GetDispDataForBuffType(CharacterBuffType buffType, bool isBuff, out int buffIconId, out string iconName, out ValueDisplayType valueDispType, out GaugeDisplayType gaugeDispType);
		private bool GetDispDataForBuffType(Dictionary<CharacterBuffType, int> iconIdDic, Dictionary<CharacterBuffType, BuffIconDataElement> iconDataDic, CharacterBuffType buffType, out BuffIconDataElement bide);
	}
}
