/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class InGameDef
	{
		// Fields
		public const string TAG_DUNGEONOBJECT_DISPPEAR = "tag_dungeonObject_disppear";
		public const string TAG_DUNGEONOBJECT = "tag_dungeonObject";
		public const int DEFAULT_WIDTH = 640;
		public const float ANIMATION_FPS = 30f;
		public const float SendRegularEventInterval = 0.3f;
		public const float SendMoveEventMaxIdleTime = 1f;
		public const float ArrowChargeMarkerScale = 4f;
		public const float CharacterMassMax = 300000f;
		public const int EnergyGaugeMax = 2;
		public const int DamageShieldTypeMax = 4;
		public const int ChargeLvMax = 5;
		public const int GuardCounterReactionNum = 4;
		public const int GuardReactionInChargeNum = 4;
		public const int CharaModeMax = 4;
		public const int INVALID_PARTY_ID = -1;
		public const int RecoverySpIndexForUseSkill = 10;
		public const float KeepBurstAngleToTarget = 10f;
		public static readonly string CharaAppearEffectName;
	
		// Nested types
		[Serializable]
		public enum AttackRange
		{
			NONE = 0,
			IN_RANGE = 1,
			MIDDLE_RANGE = 2,
			OUT_RANGE = 3
		}
	
		[Serializable]
		public enum CharacterType
		{
			Player = 0,
			Enemy = 1,
			Common = 2
		}
	
		public enum Direction
		{
			Front = 0,
			Back = 1,
			All = 2
		}
	
		public enum ChargeType
		{
			Pull = 0,
			Move = 1,
			Stable = 2,
			Target = 3,
			MoveAndTarget = 4
		}
	
		public enum BurstActionOffset
		{
			Attack = 0,
			Start = 1,
			Loop = 2,
			Cancel = 3,
			Marker = 4,
			Dummy01 = 5,
			Guard = 6,
			ChargeLv2 = 100,
			ChargeLv3 = 200,
			ChargeLv4 = 300,
			ChargeLv5 = 400
		}
	
		public enum DamageMyselfType
		{
			None = 0,
			SetHpRate = 1,
			ConsumeHpRate = 2,
			Debuff = 3
		}
	
		public enum ActionFlag
		{
			None = 0,
			Combo = 1,
			DashAttack = 2,
			BurstAttack = 4,
			Avoid = 8,
			HumanSkill1 = 16,
			HumanSkill2 = 32,
			HumanSkill3 = 64,
			HumanSkill4 = 128,
			DragonSkill1 = 256,
			DragonSkill2 = 512,
			DragonShift = 1024,
			EnhanceShift = 2048
		}
	
		public enum SwitchPartyNoList
		{
			PartyNo1 = 1,
			PartyNo2 = 2
		}
	
		public static class Input
		{
			// Fields
			public const string Horizontal = "Horizontal";
			public const string Vertical = "Vertical";
			public const string HorizontalSwipe = "HorizontalSwipe";
			public const string VerticalSwipe = "VerticalSwipe";
			public const string HorizontalCharge = "HorizontalCharge";
			public const string VerticalCharge = "VerticalCharge";
			public const string Fire = "Fire";
			public const string ZoomPinch = "ZoomPinch";
			public const float Margin = 0.1f;
		}
	
		public static class KeyName
		{
			// Fields
			public const string dash = "dash";
			public const string charge = "charge";
			public const string charged = "charged";
			public const string chargeL = "chargeL";
			public const string chargeR = "chargeR";
			public const string chargeSpeed = "chargeSpeed_";
			public const string guard = "guard";
			public const string rage = "rage";
			public const string buff = "buff";
			public const string debuff = "debuff";
			public const string shield = "shield";
			public const string blastSp = "blastSp";
			public const string chargeBullet = "chargeBullet";
			public const string chargeAction = "chargeAction";
			public const string abnormalStatus = "abnormalStatus";
			public const string suppression = "suppression";
			public const string powerUpCombo = "aura_1";
			public const string stronger = "stronger";
			public const string sparking = "sparking";
			public const string modeChange = "modeChange";
			public const string barrier = "barrier";
			public const string aura = "aura_";
			public const string weakpoint = "weakpoint";
			public const string actionChangedByAdditionalInput = "actionchangedbyadditionalinput";
			public const string footprints = "footprints";
			public const string eightServantAura = "eightServantAura";
		}
	
		public static class ActionHitAttributeConstant
		{
			// Fields
			public const string GMK_BOMB = "GMK_BOMB";
			public const string CMN_FALL = "CMN_FALL";
			public const string CMN_AVOID = "CMN_AVOID";
		}
	
		public static class UnitActionConstant
		{
			// Fields
			public const int Paralysis = 21;
			public const int AvoidCommon = 6;
			public const int AvoidKAT = 7;
			public const int AvoidGUN = 40;
		}
	
		public static class SkillSlot
		{
			// Fields
			public const int skill1 = 0;
			public const int skill2 = 1;
			public const int skill3 = 2;
			public const int weaponSkill = 2;
			public const int skill4 = 3;
			public const int dragonFA = 65;
		}
	
		// Constructors
		static InGameDef();
	}
}
