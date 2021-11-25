using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;

namespace Gluon
{
	public class DamageCalculation
	{
		private enum DamageFlow
		{
			None,
			P2E,
			E2P,
			P2P,
			E2E
		}

		public enum KillerState
		{
			None = 0,
			AbsPoison = 1,
			AbsBurn = 2,
			AbsFreeze = 3,
			AbsParalysis = 4,
			AbsDarkness = 5,
			AbsSwoon = 6,
			AbsCurse = 7,
			AbsRebirth = 8,
			AbsSlowMove = 9,
			AbsSleep = 10,
			AbsFrostbite = 11,
			AbsFlashheat = 12,
			AbsCrashwind = 13,
			AbsDarkabs = 14,
			AbsDestroyfire = 0xF,
			AbsAll = 99,
			DbfHp = 101,
			DbfAttack = 102,
			DbfDefense = 103,
			DbfCritical = 104,
			DbfSkillPower = 105,
			DbfBurstPower = 106,
			DbfRecovery = 107,
			DbfGash = 108,
			BfDbfAll = 197,
			BfAll = 198,
			DbfAll = 199,
			Break = 201
		}

		public class DamageStatus
		{
			public enum Type
			{
				Normal,
				Slip,
				Extra
			}

			public struct ShieldInfo
			{
				public bool isValid;

				public bool isBreak;

				public void Reset()
				{
				}

				public ShieldInfo(ShieldInfo other)
				{
				}
			}

			public struct SubstitudeInfo
			{
				public CharacterSelector target;

				public int damage;
			}

			public ShieldInfo[] shieldInfo;

			public List<SubstitudeInfo> substitudeInfos;

