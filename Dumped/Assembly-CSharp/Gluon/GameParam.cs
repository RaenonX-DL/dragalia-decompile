/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class GameParam
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private float _SpAttack;
		[SerializeField]
		private float _SpDamage;
		[SerializeField]
		[Tooltip]
		private int _ConsumeDp;
		[SerializeField]
		[Tooltip]
		private int _DropDpOnEnemyDead;
		[SerializeField]
		[Tooltip]
		private int _DropDpOnBossHpRate;
		[SerializeField]
		[Tooltip]
		private float _ChainTime;
		[SerializeField]
		[Tooltip]
		private float _MoveSpeed;
		[SerializeField]
		private float _DurationTime;
		[SerializeField]
		private float _DashStopTimeMin;
		[SerializeField]
		private float _DashStopTimeMax;
		[SerializeField]
		private float _DashAttackInputTime;
		[SerializeField]
		private float _DashMaxTime;
		[SerializeField]
		[Tooltip]
		private float _DashSpeedRatio;
		[SerializeField]
		[Tooltip]
		private float _DefenseHumanDashSpeedRatio;
		[SerializeField]
		[Tooltip]
		private float _DefenseDragonDashSpeedRatio;
		[SerializeField]
		private float _ChargeStartTime;
		[SerializeField]
		[Tooltip]
		private float _ChargePullThreshold;
		[SerializeField]
		private float _PlayerMass;
		[SerializeField]
		private float _DragonMass;
		[SerializeField]
		[Tooltip]
		private float _MaxDepenetrationVelocity;
		[SerializeField]
		[Tooltip]
		private float _SearchAbsoluteRange;
		[SerializeField]
		[Tooltip]
		private float _SearchRangeCoefEnemy;
		[SerializeField]
		[Tooltip]
		private float _SearchRangeCoefObject;
		[SerializeField]
		[Tooltip]
		private float _SearchRangeCoefSwitch;
		[SerializeField]
		[Tooltip]
		private float _BattleBgOffset;
		[SerializeField]
		[Tooltip]
		private float _CriticalCoef;
		[SerializeField]
		[Tooltip]
		private float _DragonDamageCoef;
		[SerializeField]
		[Tooltip]
		private float _BreakDamageCoef;
		[SerializeField]
		[Tooltip]
		private float _HealCoef;
		[SerializeField]
		[Tooltip]
		private float _RaidHealCoef;
		[SerializeField]
		[Tooltip]
		private float _MaxTensionAttackCoef;
		[SerializeField]
		[Tooltip]
		private float _MaxTensionHealCoef;
		[SerializeField]
		[Tooltip]
		private float _ReduceSecBurn;
		[SerializeField]
		[Tooltip]
		private float _ReleaseFreezeAttackNum;
		[SerializeField]
		[Tooltip]
		private float _ReduceSecSwoon;
		[SerializeField]
		[Tooltip]
		private float _ReduceSecSlowMove;
		[SerializeField]
		[Tooltip]
		private float _BlastSpGravity;
		[SerializeField]
		[Tooltip]
		private float _BlastSpAngle;
		[SerializeField]
		[Tooltip]
		private float _BlastSpHeight;
		[SerializeField]
		[Tooltip]
		private float _BlastSpCoefficient;
		[SerializeField]
		[Tooltip]
		private float _BlastRecoveryHeight;
		[SerializeField]
		[Tooltip]
		private float _BlastRecoveryCoefficient;
		[SerializeField]
		[Tooltip]
		private float _BlastLimitHeight;
		[SerializeField]
		[Tooltip]
		private CameraController.ShakeType _BlastSpShakeType;
		[SerializeField]
		[Tooltip]
		private CameraController.ShakeType _CriticalShakeType;
		[SerializeField]
		[Tooltip]
		private float _FalloutHeight;
		[SerializeField]
		[Tooltip]
		private float _PlayerDownLoopSec;
		[SerializeField]
		[Tooltip]
		private float _PlayerDownLoopSecInBattleQuest;
		[SerializeField]
		[Tooltip]
		private float _PlayerDownLoopSecWhenThrown;
		[SerializeField]
		[Tooltip]
		private float _EnemyDownLoopSec;
		[SerializeField]
		[Tooltip]
		private float _EnemyDownInvincibleSec;
		[SerializeField]
		[Tooltip]
		private float _EnemyDownDamageCoefficient;
		[SerializeField]
		[Tooltip]
		private float _RespawnInvincibleSec;
		[SerializeField]
		[Tooltip]
		private float _RecoveryInvincibleSec;
		[SerializeField]
		[Tooltip]
		private float _RecoverySafetyInvincibleSec;
		[SerializeField]
		[Tooltip]
		private float _BlastRecoveryInvincibleSec;
		[SerializeField]
		[Tooltip]
		private float _RecoveryLimitAngle;
		[SerializeField]
		[Tooltip]
		private float _DragonTransformSec;
		[SerializeField]
		[Tooltip]
		private float _DragonTransformBonusSec;
		[SerializeField]
		[Tooltip]
		private float _DragonTransformRecastSec;
		[SerializeField]
		[Tooltip]
		private float _DragonTransformPauseSec;
		[SerializeField]
		[Tooltip]
		private float _DragonTransformMotionLoopSec;
		[SerializeField]
		[Tooltip]
		private float _ReleaseDragonInvincibleSec;
		[SerializeField]
		[Tooltip]
		private float _DragonHitEffectScale;
		[SerializeField]
		[Tooltip]
		private float _EnemyPopInvincibleSec;
		[SerializeField]
		[Tooltip]
		private float _HitStopDefaultFrameForHumanPlayer;
		[SerializeField]
		[Tooltip]
		private float _HitStopDefaultFrameForDragonPlayer;
		[SerializeField]
		[Tooltip]
		private float _HitStopDefaultFrameForBossEnemy;
		[SerializeField]
		[Tooltip]
		private float _HitStopMotionSpeedScale;
		[SerializeField]
		[Tooltip]
		private float _SkillFadeOutTime;
		[SerializeField]
		[Tooltip]
		private float _SkillFadeInTime;
		[SerializeField]
		[Tooltip]
		private float _SkillFadeInStartTime;
		[SerializeField]
		[Tooltip]
		private float _SupportSkillRecastSec;
		[SerializeField]
		[Tooltip]
		private float _UniqueTransformRecastSec;
		[SerializeField]
		[Tooltip]
		private float _OthersSEVolumeRatio;
		[SerializeField]
		[Tooltip]
		private float _FontEffectScale;
		[SerializeField]
		[Tooltip]
		private int _RecoveryValueOnHitCount;
		[SerializeField]
		[Tooltip]
		private int _MaxRecoveryValueOnHitCount;
		[SerializeField]
		[Tooltip]
		private float[] _SwipeLength;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _ChargeMarkerEdgeSize;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _ChargeMarkerEdgePower;
		[SerializeField]
		[Tooltip]
		private float _MaxCarrySec;
		[SerializeField]
		[Tooltip]
		private float _PortalRegeneRate;
		[SerializeField]
		[Tooltip]
		private float _PortalRegeneInterval;
		[SerializeField]
		[Tooltip]
		private float _HpRecoveryFormulaCoef;
		[SerializeField]
		[Tooltip]
		private float _FollowerDisableAvoidSec;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _DamageCutRateForHpShareDragon;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _DamageCutRateForServantMode;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _DamageCutRateForFollower;
		[SerializeField]
		[Tooltip]
		private float _DamageAdjustCoef;
		[SerializeField]
		[Tooltip]
		private float _HpRecoveryAdjustCoef;
		[SerializeField]
		[Tooltip]
		private float _HpRecoveryAdjustCoefDependsOnHp;
		[SerializeField]
		[Tooltip]
		private float _HpRecoveryAdjustCoefDependsOnAttack;
		[SerializeField]
		[Tooltip]
		private float _HpDrainBuffLimitRate;
		[SerializeField]
		[Tooltip]
		private string _HpDrainHitAttribute;
		[SerializeField]
		[Tooltip]
		private int _SuperArmorLvForParameterDisparity;
		[SerializeField]
		[Tooltip]
		private float _FreeFallSpeed;
		[SerializeField]
		[Tooltip]
		private float[] _DebuffSlipPower;
		[SerializeField]
		[Tooltip]
		private int _ActiveGaugeMaxValue;
		[SerializeField]
		[Tooltip]
		private float _ActiveGaugeDiffMoveTime;
		[SerializeField]
		[Tooltip]
		private float _ActiveGaugeResetGaugeAnimDelayTime;
		[SerializeField]
		[Tooltip]
		private bool _ActiveGaugeResetGaugeAnimFlag;
		[SerializeField]
		[Tooltip]
		private int _EnemyRouteModeSearchIntervalMin;
		[SerializeField]
		[Tooltip]
		private int _EnemyRouteModeSearchIntervalMax;
		[SerializeField]
		[Tooltip]
		private float _MultiPlayRetryVoteWaitTime;
		[SerializeField]
		[Tooltip]
		private float _MultiPlayRetryDeniedRemainTime;
		[SerializeField]
		[Tooltip]
		private float _InvincibleSecAfterAlloutAssault;
		[SerializeField]
		[Tooltip]
		private float _OverdriveCounterLimitSolo;
		[SerializeField]
		[Tooltip]
		private float _OverdriveCounterLimitMulti;
		[SerializeField]
		[Tooltip]
		private float _MoveSpeedRateBMin;
		[SerializeField]
		[Space]
		[Tooltip]
		private float _BuffHPMax;
		[SerializeField]
		[Tooltip]
		private float _BuffHPMin;
		[SerializeField]
		[Tooltip]
		private float _BuffAttackMax;
		[SerializeField]
		[Tooltip]
		private float _BuffAttackMin;
		[SerializeField]
		[Tooltip]
		private float _BuffDefenseMax;
		[SerializeField]
		[Tooltip]
		private float _BuffDefenseMin;
		[SerializeField]
		[Tooltip]
		private float _BuffDefenseBMax;
		[SerializeField]
		[Tooltip]
		private float _BuffDefenseBMin;
		[SerializeField]
		[Tooltip]
		private float _BuffCriticalMax;
		[SerializeField]
		[Tooltip]
		private float _BuffCriticalMin;
		[SerializeField]
		[Tooltip]
		private float _BuffSkillPowerMax;
		[SerializeField]
		[Tooltip]
		private float _BuffSkillPowerMin;
		[SerializeField]
		[Tooltip]
		private float _BuffBurstPowerMax;
		[SerializeField]
		[Tooltip]
		private float _BuffBurstPowerMin;
		[SerializeField]
		[Tooltip]
		private float _BuffRecoveryMax;
		[SerializeField]
		[Tooltip]
		private float _BuffRecoveryMin;
		[SerializeField]
		[Tooltip]
		private float _BuffRecoverySpMax;
		[SerializeField]
		[Tooltip]
		private float _BuffRecoverySpMin;
		[SerializeField]
		[Tooltip]
		private float _BuffAttackSpeedMax;
		[SerializeField]
		[Tooltip]
		private float _BuffAttackSpeedMin;
		[SerializeField]
		[Tooltip]
		private float _BuffDamageCutMax;
		[SerializeField]
		[Tooltip]
		private float _BuffDamageCutBMax;
		[SerializeField]
		[Tooltip]
		private float _BuffNickedMin;
		[SerializeField]
		[Tooltip]
		private float _BuffChargeSpeedMax;
		[SerializeField]
		[Tooltip]
		private float _BuffChargeSpeedMin;
		[SerializeField]
		[Tooltip]
		private float _BuffGetHpRecoveryMax;
		[SerializeField]
		[Tooltip]
		private float _BuffGetHpRecoveryMin;
		[SerializeField]
		[Space]
		[Tooltip]
		private float _AbilityDragonTimeForPartyMaxValue;
		[SerializeField]
		[Tooltip]
		private float _EnemyAbiityAttackRangeToleranceMin;
	
		// Properties
		public int Id { get; }
		public float SpAttack { get; }
		public float SpDamage { get; }
		public int ConsumeDp { get; }
		public int DropDpOnEnemyDead { get; }
		public int DropDpOnBossHpRate { get; }
		public float ChainTime { get; }
		public float MoveSpeed { get; }
		public float DurationTime { get; }
		public float DashStopTimeMin { get; }
		public float DashStopTimeMax { get; }
		public float DashAttackInputTime { get; }
		public float DashMaxTime { get; }
		public float DashSpeedRatio { get; }
		public float DefenseHumanDashSpeedRatio { get; }
		public float DefenseDragonDashSpeedRatio { get; }
		public float ChargeStartTime { get; }
		public float ChargePullThreshold { get; }
		public float PlayerMass { get; }
		public float DragonMass { get; }
		public float MaxDepenetrationVelocity { get; }
		public float SearchAbsoluteRange { get; }
		public float SearchRangeCoefEnemy { get; }
		public float SearchRangeCoefObject { get; }
		public float SearchRangeCoefSwitch { get; }
		public float BattleBgOffset { get; }
		public float CriticalCoef { get; }
		public float DragonDamageCoef { get; }
		public float BreakDamageCoef { get; }
		public float HealCoef { get; }
		public float RaidHealCoef { get; }
		public float MaxTensionAttackCoef { get; }
		public float MaxTensionHealCoef { get; }
		public float ReduceSecBurn { get; }
		public float ReleaseFreezeAttackNum { get; }
		public float ReduceSecSwoon { get; }
		public float ReduceSecSlowMove { get; }
		public float BlastSpGravity { get; }
		public float BlastSpAngle { get; }
		public float BlastSpHeight { get; }
		public float BlastSpCoefficient { get; }
		public float BlastRecoveryHeight { get; }
		public float BlastRecoveryCoefficient { get; }
		public float BlastLimitHeight { get; }
		public CameraController.ShakeType BlastSpShakeType { get; }
		public float FalloutHeight { get; }
		public float PlayerDownLoopSec { get; }
		public float PlayerDownLoopSecInBattleQuest { get; }
		public float PlayerDownLoopSecWhenThrown { get; }
		public float EnemyDownLoopSec { get; }
		public float EnemyDownInvincibleSec { get; }
		public float EnemyDownDamageCoefficient { get; }
		public float RespawnInvincibleSec { get; }
		public float RecoveryInvincibleSec { get; }
		public float RecoverySafetyInvincibleSec { get; }
		public float BlastRecoveryInvincibleSec { get; }
		public float RecoveryLimitAngle { get; }
		public float DragonTransformSec { get; }
		public float DragonTransformBonusSec { get; }
		public float DragonTransformRecastSec { get; }
		public float DragonTransformPauseSec { get; }
		public float DragonTransformMotionLoopSec { get; }
		public float ReleaseDragonInvincibleSec { get; }
		public float DragonHitEffectScale { get; }
		public float EnemyPopInvincibleSec { get; }
		public float HitStopDefaultFrameForHumanPlayer { get; }
		public float HitStopDefaultFrameForDragonPlayer { get; }
		public float HitStopDefaultFrameForBossEnemy { get; }
		public float HitStopMotionSpeedScale { get; }
		public float SkillFadeOutTime { get; }
		public float SkillFadeInTime { get; }
		public float SkillFadeInStartTime { get; }
		public float SupportSkillRecastSec { get; }
		public float UniqueTransformRecastSec { get; }
		public float OthersSEVolumeRatio { get; }
		public float FontEffectScale { get; }
		public int RecoveryValueOnHitCount { get; }
		public int MaxRecoveryValueOnHitCount { get; }
		public float ChargeMarkerEdgeSize { get; }
		public float ChargeMarkerEdgePower { get; }
		public float MaxCarrySec { get; }
		public float PortalRegeneRate { get; }
		public float PortalRegeneInterval { get; }
		public float HpRecoveryFormulaCoef { get; }
		public float FollowerDisableAvoidSec { get; }
		public float DamageCutRateForHpShareDragon { get; }
		public float DamageCutRateForServantMode { get; }
		public float DamageCutRateForFollower { get; }
		public float DamageAdjustCoef { get; }
		public float HpRecoveryAdjustCoef { get; }
		public float HpRecoveryAdjustCoefDependsOnHp { get; }
		public float HpRecoveryAdjustCoefDependsOnAttack { get; }
		public float HpDrainBuffLimitRate { get; }
		public string HpDrainHitAttribute { get; }
		public int SuperArmorLvForParameterDisparity { get; }
		public float FreeFallSpeed { get; }
		public float[] DebuffSlipPower { get; }
		public int ActiveGaugeMaxValue { get; }
		public float ActiveGaugeDiffMoveTime { get; }
		public float ActiveGaugeResetGaugeAnimDelayTime { get; }
		public bool ActiveGaugeResetGaugeAnimFlag { get; }
		public int EnemyRouteModeSearchIntervalMin { get; }
		public int EnemyRouteModeSearchIntervalMax { get; }
		public float MultiPlayRetryVoteWaitTime { get; }
		public float MultiPlayRetryDeniedRemainTime { get; }
		public float InvincibleSecAfterAlloutAssault { get; }
		public float OverdriveCounterLimitSolo { get; }
		public float OverdriveCounterLimitMulti { get; }
		public float MoveSpeedRateBMin { get; }
		public float BuffHPMax { get; }
		public float BuffHPMin { get; }
		public float BuffAttackMax { get; }
		public float BuffAttackMin { get; }
		public float BuffDefenseMax { get; }
		public float BuffDefenseMin { get; }
		public float BuffDefenseBMax { get; }
		public float BuffDefenseBMin { get; }
		public float BuffCriticalMax { get; }
		public float BuffCriticalMin { get; }
		public float BuffSkillPowerMax { get; }
		public float BuffSkillPowerMin { get; }
		public float BuffBurstPowerMax { get; }
		public float BuffBurstPowerMin { get; }
		public float BuffRecoveryMax { get; }
		public float BuffRecoveryMin { get; }
		public float BuffRecoverySpMax { get; }
		public float BuffRecoverySpMin { get; }
		public float BuffAttackSpeedMax { get; }
		public float BuffAttackSpeedMin { get; }
		public float BuffDamageCutMax { get; }
		public float BuffDamageCutBMax { get; }
		public float BuffNickedMin { get; }
		public float BuffChargeSpeedMax { get; }
		public float BuffChargeSpeedMin { get; }
		public float BuffGetHpRecoveryMax { get; }
		public float BuffGetHpRecoveryMin { get; }
		public float AbilityDragonTimeForPartyMaxValue { get; }
		public float EnemyAbiityAttackRangeToleranceMin { get; }
	
		// Constructors
		public GameParam();
	
		// Methods
		public float SwipeLength(int idx);
	}
}
