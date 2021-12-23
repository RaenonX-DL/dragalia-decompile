using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Bullet;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class InGameBuffUI : SingletonMonoBehaviour<InGameBuffUI>
	{
		public enum UniqueBuffIconType
		{
			None,
			Mikoto,
			Ezerit,
			Julietta,
			SkillEnhanced,
			SkillGrantedFreeze,
			Naveed,
			Ieyasu,
			MartialArt,
			SkillGrantedSwoon,
			Albert,
			Mym,
			Verica,
			SkillShift,
			SkillGrantedSlipHp,
			AttackDebuffGrantUp,
			HPDrain,
			ActionGrantedSwoon,
			DemeritEnhance,
			Buff_0028,
			Elisanne,
			LimiterCancel,
			RestrictAct,
			CriticalSet,
			CriticalSet2,
			CriticalSet3,
			RemoveDamage,
			DpCharge,
			SkillGrantedHPDrain,
			Mode_1_1,
			Mode_1_2,
			Mode_1_3,
			Mode_2_1,
			Mode_2_2,
			SacrificeShield,
			KillerPoison,
			Mode_3_1,
			Mode_3_2,
			Hunt,
			StackEnhanced,
			StackEnhanced2,
			Mode_4_1,
			Mode_4_2,
			HealInvalid,
			SkillGrantedFrostbite,
			SkillEnhanced2,
			SkillPowerPlus,
			BAEnhanced_1_1,
			BAEnhanced_1_2,
			BAGrantedDispel,
			SkillEnhanced3,
			Option,
			Piece_1,
			Piece_2,
			Piece_3,
			Piece_4,
			Combatant,
			SacrificeShield2,
			SkillEnhanced_4_1,
			SkillEnhanced_4_2,
			Mode_5_1,
			Depression,
			RecoverySpDown,
			Mode_6_1,
			Enchantment,
			StackEnhanced3,
			Buff_0001,
			Debuff_0001,
			ComboShift,
			Hopelessness,
			OverCharge,
			Hiding,
			DebuffGrantUp,
			Cartridge,
			RecoverySpUp,
			Buff_0002,
			Buff_0003,
			Buff_0004,
			Buff_0005,
			Buff_0006,
			Buff_0007,
			Buff_0008,
			Buff_0009,
			Buff_0010,
			Buff_0011,
			EnhancedBurstAttack,
			Buff_0012,
			Buff_0013,
			Buff_0014_1,
			Buff_0014_2,
			Buff_0015,
			Buff_0016,
			Buff_0017,
			Buff_0018,
			KillerTribeMagicCreature,
			Buff_0019,
			Corrosion,
			Buff_0020,
			Buff_0021,
			Buff_0022,
			Buff_0023,
			Buff_0024,
			Buff_0025,
			Buff_0026,
			Debuff_0002,
			EnhancedWater,
			EnhancedWind,
			EnhancedLight,
			Buff_0027,
			Buff_0029,
			Buff_0030,
			Buff_0031,
			Buff_0032,
			Buff_0033,
			Buff_0034,
			EnhancedFire,
			EnhancedDark,
			Buff_0035,
			Buff_0036,
			Buff_0037,
			Buff_0038,
			Buff_0039,
			Buff_0040,
			Buff_0041,
			Buff_0042,
			Buff_0043,
			Buff_0044,
			Buff_0045,
			Buff_0046,
			Buff_0047,
			Buff_9001,
			Buff_9002,
			Buff_9003,
			Buff_9004,
			Buff_9005,
			Buff_9006,
			Buff_9007,
			Buff_9008,
			Buff_9009,
			Debuff_0003,
			Debuff_0004
		}

		public enum ValueDisplayType
		{
			None,
			Percent,
			Count,
			Quantity,
			Level,
			DurationNum
		}

		public enum GaugeDisplayType
		{
			Both,
			Buff,
			Debuff
		}

		public enum SignIconType
		{
			Plus,
			Minus,
			Multiple,
			Percent,
			Level
		}

		public class BuffData
		{
			public Tweener[] tweener;

			public float alpha;

			private const float AnimDuration = 0.5f;

			public bool IsNew
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

			public CharacterBuffType BuffType
			{
				[CompilerGenerated]
				get
				{
					return default(CharacterBuffType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool IsBuff
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

			public int ConditionId
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

			public int ProductId
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

			public int Count
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

			public int Percent
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

			public int Quantity
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

			public int Level
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

			public int DurationNum
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

			public float DurationTime
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int DurationTimeScale
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

			public float DurationTimeRate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float LifeTime
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int CreateFrame
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

			public int InitBuffIconId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int BuffIconId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Sprite IconImage
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

			public ValueDisplayType ValueDispType
			{
				[CompilerGenerated]
				get
				{
					return default(ValueDisplayType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public GaugeDisplayType GaugeDispType
			{
				[CompilerGenerated]
				get
				{
					return default(GaugeDisplayType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void Set(CharacterBase chara, CharacterBuffType buffType, bool isBuff, int conditionId, int productId, int count, int percent, int level, int durationNum, float durationTime, float lifeTime, int quantity, int durationTimeScale)
			{
			}

			public void Update(CharacterBase chara, int count, int percent, int level, int durationNum, float durationTime, float lifeTime, int quantity, int durationTimeScale)
			{
			}

			public void SetAlphaAnimation(bool visible)
			{
			}

			public void ClearValue()
			{
			}
		}

		public class BuffDataInfo
		{
			public List<BuffData> buffList;

			public List<BuffData> debuffList;

			public List<BuffData> bulletBuffList;

			public List<BuffData> standbyList;

			public List<BuffData> allBuffDebuffList;

			public List<BuffData> statusInfoAllBuffDebuffList;

			private List<BuffData> workBuffList;

			public bool isRequestUpdate;

			public void ClearAll()
			{
			}

			public void ClearValue()
			{
			}

			public void RemoveBuffDebuff()
			{
			}

			private void SetAnimation(List<BuffData> list)
			{
			}

			public void SetBuffAnimation()
			{
			}

			public void SetDebuffAnimation()
			{
			}

			private void SwapList(List<BuffData> list)
			{
			}

			public void Swap()
			{
			}

			public void UpdateAllBuffDebuffList()
			{
			}

			private void CollectAllBuffDebuffList()
			{
			}

			private void SortBuffDebuffList(ref List<BuffData> src, ref List<BuffData> dest)
			{
			}

			private static int CompareBuffData(BuffData x, BuffData y)
			{
				return default(int);
			}
		}

		[SerializeField]
		[Header("resource")]
		private Sprite[] numberIcon;

		[SerializeField]
		private Sprite[] signIcon;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³æ\u009b\u00b4æ\u0096°é\u0096\u0093é\u009a\u0094")]
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

		public void SetCharacter(CharacterBase chara, bool isPlayerCharacter)
		{
		}

		private void Update()
		{
		}

		public void NotifyBuffDebuffStatusChange(CharacterBase chara)
		{
		}

		private void CollectBuff(CharacterBase chara, BuffDataInfo buffInfo, out bool isBuffAnim, out bool isDebuffAnim)
		{
		}

		private bool CollectBuff(CharacterBase chara, CharacterBuff buffCtrl, BuffDataInfo buffInfo, CharacterBuffType buffType, out bool isNewData)
		{
			return default(bool);
		}

		private bool CollectBuff(CharacterBase chara, CharacterBuff buffCtrl, BuffDataInfo buffInfo, CharacterBuffType buffType, bool isBuff, out bool isNewData)
		{
			return default(bool);
		}

		private bool SetBuffList(CharacterBase chara, List<BuffData> buffList, List<BuffData> standbyBuffList, CharacterBuffType buffType, bool isBuff, int buffIconId, int conditionId, int productId, int count, int percent, int level, int durationNum, float durationTime, float lifeTime, int quantity, int durationTimeScale)
		{
			return default(bool);
		}

		private bool IsValidValue(CharacterBuffType type, bool isBuff, int value)
		{
			return default(bool);
		}

		private static int GetSign(float rate)
		{
			return default(int);
		}

		public Sprite GetBuffSpriteForBuffData(CharacterBase chara, int index, out float alpha, out int count)
		{
			return null;
		}

		public Sprite GetDebuffSpriteForDebuffData(CharacterBase chara, int index, out float alpha, out int count)
		{
			return null;
		}

		public Sprite GetBuffSprite(int buffIconId)
		{
			return null;
		}

		private bool GetBuffSprite(int buffIconId, int level, out Sprite sprite, out int destBuffIconId)
		{
			return default(bool);
		}

		public Sprite GetBuffSprite(CharacterBuffType buffType, int conditionId, bool isBuff)
		{
			return null;
		}

		public Sprite GetUniqueBuffSprite(UniqueBuffIconType uniqueIconType)
		{
			return null;
		}

		public Sprite GetAuraSprite(AuraType auraType)
		{
			return null;
		}

		public Sprite GetCountSprite(int value)
		{
			return null;
		}

		public bool GetCountSprite(int count, out Sprite sprt10, out Sprite sprt01)
		{
			return default(bool);
		}

		public Sprite GetSignImage(SignIconType type)
		{
			return null;
		}

		public bool GetAllBuffDebuffInfo(CharacterBase chara, out List<BuffData> list)
		{
			return default(bool);
		}

		public bool GetStatusInfoAllBuffDebuffInfo(CharacterBase chara, out List<BuffData> list)
		{
			return default(bool);
		}

		public bool GetAuraInfo(CharacterBase chara, ref List<CharacterAuraCtrl.Parameter> selfList, ref List<CharacterAuraCtrl.Parameter> partyList)
		{
			return default(bool);
		}

		private static int CompareAuraData(CharacterAuraCtrl.Parameter x, CharacterAuraCtrl.Parameter y)
		{
			return default(int);
		}

		public static bool IsDisplayTypeBuffLevel(int buffIconId)
		{
			return default(bool);
		}

		public static bool GetBulletLevelBuffIconId(int srcBuffIconId, int level, out int destBuffIconId)
		{
			return default(bool);
		}

		public static bool HasLockedOn(CharacterBase chara)
		{
			return default(bool);
		}

		public static bool HasIronWall(CharacterBase chara)
		{
			return default(bool);
		}

		public bool GetDispData(int id, out string iconName, out ValueDisplayType valueDispType, out GaugeDisplayType gaugeDispType)
		{
			return default(bool);
		}

		public bool GetDispData(CharacterBuffType buffType, int conditionId, bool isBuff, out bool isSpecifyBuffIconId, out int buffIconId, out string iconName, out ValueDisplayType valueDispType, out GaugeDisplayType gaugeDispType)
		{
			return default(bool);
		}

		private bool GetDispDataForBuffType(CharacterBuffType buffType, bool isBuff, out int buffIconId, out string iconName, out ValueDisplayType valueDispType, out GaugeDisplayType gaugeDispType)
		{
			return default(bool);
		}

		private bool GetDispDataForBuffType(Dictionary<CharacterBuffType, int> iconIdDic, Dictionary<CharacterBuffType, BuffIconDataElement> iconDataDic, CharacterBuffType buffType, out BuffIconDataElement bide)
		{
			return default(bool);
		}
	}
}
