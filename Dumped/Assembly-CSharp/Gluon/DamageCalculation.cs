/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DamageCalculation
	{
		// Fields
		public DamageStatus normal;
		public DamageStatus slip;
		public DamageStatus extra;
		private static readonly int[,] ElementalAdvantageTable;
	
		// Nested types
		private enum DamageFlow
		{
			None = 0,
			P2E = 1,
			E2P = 2,
			P2P = 3,
			E2E = 4
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
			AbsDestroyfire = 15,
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
			// Fields
			[CompilerGenerated]
			private Type _type_k__BackingField;
			[CompilerGenerated]
			private int _value_k__BackingField;
			[CompilerGenerated]
			private bool _isCritical_k__BackingField;
			[CompilerGenerated]
			private bool _isKiller_k__BackingField;
			[CompilerGenerated]
			private float _elementRate_k__BackingField;
			[CompilerGenerated]
			private float _pureElementRate_k__BackingField;
			[CompilerGenerated]
			private string _additionalAttackEffect_k__BackingField;
			[CompilerGenerated]
			private bool _isTolerance_k__BackingField;
			public ShieldInfo[] shieldInfo;
	
			// Properties
			public Type type { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int value { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool isCritical { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool isKiller { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float elementRate { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float pureElementRate { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string additionalAttackEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool isTolerance { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Nested types
			public enum Type
			{
				Normal = 0,
				Slip = 1,
				Extra = 2
			}
	
			public struct ShieldInfo
			{
				// Fields
				public bool isValid;
				public bool isBreak;
	
				// Constructors
				public ShieldInfo(ShieldInfo other);
	
				// Methods
				public void Reset();
			}
	
			// Constructors
			public DamageStatus(Type type_);
			public DamageStatus(DamageStatus other);
	
			// Methods
			public void Reset();
			public void ResetDamage();
			public void SetValue(int value, bool isCritical, bool isKiller, bool isTolerance, float elementRate, float pureElementRate, string additionalAttackEffect = "");
			public void SetValueForShieldReset(int value, bool isCritical, bool isKiller, bool isTolerance, float elementRate, float pureElementRate);
			public bool IsValidDamageShield();
			public bool isValidSacrificeShield();
			public bool isValidDamageShieldWithoutSacrificeShield();
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
			Mul_15 = 15,
			Mul_16 = 16,
			Mul_17 = 17,
			Mul_18 = 18,
			Mul_19 = 19,
			Mul_20 = 20,
			Mul_21 = 21,
			Mul_22 = 22,
			Mul_23 = 23,
			MulEnd = 24,
			AddStart = 25,
			Add_00 = 25,
			Add_01 = 26,
			AddEnd = 27,
			DivStart = 28,
			Div_00 = 28,
			Div_01 = 29,
			Div_02 = 30,
			DivEnd = 31,
			SetStart = 32,
			Set_00 = 32,
			Set_01 = 33,
			Set_02 = 34,
			Set_03 = 35,
			Set_04 = 36,
			Set_05 = 37,
			Set_06 = 38,
			Set_07 = 39,
			Set_08 = 40,
			Set_09 = 41,
			Set_10 = 42,
			Set_11 = 43,
			Set_12 = 44,
			Set_13 = 45,
			SetEnd = 46
		}
	
		// Constructors
		public DamageCalculation();
		static DamageCalculation();
	
		// Methods
		public float AddDamageFactor(CharacterBase chara, float src, float value, FactorType facter);
		public float MulDamageFactor(CharacterBase chara, float src, float value, FactorType facter);
		public float DivDamageFactor(CharacterBase chara, float src, float value, FactorType facter);
		public float SetDamageFactor(CharacterBase chara, float src, float value, FactorType facter);
		public int SetIntDamageFactor(CharacterBase chara, int src, int value, FactorType facter);
		public void Calculation(CollisionHitAttribute attr, CharacterBase dst, int shareDivideNum = 1, int followerAvoid = -1);
		public float CalculationMalaiseDamage(CharacterBase src, float calc);
		public int CalculationAdditionalDamage(CharacterBase character, CollisionHitAttribute data);
		public void CalculationGimmickDamage(CharacterBase dst, CollisionHitAttribute attr, float gimmickAttack);
		private float CalculationDamping(CollisionHitAttribute currAttr, CharacterBase dst);
		private float CalculationDistanceDamping(CollisionHitAttribute currAttr, CharacterBase dst, WeaponTypeElement wte);
		private float CalculationBaseDamage(CollisionHitAttribute attr, CharacterBase dst, DamageStatus status);
		private float Damping(float damage, int step, int skillId, CharacterBase src);
		public float CalculationDefenseParameter(CharacterBase dst, float defCoef);
		public int CalculationDamageShield(CharacterBase dst, int damage, int followerAvoid = -1);
		public int CalculationSacrificeShield(CharacterBase dst, int damage);
		public float DamageRandom();
		public float HealValue(CharacterBase src, CharacterBase dst, int skillId, float power, float coef, ActionStartParameter startParameter);
		private float DrainValue(CharacterBase src, CharacterBase dst, float power, float coef, CharacterBase drainTarget = null);
		private float CalcurationDrain(CollisionHitAttribute attr, CharacterBase dst, float coef);
		public void CalculationHeal(CollisionHitAttribute attr, CharacterBase dst, int shareDivideNum = 1);
		public float CalculationSlip(CharacterBase dst, CollisionHitAttribute attr, float slipPower, bool useRandom);
		public int CalculationSlipAfter(float damage, int slipDamageMax = 0);
		private float GetHitAttributeDependentCoefficient(CharacterBase src, CharacterBase dst, CollisionHitAttribute attr, float power);
		private float GetElementalDamageRate(DamageFlow flow, ElementalType srcElemental, ElementalType dstElemental);
		private float GetCharaElementalDamageRate(CharacterBase src, CharacterBase dst, out float pureElementRate);
		private float GetHitElementalDamageRate(CollisionHitAttribute attr, CharacterBase dst, out float pureElementRate);
		private int GetElementalAdvantage(ElementalType src, ElementalType dst);
		public float CalculationDebuffExtraDamage(CollisionHitAttribute attr, CharacterBase dst);
		private bool IsKillerState(CharacterBase dst, KillerState state);
		private float GetAbnormalKillerDamageRate(CharacterBase src, CharacterBase dst);
		private float GetDebuffKillerDamageRate(CharacterBase src, EnemyCharacter enemy);
		private float GetUniqueKillerDamageRate(CharacterBase src, EnemyCharacter enemy);
		private float GetUniqueKillerResistRate(CharacterBase dst, EnemyCharacter enemy);
		private void EnemyModeDefense(CharacterBase src, CharacterBase dst, ref float defCoef);
		private void EnemyAbilityKillerForMirage(CharacterBase src, CharacterBase dst, ref float defCoef);
		private float ConditionallyBuffRate(CharacterBase src, CharacterBase dst, CharacterBuffType buffType, int actionId);
		private float CriticalUpRateForDebuffEnemy(CharacterBase src, CharacterBase dst, int actionId);
		private float CriticalUpRateForAbnormalStatusEnemy(CharacterBase src, CharacterBase dst, int actionId);
		private float SkillDamageUpRate(CharacterBase src, CollisionHitAttribute attr, AbilityTargetAction targetActionId);
		public EditSkillCharaOffsetElement GetShareSkillCoefData(CharacterBase src, int skillId);
	}
}
