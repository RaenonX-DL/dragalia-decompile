using System;

namespace Gluon
{
	public static class InGameDef
	{
		[Serializable]
		public enum AttackRange
		{
			NONE,
			IN_RANGE,
			MIDDLE_RANGE,
			OUT_RANGE
		}

		[Serializable]
		public enum CharacterType
		{
			Player,
			Enemy,
			Common
		}

		public enum Direction
		{
			Front,
			Back,
			All
		}

		public enum ChargeType
		{
			Pull,
			Move,
			Stable,
			Target,
			MoveAndTarget
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
			None,
			SetHpRate,
			ConsumeHpRate,
			Debuff,
			FixedDamage
		}

		public enum ActionFlag
		{
			None = 0,
			Combo = 1,
			DashAttack = 2,
			BurstAttack = 4,
			Avoid = 8,
			HumanSkill1 = 0x10,
			HumanSkill2 = 0x20,
			HumanSkill3 = 0x40,
			HumanSkill4 = 0x80,
			DragonSkill1 = 0x100,
			DragonSkill2 = 0x200,
			DragonShift = 0x400,
			EnhanceShift = 0x800
		}

		public enum SwitchPartyNoList
		{
			PartyNo1 = 1,
			PartyNo2
		}

		public static class Input
		{
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
			public const string GMK_BOMB = "GMK_BOMB";

			public const string CMN_FALL = "CMN_FALL";

			public const string CMN_AVOID = "CMN_AVOID";
		}

		public static class UnitActionConstant
		{
			public const int Paralysis = 21;

			public const int AvoidCommon = 6;

			public const int AvoidKAT = 7;

			public const int AvoidGUN = 40;
		}

		public static class SkillSlot
		{
			public const int skill1 = 0;

			public const int skill2 = 1;

			public const int skill3 = 2;

			public const int weaponSkill = 2;

			public const int skill4 = 3;

			public const int dragonFA = 65;
		}

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
	}
}
