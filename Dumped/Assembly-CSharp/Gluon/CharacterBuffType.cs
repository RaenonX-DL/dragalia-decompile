﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public enum CharacterBuffType
	{
		UnifiedDebuff = -3,
		Dispel = -2,
		None = -1,
		HP = 0,
		Attack = 1,
		Defense = 2,
		Critical = 3,
		SkillPower = 4,
		BurstPower = 5,
		Recovery = 6,
		AttackSpeed = 7,
		ResistPoison = 8,
		ResistBurn = 9,
		ResistFreeze = 10,
		ResistParalysis = 11,
		ResistDarkness = 12,
		ResistSwoon = 13,
		ResistCurse = 14,
		ResistSlowMove = 15,
		ResistSleep = 16,
		ResistFrostbite = 17,
		ResistMagicCreature = 18,
		ResistNatural = 19,
		ResistDemiHuman = 20,
		ResistBeast = 21,
		ResistUndead = 22,
		ResistDeamon = 23,
		ResistHuman = 24,
		ResistDragon = 25,
		DamageCut = 26,
		DamageCut2 = 27,
		WeakInvalid = 28,
		RegeneHp = 29,
		RegeneSp = 30,
		RegeneDp = 31,
		Reraise = 32,
		Armored = 33,
		DamageShield = 34,
		TransSkill = 35,
		GrantSkill = 36,
		DamageCutFire = 37,
		DamageCutWater = 38,
		DamageCutWind = 39,
		DamageCutLight = 40,
		DamageCutDark = 41,
		EnhancedFire = 42,
		EnhancedWater = 43,
		EnhancedWind = 44,
		EnhancedLight = 45,
		EnhancedDark = 46,
		EnhancedBurstAttack = 47,
		EnhancedSkill1 = 48,
		EnhancedSkill2 = 49,
		EnhancedSkillWeapon = 50,
		EnhancedCritical = 51,
		Tension = 52,
		SlipHp = 53,
		AutoRegeneS2 = 54,
		Nicked = 55,
		Malaise = 56,
		Sparking = 57,
		HpDrain = 58,
		RecoverySp = 59,
		DefenseB = 60,
		DamageShield2 = 61,
		HealInvalid = 62,
		SelfDamage = 63,
		HpConsumption = 64,
		AutoRegeneS1 = 65,
		AutoRegeneSW = 66,
		DamageShield3 = 67,
		DisableAction = 68,
		RemoveTrigger = 69,
		ChargeSpeed = 70,
		DamageLink = 71,
		ComboShift = 72,
		Inspiration = 73,
		GoldenBarrier = 74,
		DisableMove = 75,
		Invincible = 76,
		SacrificeShield = 77,
		MoveSpeedRate = 78,
		PoisonKiller = 79,
		BurnKiller = 80,
		FreezeKiller = 81,
		ParalysisKiller = 82,
		DarknessKiller = 83,
		SwoonKiller = 84,
		CurseKiller = 85,
		RebirthKiller = 86,
		SlowMoveKiller = 87,
		SleepKiller = 88,
		FrostbiteKiller = 89,
		EnhancedSky = 90,
		ModeChangeStack = 91,
		TensionUpInvalid = 92,
		TargetSkillSpUpRateDebuff = 93,
		IneffectiveBuff_01_Chess = 94,
		IneffectiveBuff_02_EnhancedSkillRevelation1 = 95,
		IneffectiveBuff_03_EnhancedSkillRevelation2 = 96,
		IneffectiveBuff_04_AbilityChangeBuff = 97,
		IneffectiveBuff_05_Apostle = 98,
		IneffectiveBuff_06_FestivalMask = 99,
		IneffectiveBuff_07_NevOption = 100,
		IneffectiveBuff_08_WhaleSkillEnhance = 101,
		IneffectiveBuff_09_Shikigami = 102,
		IneffectiveBuff_10_CommonForDisplayOnly = 103,
		IneffectiveBuff_11_CommonForUnitPartsCondition = 104,
		IneffectiveBuff_12_CommonForDragonPartsCondition = 105,
		IneffectiveBuff_11_CommonForUnitPartsCondition_2 = 106,
		IneffectiveBuff_12_CommonForDragonPartsCondition_2 = 107,
		IneffectiveBuff_End = 194,
		AdditionAttackBuff = 195,
		OverCharge = 196,
		DebuffGrantRate = 197,
		Cartridge = 198,
		ResistFlashheat = 199,
		FlashheatKiller = 200,
		DisableActionFlags = 201,
		BurstSpeed = 202,
		ResistCrashWind = 203,
		CrashwindKiller = 204,
		Hiding = 205,
		ResistDarkabs = 206,
		DarkabsKiller = 207,
		EnhancedFire2 = 208,
		EnhancedWater2 = 209,
		EnhancedWind2 = 210,
		EnhancedLight2 = 211,
		EnhancedDark2 = 212,
		Stack = 213,
		ResistDestroyfire = 214,
		DestroyfireKiller = 215,
		RecoveryDp = 216,
		RecoveryUtp = 217,
		DamageCutB = 218,
		CurseOfEmptiness = 219,
		AutoAvoid = 220,
		GetHpRecoveryRate = 221,
		EnhancedNoElement = 222,
		LockedOn = 223,
		IronWall = 224,
		ResistAllAbnormal = 225,
		BlueScale = 226,
		PoisonAdd = 227,
		BurnAdd = 228,
		FreezeAdd = 229,
		ParalysisAdd = 230,
		DarknessAdd = 231,
		SwoonAdd = 232,
		CurseAdd = 233,
		RebirthAdd = 234,
		SlowMoveAdd = 235,
		SleepAdd = 236,
		FrostbiteAdd = 237,
		FlashheatAdd = 238,
		CrashwindAdd = 239,
		DarkabsAdd = 240,
		DestroyfireAdd = 241,
		MoveSpeedRateB = 242,
		EnhancedDisadvantagedElement = 243,
		Dissonance = 244,
		SubstitudeDamage = 245,
		HLExclusive = 246,
		Phoenix = 247,
		Pursuit = 248
	}
}
