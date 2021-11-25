using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class GameParam
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private float _SpAttack;

		[SerializeField]
		private float _SpDamage;

		[SerializeField]
		[Tooltip("1å\u009b\u009eã\u0081®ç«\u009cå\u008c\u0096ã\u0081§æ¶\u0088è²»ã\u0081\u0099ã\u0082\u008bDP")]
		private int _ConsumeDp;

		[SerializeField]
		[Tooltip("DPã\u0083\u0089ã\u0083­ã\u0083\u0083ã\u0083\u0097(ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼æ\u0099\u0082)")]
		private int _DropDpOnEnemyDead;

		[SerializeField]
		[Tooltip("DPã\u0083\u0089ã\u0083­ã\u0083\u0083ã\u0083\u0097(ã\u0083\u009cã\u0082¹HPå\u0089²å\u0090\u0088)")]
		private int _DropDpOnBossHpRate;

		[SerializeField]
		[Tooltip("é\u0080£ç¶\u009aã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ç¶\u0099ç¶\u009aç§\u0092æ\u0095°")]
		private float _ChainTime;

		[SerializeField]
		[Tooltip("é\u0080\u009aå\u00b8\u00b8ç§»å\u008b\u0095é\u0080\u009fåº¦")]
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
		[Tooltip("ã\u0083\u0080ã\u0083\u0083ã\u0082·ã\u0083¥ç§»å\u008b\u0095é\u0080\u009fåº¦å\u0080\u008dç\u008e\u0087(é\u0080\u009aå\u00b8\u00b8ç§»å\u008b\u0095é\u0080\u009fåº¦ã\u0081«ã\u0081\u008bã\u0081\u0091ã\u0082\u008bä¿\u0082æ\u0095°)")]
		private float _DashSpeedRatio;

		[SerializeField]
		[Tooltip("äººå\u009e\u008bã\u0082­ã\u0083£ã\u0083©ã\u0081®é\u0098²è¡\u009bæ\u0088¦ã\u0081®ã\u0083\u0080ã\u0083\u0083ã\u0082·ã\u0083¥ç§»å\u008b\u0095é\u0080\u009fåº¦å\u0080\u008dç\u008e\u0087(DashSpeedRatioã\u0081\u00a8é\u0087\u008dè¤\u0087ã\u0081\u0099ã\u0082\u008b)")]
		private float _DefenseHumanDashSpeedRatio;

		[SerializeField]
		[Tooltip("ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0081®é\u0098²è¡\u009bæ\u0088¦ã\u0081®ã\u0083\u0080ã\u0083\u0083ã\u0082·ã\u0083¥ç§»å\u008b\u0095é\u0080\u009fåº¦å\u0080\u008dç\u008e\u0087(DashSpeedRatioã\u0081\u00a8é\u0087\u008dè¤\u0087ã\u0081\u0099ã\u0082\u008b)")]
		private float _DefenseDragonDashSpeedRatio;

		[SerializeField]
		private float _ChargeStartTime;

		[SerializeField]
		[Tooltip("ã\u0083\u0081ã\u0083£ã\u0083¼ã\u0082\u00b8ã\u0081²ã\u0081£ã\u0081±ã\u0082\u008aã\u0082¢ã\u0082½ã\u0083\u0093å¹\u0085")]
		private float _ChargePullThreshold;

		[SerializeField]
		private float _PlayerMass;

		[SerializeField]
		private float _DragonMass;

		[SerializeField]
		[Tooltip("è²«é\u0080\u009aç\u008a¶æ\u0085\u008bã\u0081\u008bã\u0082\u0089å\u0087ºã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083ªã\u0082\u00b8ã\u0083\u0083ã\u0083\u0089ã\u0083\u009cã\u0083\u0087ã\u0082£ã\u0081®æ\u009c\u0080å¤§é\u0080\u009fåº¦")]
		private float _MaxDepenetrationVelocity;

		[SerializeField]
		[Tooltip("å¿\u0085ã\u0081\u009aç\u00b4¢æ\u0095µã\u0081«å¼\u0095ã\u0081£ã\u0081\u008bã\u0081\u008bã\u0082\u008bç\u00af\u0084å\u009b²[m]")]
		private float _SearchAbsoluteRange;

		[SerializeField]
		[Tooltip("ç\u00b4¢æ\u0095µç\u00af\u0084å\u009b²ä¿\u0082æ\u0095°(ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼)")]
		private float _SearchRangeCoefEnemy;

		[SerializeField]
		[Tooltip("ç\u00b4¢æ\u0095µç\u00af\u0084å\u009b²ä¿\u0082æ\u0095°(ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088)")]
		private float _SearchRangeCoefObject;

		[SerializeField]
		[Tooltip("ç\u00b4¢æ\u0095µç\u00af\u0084å\u009b²ä¿\u0082æ\u0095°(ã\u0082¹ã\u0082¤ã\u0083\u0083ã\u0083\u0081)")]
		private float _SearchRangeCoefSwitch;

		[SerializeField]
		[Tooltip("çµ\u0082äº\u0086æ¼\u0094å\u0087ºæ\u0099\u0082ã\u0081®å\u00af¾æ\u0088¦ã\u0083\u009eã\u0083\u0083ã\u0083\u0097é«\u0098ã\u0081\u0095ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		private float _BattleBgOffset;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0083ªã\u0083\u0086ã\u0082£ã\u0082«ã\u0083«ä¿\u0082æ\u0095°")]
		private float _CriticalCoef;

		[SerializeField]
		[Tooltip("ç«\u009cå\u008c\u0096ä¿\u0082æ\u0095°")]
		private float _DragonDamageCoef;

		[SerializeField]
		[Tooltip("ã\u0083\u0096ã\u0083¬ã\u0082¤ã\u0082\u00afã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0083\u009cã\u0083¼ã\u0083\u008aã\u0082¹")]
		private float _BreakDamageCoef;

		[SerializeField]
		[Tooltip("å\u0090\u008cå±\u009eæ\u0080§æ\u0099\u0082ã\u0081®å\u009b\u009eå¾©é\u0087\u008fä¿\u0082æ\u0095°")]
		private float _HealCoef;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0082¤ã\u0083\u0089æ\u0099\u0082ã\u0081®å\u009b\u009eå¾©é\u0087\u008fä¿\u0082æ\u0095°")]
		private float _RaidHealCoef;

		[SerializeField]
		[Tooltip("ã\u0083\u0086ã\u0083³ã\u0082·ã\u0083§ã\u0083³æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®æ\u0094»æ\u0092\u0083ä¿\u0082æ\u0095°")]
		private float _MaxTensionAttackCoef;

		[SerializeField]
		[Tooltip("ã\u0083\u0086ã\u0083³ã\u0082·ã\u0083§ã\u0083³æ\u009c\u0080å¤§æ\u0099\u0082ã\u0081®å\u009b\u009eå¾©é\u0087\u008fä¿\u0082æ\u0095°")]
		private float _MaxTensionHealCoef;

		[SerializeField]
		[Tooltip("ç\u0081«å\u0082·è»½æ\u00b8\u009bç§\u0092æ\u0095°")]
		private float _ReduceSecBurn;

		[SerializeField]
		[Tooltip("å\u0087\u008dçµ\u0090è§£é\u0099¤ã\u0081«å¿\u0085è¦\u0081ã\u0081ªæ\u0094»æ\u0092\u0083å\u009b\u009eæ\u0095°")]
		private float _ReleaseFreezeAttackNum;

		[SerializeField]
		[Tooltip("æ°\u0097çµ¶è»½æ\u00b8\u009bç§\u0092æ\u0095°")]
		private float _ReduceSecSwoon;

		[SerializeField]
		[Tooltip("é\u0088\u008dè¶³è»½æ\u00b8\u009bç§\u0092æ\u0095°")]
		private float _ReduceSecSlowMove;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aå\u0090¹ã\u0081£é£\u009bã\u0081³è·\u009dé\u009b¢é\u0087\u008då\u008a\u009b")]
		private float _BlastSpGravity;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aå\u0090¹ã\u0081£é£\u009bã\u0081³æ\u0089\u0093ã\u0081¡ä\u00b8\u008aã\u0081\u0092è§\u0092åº¦[deg]")]
		private float _BlastSpAngle;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aå\u0090¹ã\u0081£é£\u009bã\u0081³é«\u0098ã\u0081\u0095[m]")]
		private float _BlastSpHeight;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aå\u0090¹ã\u0081£é£\u009bã\u0081³è·\u009dé\u009b¢ä¿\u0082æ\u0095°")]
		private float _BlastSpCoefficient;

		[SerializeField]
		[Tooltip("å\u008f\u0097ã\u0081\u0091èº«é«\u0098ã\u0081\u0095[m]")]
		private float _BlastRecoveryHeight;

		[SerializeField]
		[Tooltip("å\u008f\u0097ã\u0081\u0091èº«è·\u009dé\u009b¢ä¿\u0082æ\u0095°")]
		private float _BlastRecoveryCoefficient;

		[SerializeField]
		[Tooltip("æ\u0089\u0093ã\u0081¡ä\u00b8\u008aã\u0081\u0092æ\u009c\u0080å¤§é«\u0098ã\u0081\u0095[m]")]
		private float _BlastLimitHeight;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0081µã\u0081£é£\u009bã\u0081°ã\u0081\u0097æ\u0099\u0082ã\u0082«ã\u0083¡ã\u0083©æ\u008fºã\u0082\u0089ã\u0081\u0097")]
		private CameraController.ShakeType _BlastSpShakeType;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0083ªã\u0083\u0086ã\u0082£ã\u0082«ã\u0083«æ\u0099\u0082ã\u0082«ã\u0083¡ã\u0083©æ\u008fºã\u0082\u0089ã\u0081\u0097")]
		private CameraController.ShakeType _CriticalShakeType;

		[SerializeField]
		[Tooltip("è\u0090½ä\u00b8\u008bå\u0088¤å®\u009aé«\u0098ã\u0081\u0095[m]")]
		private float _FalloutHeight;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0083«ã\u0083¼ã\u0083\u0097æ\u0099\u0082é\u0096\u0093(ã\u0083\u0097ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼)[sec]")]
		private float _PlayerDownLoopSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0083«ã\u0083¼ã\u0083\u0097æ\u0099\u0082é\u0096\u0093(ã\u0083\u0097ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u00af¾æ\u0088¦)[sec]")]
		private float _PlayerDownLoopSecInBattleQuest;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0083«ã\u0083¼ã\u0083\u0097æ\u0099\u0082é\u0096\u0093(æ\u008a\u0095ã\u0081\u0092ã\u0082\u0089ã\u0082\u008cã\u0081\u009fæ\u0099\u0082)[sec]")]
		private float _PlayerDownLoopSecWhenThrown;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0083«ã\u0083¼ã\u0083\u0097æ\u0099\u0082é\u0096\u0093(ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼)[sec]")]
		private float _EnemyDownLoopSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³æ\u0099\u0082ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093(ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼)[sec]")]
		private float _EnemyDownInvincibleSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³æ\u0099\u0082ã\u0081®ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ä¿\u0082æ\u0095°(ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼å°\u0082ç\u0094\u00a8)")]
		private float _EnemyDownDamageCoefficient;

		[SerializeField]
		[Tooltip("å\u00af¾æ\u0088¦  è\u0090½ä\u00b8\u008bã\u0081\u008bã\u0082\u0089å¾©å\u00b8°å¾\u008cã\u0081®ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093[sec]")]
		private float _RespawnInvincibleSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0081\u008bã\u0082\u0089ç«\u008bã\u0081¡ä\u00b8\u008aã\u0081\u008cã\u0081£ã\u0081\u009få¾\u008cã\u0081®ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093[sec]")]
		private float _RecoveryInvincibleSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0081\u008bã\u0082\u0089ç«\u008bã\u0081¡ä\u00b8\u008aã\u0081\u008cã\u0081£ã\u0081\u009få¾\u008cã\u0081®ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093(æ\u009c\u0080ä½\u008eä¿\u009dé\u009a\u009cæ\u0099\u0082é\u0096\u0093)[sec]")]
		private float _RecoverySafetyInvincibleSec;

		[SerializeField]
		[Tooltip("å\u008f\u0097ã\u0081\u0091èº«å¾\u008cã\u0081®ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093[sec]")]
		private float _BlastRecoveryInvincibleSec;

		[SerializeField]
		[Tooltip("å\u008f\u0097ã\u0081\u0091èº«å\u008f\u00afè\u0083½æ\u0089\u0093ã\u0081¡ä\u00b8\u008aã\u0081\u0092è§\u0092åº¦[deg]")]
		private float _RecoveryLimitAngle;

		[SerializeField]
		[Tooltip("ç«\u009cå\u008c\u0096æ\u0099\u0082é\u0096\u0093[sec]")]
		private float _DragonTransformSec;

		[SerializeField]
		[Tooltip("ä¿¡é\u00a0¼åº¦ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0081«ã\u0081\u008bã\u0081\u0091ã\u0082\u008bæ\u0099\u0082é\u0096\u0093[sec]")]
		private float _DragonTransformBonusSec;

		[SerializeField]
		[Tooltip("ç«\u009cå\u008c\u0096è§£é\u0099¤å¾\u008cã\u0081\u008bã\u0082\u0089å\u0086\u008dç«\u009cå\u008c\u0096ã\u0081§ã\u0081\u008dã\u0082\u008bã\u0082\u0088ã\u0081\u0086ã\u0081«ã\u0081ªã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®æ\u0099\u0082é\u0096\u0093[sec]")]
		private float _DragonTransformRecastSec;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«ç\u0099ºå\u008b\u0095æ\u0099\u0082ã\u0081«ç«\u009cå\u008c\u0096æ\u0099\u0082é\u0096\u0093ã\u0082\u0092å\u0081\u009cæ­¢ã\u0081\u0095ã\u0081\u009bã\u0082\u008bæ\u0099\u0082é\u0096\u0093[sec]")]
		private float _DragonTransformPauseSec;

		[SerializeField]
		[Tooltip("ç«\u009cå\u008c\u0096ã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083«ã\u0083¼ã\u0083\u0097æ\u0099\u0082é\u0096\u0093[sec]")]
		private float _DragonTransformMotionLoopSec;

		[SerializeField]
		[Tooltip("ç«\u009cå\u008c\u0096è§£é\u0099¤å¾\u008cã\u0081®ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093[sec]")]
		private float _ReleaseDragonInvincibleSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		private float _DragonHitEffectScale;

		[SerializeField]
		[Tooltip("ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ã\u0083\u009dã\u0083\u0083ã\u0083\u0097å¾\u008cã\u0081®ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093[sec]")]
		private float _EnemyPopInvincibleSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ã\u0082¹ã\u0083\u0088ã\u0083\u0083ã\u0083\u0097æ\u0097¢å®\u009aã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u0095°(30fpsæ\u008f\u009bç®\u0097)äººå\u009e\u008b")]
		private float _HitStopDefaultFrameForHumanPlayer;

		[SerializeField]
		[Tooltip("ã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ã\u0082¹ã\u0083\u0088ã\u0083\u0083ã\u0083\u0097æ\u0097¢å®\u009aã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u0095°(30fpsæ\u008f\u009bç®\u0097)ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³å\u009e\u008b")]
		private float _HitStopDefaultFrameForDragonPlayer;

		[SerializeField]
		[Tooltip("ã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ã\u0082¹ã\u0083\u0088ã\u0083\u0083ã\u0083\u0097æ\u0097¢å®\u009aã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u0095°(30fpsæ\u008f\u009bç®\u0097)ã\u0083\u009cã\u0082¹ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼å\u009e\u008b")]
		private float _HitStopDefaultFrameForBossEnemy;

		[SerializeField]
		[Tooltip("ã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ã\u0082¹ã\u0083\u0088ã\u0083\u0083ã\u0083\u0097å\u0086\u008dç\u0094\u009fé\u0080\u009fåº¦å\u0080\u008dç\u008e\u0087(0.0ï½\u009e1.0)")]
		private float _HitStopMotionSpeedScale;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«æ\u009a\u0097è»¢é\u0096\u008bå§\u008bæ\u0099\u0082ã\u0081®é\u0081·ç§»æ\u0099\u0082é\u0096\u0093")]
		private float _SkillFadeOutTime;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«æ\u009a\u0097è»¢çµ\u0082äº\u0086æ\u0099\u0082ã\u0081®é\u0081·ç§»æ\u0099\u0082é\u0096\u0093")]
		private float _SkillFadeInTime;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«æ\u009a\u0097è»¢çµ\u0082äº\u0086å\u0087¦ç\u0090\u0086ã\u0081®é\u0096\u008bå§\u008bæ\u0099\u0082é\u0096\u0093")]
		private float _SkillFadeInStartTime;

		[SerializeField]
		[Tooltip("ã\u0082µã\u0083\u009dã\u0083¼ã\u0083\u0088ã\u0082¹ã\u0082­ã\u0083«ã\u0083ªã\u0082­ã\u0083£ã\u0082¹ã\u0083\u0088æ\u0099\u0082é\u0096\u0093[sec]")]
		private float _SupportSkillRecastSec;

		[SerializeField]
		[Tooltip("å¤\u0089èº«ã\u0083ªã\u0082­ã\u0083£ã\u0082¹ã\u0083\u0088æ\u0099\u0082é\u0096\u0093[sec]")]
		private float _UniqueTransformRecastSec;

		[SerializeField]
		[Tooltip("æ\u0093\u008dä½\u009cã\u0082­ã\u0083£ã\u0083©ä»¥å¤\u0096ã\u0081®SEé\u009f³é\u0087\u008fä¿\u0082æ\u0095°(0.0ï½\u009e1.0)")]
		private float _OthersSEVolumeRatio;

		[SerializeField]
		[Tooltip("æ\u009b\u00b8ã\u0081\u008dæ\u0096\u0087å­\u0097ã\u0081«ä\u00b8\u0080å¾\u008bã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		private float _FontEffectScale;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u0093ã\u0083ªã\u0083\u0086ã\u0082£ã\u0080\u008cã\u0083\u0092ã\u0083\u0083ã\u0083\u0088æ\u0095°ã\u0081«å¿\u009cã\u0081\u0098ã\u0081¦HPå\u009b\u009eå¾©ã\u0080\u008dã\u0081®1ã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ã\u0081\u0082ã\u0081\u009fã\u0082\u008aã\u0081®å\u009b\u009eå¾©é\u0087\u008f")]
		private int _RecoveryValueOnHitCount;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u0093ã\u0083ªã\u0083\u0086ã\u0082£ã\u0080\u008cã\u0083\u0092ã\u0083\u0083ã\u0083\u0088æ\u0095°ã\u0081«å¿\u009cã\u0081\u0098ã\u0081¦HPå\u009b\u009eå¾©ã\u0080\u008dã\u0081®æ\u009c\u0080å¤§å\u009b\u009eå¾©é\u0087\u008f")]
		private int _MaxRecoveryValueOnHitCount;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0083\u00afã\u0082¤ã\u0083\u0097å\u008f\u008då¿\u009cè·\u009dé\u009b¢")]
		private float[] _SwipeLength;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§ã\u0083\u009eã\u0083¼ã\u0082«ã\u0083¼ã\u0081®ã\u0082\u00a8ã\u0083\u0083ã\u0082\u00b8ã\u0081®ã\u0082µã\u0082¤ã\u0082º")]
		private float _ChargeMarkerEdgeSize;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§ã\u0083\u009eã\u0083¼ã\u0082«ã\u0083¼ã\u0081®ã\u0082\u00a8ã\u0083\u0083ã\u0082\u00b8ã\u0081®å¼·ã\u0081\u0095")]
		private float _ChargeMarkerEdgePower;

		[SerializeField]
		[Tooltip("æ\u008b\u0085ã\u0081\u008eå\u008f\u00afè\u0083½æ\u0099\u0082é\u0096\u0093")]
		private float _MaxCarrySec;

		[SerializeField]
		[Tooltip("æ\u008b\u00a0ç\u0082¹ã\u0081§ã\u0081®ã\u0083ªã\u0082\u00b8ã\u0082§ã\u0083\u008då\u0089²å\u0090\u0088[%]")]
		private float _PortalRegeneRate;

		[SerializeField]
		[Tooltip("æ\u008b\u00a0ç\u0082¹ã\u0081§ã\u0081®ã\u0083ªã\u0082\u00b8ã\u0082§ã\u0083\u008dé\u0096\u0093é\u009a\u0094[sec]")]
		private float _PortalRegeneInterval;

		[SerializeField]
		[Tooltip("HPå\u009b\u009eå¾©è\u00a8\u0088ç®\u0097å¼\u008fã\u0081®ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0081«æ\u008e\u009bã\u0081\u008bã\u0082\u008bä¿\u0082æ\u0095°")]
		private float _HpRecoveryFormulaCoef;

		[SerializeField]
		[Tooltip("[AI]ã\u0082­ã\u0083£ã\u0083©ã\u0083\u0081ã\u0082§ã\u0083³ã\u0082\u00b8å¾\u008cã\u0081«å\u009b\u009eé\u0081¿ã\u0081\u008cã\u0081§ã\u0081\u008dã\u0081ªã\u0081\u008fã\u0081ªã\u0082\u008bç§\u0092æ\u0095°")]
		private float _FollowerDisableAvoidSec;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8è»½æ\u00b8\u009bå\u0080\u008dç\u008e\u0087(è¢«ã\u0083\u0080ã\u0083¡ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ç\u0094\u00a8)")]
		private float _DamageCutRateForHpShareDragon;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8è»½æ\u00b8\u009bå\u0080\u008dç\u008e\u0087(å¾\u0093è\u0080\u0085å\u008f¬å\u0096\u009aæ\u0099\u0082ç\u0094\u00a8)")]
		private float _DamageCutRateForServantMode;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8è»½æ\u00b8\u009bå\u0080\u008dç\u008e\u0087(å\u0091³æ\u0096¹AIç\u0094\u00a8)")]
		private float _DamageCutRateForFollower;

		[SerializeField]
		[Tooltip("ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8è\u00a8\u0088ç®\u0097èª¿æ\u0095\u00b4ç\u0094\u00a8ä¿\u0082æ\u0095°")]
		private float _DamageAdjustCoef;

		[SerializeField]
		[Tooltip("HPå\u009b\u009eå¾©è\u00a8\u0088ç®\u0097èª¿æ\u0095\u00b4ç\u0094\u00a8ä¿\u0082æ\u0095°")]
		private float _HpRecoveryAdjustCoef;

		[SerializeField]
		[Tooltip("HPå\u009b\u009eå¾©è\u00a8\u0088ç®\u0097èª¿æ\u0095\u00b4ç\u0094\u00a8ä¿\u0082æ\u0095°(HP)")]
		private float _HpRecoveryAdjustCoefDependsOnHp;

		[SerializeField]
		[Tooltip("HPå\u009b\u009eå¾©è\u00a8\u0088ç®\u0097èª¿æ\u0095\u00b4ç\u0094\u00a8ä¿\u0082æ\u0095°(æ\u0094»æ\u0092\u0083å\u008a\u009b)")]
		private float _HpRecoveryAdjustCoefDependsOnAttack;

		[SerializeField]
		[Tooltip("HPå\u0090\u00b8å\u008f\u008eã\u0083\u0090ã\u0083\u0095ä\u00b8\u008aé\u0099\u0090")]
		private float _HpDrainBuffLimitRate;

		[SerializeField]
		[Tooltip("HPå\u0090\u00b8å\u008f\u008eã\u0083\u0092ã\u0083\u0083ã\u0083\u0088ã\u0082¢ã\u0083\u0088ã\u0083ªã\u0083\u0093ã\u0083¥ã\u0083¼ã\u0083\u0088")]
		private string _HpDrainHitAttribute;

		[SerializeField]
		[Tooltip("ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿å·®ã\u0081«ã\u0082\u0088ã\u0082\u008bã\u0082¹ã\u0083¼ã\u0083\u0091ã\u0083¼ã\u0082¢ã\u0083¼ã\u0083\u009eã\u0083¼LVè£\u009cæ­£")]
		private int _SuperArmorLvForParameterDisparity;

		[SerializeField]
		[Tooltip("è\u0087ªç\u0094±è\u0090½ä\u00b8\u008bé\u0080\u009fåº¦")]
		private float _FreeFallSpeed;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0083ªã\u0083\u0083ã\u0083\u0097ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095å\u00a8\u0081å\u008a\u009b")]
		private float[] _DebuffSlipPower;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®æ\u009c\u0080å¤§å\u0080¤")]
		private int _ActiveGaugeMaxValue;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0082¿ã\u0082¤ã\u0083\u00a0")]
		private float _ActiveGaugeDiffMoveTime;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0083ªã\u0082»ã\u0083\u0083ã\u0083\u0088æ\u0099\u0082ã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¢ã\u0083\u008bã\u0083¡é\u0096\u008bå§\u008bã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082¤ã\u0082¿ã\u0082¤ã\u0083\u00a0")]
		private float _ActiveGaugeResetGaugeAnimDelayTime;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0083ªã\u0082»ã\u0083\u0083ã\u0083\u0088æ\u0099\u0082ã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0095ã\u0083©ã\u0082°")]
		private bool _ActiveGaugeResetGaugeAnimFlag;

		[SerializeField]
		[Tooltip("ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼é\u0080²è»\u008dã\u0083¢ã\u0083¼ã\u0083\u0089ä\u00b8­ã\u0082µã\u0083¼ã\u0083\u0081é\u0096\u0093é\u009a\u0094ã\u0081®ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u009c\u0080å°\u008f")]
		private int _EnemyRouteModeSearchIntervalMin;

		[SerializeField]
		[Tooltip("ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼é\u0080²è»\u008dã\u0083¢ã\u0083¼ã\u0083\u0089ä\u00b8­ã\u0082µã\u0083¼ã\u0083\u0081é\u0096\u0093é\u009a\u0094ã\u0081®ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u009c\u0080å¤§")]
		private int _EnemyRouteModeSearchIntervalMax;

		[SerializeField]
		[Tooltip("ã\u0083\u009eã\u0083«ã\u0083\u0081ã\u0083\u0097ã\u0083¬ã\u0082¤å\u0086\u008dæ\u008c\u0091æ\u0088¦å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093[ç§\u0092]")]
		private float _MultiPlayRetryVoteWaitTime;

		[SerializeField]
		[Tooltip("ã\u0083\u009eã\u0083«ã\u0083\u0081ã\u0083\u0097ã\u0083¬ã\u0082¤å\u0086\u008dæ\u008c\u0091æ\u0088¦æ\u008b\u0092å\u0090¦å¾\u008cã\u0081®æ®\u008bç\u0095\u0099æ\u0099\u0082é\u0096\u0093[ç§\u0092]")]
		private float _MultiPlayRetryDeniedRemainTime;

		[SerializeField]
		[Tooltip("ç·\u008fæ\u0094»æ\u0092\u0083çµ\u0082äº\u0086å¾\u008cã\u0081®ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093[ç§\u0092]")]
		private float _InvincibleSecAfterAlloutAssault;

		[SerializeField]
		[Tooltip("1ã\u0082¹ã\u0082­ã\u0083«å\u0086\u0085ã\u0081§ã\u0081®ODã\u0082«ã\u0082¦ã\u0083³ã\u0082¿ã\u0083¼ã\u0081«ã\u0082\u0088ã\u0082\u008bã\u0083\u009cã\u0083¼ã\u0083\u008aã\u0082¹é\u0099\u0090ç\u0095\u008cå\u0080¤[ï¼\u0085]ï¼\u0088ã\u0082½ã\u0083­ç\u0089\u0088ï¼\u0089")]
		private float _OverdriveCounterLimitSolo;

		[SerializeField]
		[Tooltip("1ã\u0082¹ã\u0082­ã\u0083«å\u0086\u0085ã\u0081§ã\u0081®ODã\u0082«ã\u0082¦ã\u0083³ã\u0082¿ã\u0083¼ã\u0081«ã\u0082\u0088ã\u0082\u008bã\u0083\u009cã\u0083¼ã\u0083\u008aã\u0082¹é\u0099\u0090ç\u0095\u008cå\u0080¤[ï¼\u0085]ï¼\u0088ã\u0083\u009eã\u0083«ã\u0083\u0081ç\u0089\u0088ï¼\u0089")]
		private float _OverdriveCounterLimitMulti;

		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095é\u0080\u009fåº¦ã\u0083\u0080ã\u0082¦ã\u0083³Bã\u0080\u0080ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _MoveSpeedRateBMin;

		[Space]
		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091HPå¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffHPMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091HPã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffHPMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091æ\u0094»æ\u0092\u0083å¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffAttackMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091æ\u0094»æ\u0092\u0083ã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffAttackMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091é\u0098²å¾¡å¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffDefenseMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091é\u0098²å¾¡ã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffDefenseMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091é\u0098²å¾¡Bå¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffDefenseBMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091é\u0098²å¾¡Bã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffDefenseBMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0082\u00afã\u0083ªã\u0083\u0086ã\u0082£ã\u0082«ã\u0083«å¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffCriticalMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0082\u00afã\u0083ªã\u0083\u0086ã\u0082£ã\u0082«ã\u0083«ã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffCriticalMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0082¹ã\u0082­ã\u0083«å\u00a8\u0081å\u008a\u009bå¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffSkillPowerMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0082¹ã\u0082­ã\u0083«å\u00a8\u0081å\u008a\u009bã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffSkillPowerMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0083\u0090ã\u0083¼ã\u0082¹ã\u0083\u0088ã\u0082¢ã\u0083\u0083ã\u0082¿ã\u0082\u00afå\u00a8\u0081å\u008a\u009bå¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffBurstPowerMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0083\u0090ã\u0083¼ã\u0082¹ã\u0083\u0088ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0082\u00afå\u00a8\u0081å\u008a\u009bã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffBurstPowerMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091å\u009b\u009eå¾©å\u008a\u009bå¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffRecoveryMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091å\u009b\u009eå¾©å\u008a\u009bã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffRecoveryMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091SPå\u009b\u009eå¾©å\u008a\u009bå¼·å\u008c\u0096 ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffRecoverySpMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091SPå\u009b\u009eå¾©å\u008a\u009bã\u0083\u0080ã\u0082¦ã\u0083³ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffRecoverySpMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091æ\u0094»æ\u0092\u0083é\u0080\u009fåº¦ ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffAttackSpeedMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091æ\u0094»æ\u0092\u0083é\u0080\u009fåº¦ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffAttackSpeedMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8N%ç\u0084¡å\u008a¹ ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffDamageCutMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8B N%ç\u0084¡å\u008a¹ ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffDamageCutBMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091å\u0088\u0083ã\u0081\u0093ã\u0081¼ã\u0082\u008cã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffNickedMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0083\u0090ã\u0083¼ã\u0082¹ã\u0083\u0088ã\u0083\u0081ã\u0083£ã\u0083¼ã\u0082\u00b8é\u0080\u009fåº¦ ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffChargeSpeedMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091ã\u0083\u0090ã\u0083¼ã\u0082¹ã\u0083\u0088ã\u0083\u0081ã\u0083£ã\u0083¼ã\u0082\u00b8é\u0080\u009fåº¦ ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffChargeSpeedMin;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091HPè¢«å\u009b\u009eå¾©å¼·å\u008c\u0096ã\u0080\u0080ã\u0081®ä\u00b8\u008aé\u0099\u0090å\u0080¤")]
		private float _BuffGetHpRecoveryMax;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0080\u0091HPè¢«å\u009b\u009eå¾©ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0080\u0080ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _BuffGetHpRecoveryMin;

		[Space]
		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0082¢ã\u0083\u0093ã\u0083ªã\u0083\u0086ã\u0082£ã\u0080\u0091è\u0087ªã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0083¼ã\u0081®ç«\u009cå\u008c\u0096å»¶é\u0095·æ\u0099\u0082é\u0096\u0093ã\u0081®æ\u009c\u0080å¤§å\u0080¤ï¼\u0088ç§\u0092æ\u0095°ï¼\u0089")]
		private float _AbilityDragonTimeForPartyMaxValue;

		[SerializeField]
		[Tooltip("ã\u0080\u0090ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ã\u0082¢ã\u0083\u0093ã\u0083ªã\u0083\u0086ã\u0082£ã\u0080\u0091æ\u0094»æ\u0092\u0083ç\u00af\u0084å\u009b²è\u0080\u0090æ\u0080§ã\u0081®ä\u00b8\u008bé\u0099\u0090å\u0080¤")]
		private float _EnemyAbiityAttackRangeToleranceMin;

		public int Id => default(int);

		public float SpAttack => default(float);

		public float SpDamage => default(float);

		public int ConsumeDp => default(int);

		public int DropDpOnEnemyDead => default(int);

		public int DropDpOnBossHpRate => default(int);

		public float ChainTime => default(float);

		public float MoveSpeed => default(float);

		public float DurationTime => default(float);

		public float DashStopTimeMin => default(float);

		public float DashStopTimeMax => default(float);

		public float DashAttackInputTime => default(float);

		public float DashMaxTime => default(float);

		public float DashSpeedRatio => default(float);

		public float DefenseHumanDashSpeedRatio => default(float);

		public float DefenseDragonDashSpeedRatio => default(float);

		public float ChargeStartTime => default(float);

		public float ChargePullThreshold => default(float);

		public float PlayerMass => default(float);

		public float DragonMass => default(float);

		public float MaxDepenetrationVelocity => default(float);

		public float SearchAbsoluteRange => default(float);

		public float SearchRangeCoefEnemy => default(float);

		public float SearchRangeCoefObject => default(float);

		public float SearchRangeCoefSwitch => default(float);

		public float BattleBgOffset => default(float);

		public float CriticalCoef => default(float);

		public float DragonDamageCoef => default(float);

		public float BreakDamageCoef => default(float);

		public float HealCoef => default(float);

		public float RaidHealCoef => default(float);

		public float MaxTensionAttackCoef => default(float);

		public float MaxTensionHealCoef => default(float);

		public float ReduceSecBurn => default(float);

		public float ReleaseFreezeAttackNum => default(float);

		public float ReduceSecSwoon => default(float);

		public float ReduceSecSlowMove => default(float);

		public float BlastSpGravity => default(float);

		public float BlastSpAngle => default(float);

		public float BlastSpHeight => default(float);

		public float BlastSpCoefficient => default(float);

		public float BlastRecoveryHeight => default(float);

		public float BlastRecoveryCoefficient => default(float);

		public float BlastLimitHeight => default(float);

		public CameraController.ShakeType BlastSpShakeType => default(CameraController.ShakeType);

		public float FalloutHeight => default(float);

		public float PlayerDownLoopSec => default(float);

		public float PlayerDownLoopSecInBattleQuest => default(float);

		public float PlayerDownLoopSecWhenThrown => default(float);

		public float EnemyDownLoopSec => default(float);

		public float EnemyDownInvincibleSec => default(float);

		public float EnemyDownDamageCoefficient => default(float);

		public float RespawnInvincibleSec => default(float);

		public float RecoveryInvincibleSec => default(float);

		public float RecoverySafetyInvincibleSec => default(float);

		public float BlastRecoveryInvincibleSec => default(float);

		public float RecoveryLimitAngle => default(float);

		public float DragonTransformSec => default(float);

		public float DragonTransformBonusSec => default(float);

		public float DragonTransformRecastSec => default(float);

		public float DragonTransformPauseSec => default(float);

		public float DragonTransformMotionLoopSec => default(float);

		public float ReleaseDragonInvincibleSec => default(float);

		public float DragonHitEffectScale => default(float);

		public float EnemyPopInvincibleSec => default(float);

		public float HitStopDefaultFrameForHumanPlayer => default(float);

		public float HitStopDefaultFrameForDragonPlayer => default(float);

		public float HitStopDefaultFrameForBossEnemy => default(float);

		public float HitStopMotionSpeedScale => default(float);

		public float SkillFadeOutTime => default(float);

		public float SkillFadeInTime => default(float);

		public float SkillFadeInStartTime => default(float);

		public float SupportSkillRecastSec => default(float);

		public float UniqueTransformRecastSec => default(float);

		public float OthersSEVolumeRatio => default(float);

		public float FontEffectScale => default(float);

		public int RecoveryValueOnHitCount => default(int);

		public int MaxRecoveryValueOnHitCount => default(int);

		public float ChargeMarkerEdgeSize => default(float);

		public float ChargeMarkerEdgePower => default(float);

		public float MaxCarrySec => default(float);

		public float PortalRegeneRate => default(float);

		public float PortalRegeneInterval => default(float);

		public float HpRecoveryFormulaCoef => default(float);

		public float FollowerDisableAvoidSec => default(float);

		public float DamageCutRateForHpShareDragon => default(float);

		public float DamageCutRateForServantMode => default(float);

		public float DamageCutRateForFollower => default(float);

		public float DamageAdjustCoef => default(float);

		public float HpRecoveryAdjustCoef => default(float);

		public float HpRecoveryAdjustCoefDependsOnHp => default(float);

		public float HpRecoveryAdjustCoefDependsOnAttack => default(float);

		public float HpDrainBuffLimitRate => default(float);

		public string HpDrainHitAttribute => null;

		public int SuperArmorLvForParameterDisparity => default(int);

		public float FreeFallSpeed => default(float);

		public float[] DebuffSlipPower => null;

		public int ActiveGaugeMaxValue => default(int);

		public float ActiveGaugeDiffMoveTime => default(float);

		public float ActiveGaugeResetGaugeAnimDelayTime => default(float);

		public bool ActiveGaugeResetGaugeAnimFlag => default(bool);

		public int EnemyRouteModeSearchIntervalMin => default(int);

		public int EnemyRouteModeSearchIntervalMax => default(int);

		public float MultiPlayRetryVoteWaitTime => default(float);

		public float MultiPlayRetryDeniedRemainTime => default(float);

		public float InvincibleSecAfterAlloutAssault => default(float);

		public float OverdriveCounterLimitSolo => default(float);

		public float OverdriveCounterLimitMulti => default(float);

		public float MoveSpeedRateBMin => default(float);

		public float BuffHPMax => default(float);

		public float BuffHPMin => default(float);

		public float BuffAttackMax => default(float);

		public float BuffAttackMin => default(float);

		public float BuffDefenseMax => default(float);

		public float BuffDefenseMin => default(float);

		public float BuffDefenseBMax => default(float);

		public float BuffDefenseBMin => default(float);

		public float BuffCriticalMax => default(float);

		public float BuffCriticalMin => default(float);

		public float BuffSkillPowerMax => default(float);

		public float BuffSkillPowerMin => default(float);

		public float BuffBurstPowerMax => default(float);

		public float BuffBurstPowerMin => default(float);

		public float BuffRecoveryMax => default(float);

		public float BuffRecoveryMin => default(float);

		public float BuffRecoverySpMax => default(float);

		public float BuffRecoverySpMin => default(float);

		public float BuffAttackSpeedMax => default(float);

		public float BuffAttackSpeedMin => default(float);

		public float BuffDamageCutMax => default(float);

		public float BuffDamageCutBMax => default(float);

		public float BuffNickedMin => default(float);

		public float BuffChargeSpeedMax => default(float);

		public float BuffChargeSpeedMin => default(float);

		public float BuffGetHpRecoveryMax => default(float);

		public float BuffGetHpRecoveryMin => default(float);

		public float AbilityDragonTimeForPartyMaxValue => default(float);

		public float EnemyAbiityAttackRangeToleranceMin => default(float);

		public float SwipeLength(int idx)
		{
			return default(float);
		}
	}
}