			public Type type
			{
				[CompilerGenerated]
				get
				{
					return default(Type);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int value
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

			public bool isCritical
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

			public bool isKiller
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

			public float elementRate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float pureElementRate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string additionalAttackEffect
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool isTolerance
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

			public bool isDodgeAbility
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

			public bool isDodgeBuff
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

			public bool isPenetrateShield
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

			public DamageStatus(Type type_)
			{
			}

			public void Reset()
			{
			}

			public DamageStatus(DamageStatus other)
			{
			}

			public void ResetDamage()
			{
			}

			public void ResetIsDodge()
			{
			}

			public void SetValue(int value, bool isCritical, bool isKiller, bool isTolerance, float elementRate, float pureElementRate, string additionalAttackEffect = "")
			{
			}

			public void SetValueForShieldReset(int value, bool isCritical, bool isKiller, bool isTolerance, float elementRate, float pureElementRate)
			{
			}

			public bool IsValidDamageShield()
			{
				return default(bool);
			}

			public bool isValidSacrificeShield()
			{
				return default(bool);
			}

			public bool isValidDamageShieldWithoutSacrificeShield()
			{
				return default(bool);
			}

			public bool IsAnyAutoAvoid()
			{
				return default(bool);
			}
		}

		public enum FactorType
		{
			MulStart = 0,
			Mul_00 = 0,
			Mul_01 = 1,
			Mul_02 = 2,
			Mul_03 = 3,
			Mul_04 = 4,
			Mul_05 = 5,
			Mul_06 = 6,
			Mul_07 = 7,
			Mul_08 = 8,
			Mul_09 = 9,
			Mul_10 = 10,
			Mul_11 = 11,
			Mul_12 = 12,
			Mul_13 = 13,
			Mul_14 = 14,
			Mul_15 = 0xF,
			Mul_16 = 0x10,
			Mul_17 = 17,
			Mul_18 = 18,
			Mul_19 = 19,
			Mul_20 = 20,
			Mul_21 = 21,
			Mul_22 = 22,
			Mul_23 = 23,
			Mul_24 = 24,
			MulEnd = 25,
			AddStart = 26,
			Add_00 = 26,
			Add_01 = 27,
			AddEnd = 28,
			DivStart = 29,
			Div_00 = 29,
			Div_01 = 30,
			Div_02 = 0x1F,
			DivEnd = 0x20,
			SetStart = 33,
			Set_00 = 33,
			Set_01 = 34,
			Set_02 = 35,
			Set_03 = 36,
			Set_04 = 37,
			Set_05 = 38,
			Set_06 = 39,
			Set_07 = 40,
			Set_08 = 41,
			Set_09 = 42,
			Set_10 = 43,
			Set_11 = 44,
			Set_12 = 45,
			Set_13 = 46,
			SetEnd = 47
		}

		public DamageStatus normal;

		public DamageStatus slip;

		public DamageStatus extra;

		private static readonly int[,] ElementalAdvantageTable;

		public float AddDamageFactor(CharacterBase chara, float src, float value, FactorType facter)
		{
			return default(float);
		}

		public float MulDamageFactor(CharacterBase chara, float src, float value, FactorType facter)
		{
			return default(float);
		}

		public float DivDamageFactor(CharacterBase chara, float src, float value, FactorType facter)
		{
			return default(float);
		}

		public float SetDamageFactor(CharacterBase chara, float src, float value, FactorType facter)
		{
			return default(float);
		}

		public int SetIntDamageFactor(CharacterBase chara, int src, int value, FactorType facter)
		{
			return default(int);
		}

		public void Calculation(CollisionHitAttribute attr, CharacterBase dst, int shareDivideNum = 1, int followerAvoid = -1)
		{
		}

		private void CalcForFollower(CollisionHitAttribute attr, CharacterBase src, CharacterBase dst, ref float calc)
		{
		}

		private bool CalcRateForCUG(CollisionHitAttribute attr, CharacterBase dst, out float rate)
		{
			return default(bool);
		}

		public float CalculationMalaiseDamage(CharacterBase src, float calc)
		{
			return default(float);
		}

		public int CalculationAdditionalDamage(CharacterBase character, CollisionHitAttribute data)
		{
			return default(int);
		}

		private float CalculationDamageRateForDodgeFailed(CharacterBase dst, CollisionHitAttribute attr, float damageRate)
		{
			return default(float);
		}

		public void CalculationGimmickDamage(CharacterBase dst, CollisionHitAttribute attr, float gimmickAttack)
		{
		}

		private float CalculationDamping(CollisionHitAttribute currAttr, CharacterBase dst)
		{
			return default(float);
		}

		private float CalculationDistanceDamping(CollisionHitAttribute currAttr, CharacterBase dst, WeaponTypeElement wte)
		{
			return default(float);
		}

		private float CalculationBaseDamage(CollisionHitAttribute attr, CharacterBase dst, DamageStatus status)
		{
			return default(float);
		}

		private float Damping(float damage, int step, int skillId, CharacterBase src)
		{
			return default(float);
		}

		public float CalculationDefenseParameter(CharacterBase dst, float defCoef)
		{
			return default(float);
		}

		public int CalculationDamageShield(CharacterBase dst, int damage, int followerAvoid = -1, [Optional] CollisionHitAttribute attr)
		{
			return default(int);
		}

		public int CalculationSacrificeShield(CharacterBase dst, int damage, bool needSync)
		{
			return default(int);
		}

		public float DamageRandom()
		{
			return default(float);
		}

		public float HealValue(CharacterBase src, CharacterBase dst, int skillId, float power, float coef, ActionStartParameter startParameter)
		{
			return default(float);
		}

		private float DrainValue(CharacterBase src, CharacterBase dst, float power, float coef, [Optional] CharacterBase drainTarget)
		{
			return default(float);
		}

		private float CalcurationDrain(CollisionHitAttribute attr, CharacterBase dst, float coef)
		{
			return default(float);
		}

		public void CalculationHeal(CollisionHitAttribute attr, CharacterBase dst, int shareDivideNum = 1)
		{
		}

		public float CalculationSlip(CharacterBase dst, CollisionHitAttribute attr, float slipPower, bool useRandom, out bool isTolerance)
		{
			return default(float);
		}

		public int CalculationSlipAfter(float damage, int slipDamageMax = 0)
		{
			return default(int);
		}

		private float GetHitAttributeDependentCoefficient(CharacterBase src, CharacterBase dst, CollisionHitAttribute attr, float power)
		{
			return default(float);
		}

		private float GetElementalDamageRate(DamageFlow flow, ElementalType srcElemental, ElementalType dstElemental)
		{
			return default(float);
		}

		private float GetCharaElementalDamageRate(CharacterBase src, CharacterBase dst, out float pureElementRate)
		{
			return default(float);
		}

		private float GetHitElementalDamageRate(CollisionHitAttribute attr, CharacterBase dst, out float pureElementRate)
		{
			return default(float);
		}

		public static int GetElementalAdvantage(ElementalType src, ElementalType dst)
		{
			return default(int);
		}

		public float CalculationRemoveBuffExtraDamage(CollisionHitAttribute attr, CharacterBase dst)
		{
			return default(float);
		}

		private bool IsKillerState(CharacterBase dst, KillerState state)
		{
			return default(bool);
		}

		private float GetKillerRateDependsOnHitCount(CharacterBase src, CollisionHitAttribute attr)
		{
			return default(float);
		}

		private float GetAbnormalKillerDamageRate(CharacterBase src, CharacterBase dst)
		{
			return default(float);
		}

		private float GetDebuffKillerDamageRate(CharacterBase src, EnemyCharacter enemy)
		{
			return default(float);
		}

		private float GetUniqueKillerDamageRate(CharacterBase src, EnemyCharacter enemy)
		{
			return default(float);
		}

		private float GetUniqueKillerResistRate(CharacterBase dst, EnemyCharacter enemy)
		{
			return default(float);
		}

		private void EnemyModeDefense(CharacterBase src, CharacterBase dst, ref float defCoef)
		{
		}

		private void EnemyAbilityKillerForMirage(CharacterBase src, CharacterBase dst, ref float defCoef)
		{
		}

		private float ConditionallyBuffRate(CharacterBase src, CharacterBase dst, CharacterBuffType buffType, int actionId)
		{
			return default(float);
		}

		private float CriticalUpRateForDebuffEnemy(CharacterBase src, CharacterBase dst, int actionId)
		{
			return default(float);
		}

		private float CriticalUpRateForAbnormalStatusEnemy(CharacterBase src, CharacterBase dst, int actionId)
		{
			return default(float);
		}

		public float BreakDamageUpRate(CollisionHitAttribute attr)
		{
			return default(float);
		}

		private float SkillDamageUpRate(CharacterBase src, CollisionHitAttribute attr, AbilityTargetAction targetActionId)
		{
			return default(float);
		}

		public EditSkillCharaOffsetElement GetShareSkillCoefData(CharacterBase src, int skillId)
		{
			return null;
		}

		public static bool IsIgnoreActionConsumeBuffServant(CharacterBase chara)
		{
			return default(bool);
		}
	}
}
