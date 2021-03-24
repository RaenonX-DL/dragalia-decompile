/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class AbilityConst
	{
		// Fields
		public const int humanSlotMax = 3;
		public const int dragonSlotMax = 2;
		public const int amuletSlotMax = 2;
		public const int weaponSlotMax = 2;
		public const int exAbility2SlotMax = 4;
		public const int eventAbilitySlotMax = 2;
		public const int capacityMax = 3;
		public const int shiftLvMax = 8;
		public static readonly bool[] NeedApplyConditionallyToOtherPlayers;
	
		// Nested types
		public enum Type
		{
			None = 0,
			StatusUp = 1,
			ResistAbs = 2,
			ActAddAbs = 3,
			ResistTribe = 4,
			ActKillerTribe = 5,
			ActDamageUp = 6,
			ActCriticalUp = 7,
			ActRecoveryUp = 8,
			ActBreakUp = 9,
			ResistTrap = 10,
			AddRecoverySp = 11,
			AddRecoveryDp = 12,
			RecoveryHpOnHitCount = 13,
			ChangeState = 14,
			ResistInstantDeath = 15,
			DebuffGrantUp = 16,
			SpCharge = 17,
			BuffExtension = 18,
			DebuffExtension = 19,
			AbnormalKiller = 20,
			UserExpUp = 21,
			CharaExpUp = 22,
			CoinUp = 23,
			ManaUp = 24,
			ActionGrant = 25,
			CriticalDamageUp = 26,
			DpCharge = 27,
			ResistElement = 28,
			ResistUnique = 29,
			UniqueKiller = 30,
			Dummy01 = 31,
			Dummy02 = 32,
			Dummy03 = 33,
			Dummy04 = 34,
			ModeGaugeSuppression = 35,
			DragonDamageUp = 36,
			EnemyAbilityKiller = 37,
			HitAttribute = 38,
			PassiveGrant = 39,
			ActiveGaugeStatusUp = 40,
			Dummy05 = 41,
			HitAttributeShift = 42,
			ReferenceOther = 43,
			EnhancedSkill = 44,
			EnhancedBurstAttack = 45,
			DragonTimeForParty = 46,
			AbnoramlExtension = 47,
			DragonTimeSpeedRate = 48,
			DpChargeMyParty = 49,
			DontAct = 50,
			RandomBuff = 51,
			CriticalUpDependsOnBuffTypeCount = 52,
			InvalidDragonAbility = 53,
			ActDamageUpDependsOnHitCount = 54,
			ChainTimeExtension = 55,
			UniqueTransform = 56,
			EnhancedElementDamage = 57,
			UtpCharge = 58,
			DebuffTimeExtensionForSpecificDebuffs = 59,
			RemoveAllStockBullets = 60,
			ChangeMode = 61,
			RandomBuffNoTDuplicate_Param1Times = 62,
			ModifyBuffDebuffDurationTime = 63,
			CpCoef = 64,
			UniqueAvoid = 65,
			RebornHpRateUp = 66,
			AttackBaseOnHPUpRate = 67,
			ChangeStateHostile = 68,
			CpContinuationDown = 69,
			AddCpRate = 70,
			RunOptionAction = 71,
			SecondElements = 72,
			KickAuraEffectTritter = 73,
			ConsumeSpToRecoverHp = 74,
			CrestGroupScoreUp = 75,
			ModifyBuffDebuffDurationTimeByRecoveryHp = 76,
			CrisisRate = 77,
			ActDamageDown = 78,
			AutoAvoidProbability = 79,
			LimitCriticalAddRate = 80
		}
	
		public enum TargetParam
		{
			None = 0,
			Hp = 1,
			Atk = 2,
			Def = 3,
			Spr = 4,
			Dpr = 5,
			Dummy1 = 6,
			ChargeTime = 7,
			DragonTime = 8,
			DamageCut = 9,
			AttackSpeed = 10,
			BurstSpeed = 11,
			ChargeSpeed = 12,
			ConsumeDpRate = 13,
			FinalDragonTimeRate = 14,
			Utpr = 15,
			DamageCutB = 16
		}
	
		public enum BuffType
		{
			None = 0,
			Hp = 1,
			Attack = 2,
			Defense = 3,
			Critical = 4,
			SkillPower = 5,
			BurstPower = 6,
			Recovery = 7,
			AttackSpeed = 8,
			All = 99
		}
	
		public enum UnitType
		{
			None = 0,
			Chara = 1,
			Dragon = 2,
			Amulet = 3,
			Weapon = 4,
			Skill = 5,
			ExAbility2 = 6,
			EventAbility = 7,
			UnionBonus = 8
		}
	
		public enum ExpireType
		{
			None = 0,
			DamagedAbs = 1
		}
	
		public enum HitAttributeShiftCondition
		{
			None = 0,
			DragonTransformCount = 1
		}
	
		public enum SkillOwner
		{
			Human = 1,
			Dragon = 2,
			Weapon = 4
		}
	
		// Constructors
		static AbilityConst();
	}
}
