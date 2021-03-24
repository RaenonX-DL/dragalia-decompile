/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyAbilityElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private EnemyAbilityType _AbilityType;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _IconId;
		[SerializeField]
		private string _EffectName;
		[SerializeField]
		private float _BerserkBreakLimit;
		[SerializeField]
		private int _BerserkODAtkRate;
		[SerializeField]
		private int _BerserkODDefRate;
		[SerializeField]
		private int _BerserkBreakAtkRate;
		[SerializeField]
		private int _BerserkBreakDefRate;
		[SerializeField]
		private int _BerserkODDmgRateOnBurstAtk;
		[SerializeField]
		private int _HpCost;
		[SerializeField]
		private float _DownScale;
		[SerializeField]
		private string _GeneratorLabel;
		[SerializeField]
		private string _Reserve01;
		[SerializeField]
		private float _KillerDefDevide;
		[SerializeField]
		private int _DebuffId;
		[SerializeField]
		private int _BaseDpDamage;
		[SerializeField]
		private int _AttackRangeToleranceType;
		[SerializeField]
		private float _AttackRangeToleranceRate;
		[SerializeField]
		private string _HitAttr01;
		[SerializeField]
		private float _DmgInterval;
		[SerializeField]
		private float _DmgZoneR;
		[SerializeField]
		private float _ReducedDmgRate;
		[SerializeField]
		private float _MirageDownODRate;
		[SerializeField]
		private float _SpeedRate01;
		[SerializeField]
		private string _HitAttr02;
		[SerializeField]
		private float _DmgZoneR02;
		[SerializeField]
		private float _HoleR01;
		[SerializeField]
		private float _Duration01;
		[SerializeField]
		private string _HitAttr0301;
		[SerializeField]
		private float _DmgZoneR0301;
		[SerializeField]
		private float _ReducedDmgRate0201;
		[SerializeField]
		private string _HitAttr0302;
		[SerializeField]
		private float _DmgZoneR0302;
		[SerializeField]
		private float _ReducedDmgRate0202;
		[SerializeField]
		private string _HitAttr0303;
		[SerializeField]
		private float _DmgZoneR0303;
		[SerializeField]
		private float _ReducedDmgRate0203;
		[SerializeField]
		private string _HitAttr0304;
		[SerializeField]
		private float _ReducedDmgRate0204;
		[SerializeField]
		private int _OdDefRate;
		[SerializeField]
		private string _HitAttr04;
		[SerializeField]
		private int _FixedDmgStack02;
		[SerializeField]
		private int _FixedDmgStack03;
		[SerializeField]
		private int _FixedDmgStack04;
		[SerializeField]
		private int _FixedDmgStack05;
		[SerializeField]
		private string _HitAttr05;
		[SerializeField]
		private float _DmgInterval02;
		[SerializeField]
		private float _Duration02;
		[SerializeField]
		private int _UseVirus;
		[SerializeField]
		private string _HitEffect02;
		[SerializeField]
		private string _HitSe02;
		[SerializeField]
		private float _ReducedDmgRate03;
		[SerializeField]
		private float _LevelDmgRate;
		[SerializeField]
		private float _LevelUpInterval;
		[SerializeField]
		private int _MaxLevel;
		[SerializeField]
		private float _BodyScale;
		[SerializeField]
		private float _Duration04;
		[SerializeField]
		private string _HitEffect01;
		[SerializeField]
		private string _HitSe01;
		[SerializeField]
		private int _FixedAbnormalRate;
		[SerializeField]
		private int _FixedAbnormalRate02;
		[SerializeField]
		private int _FixedAbnormalRate03;
		[SerializeField]
		private float _Duration03;
		[SerializeField]
		private float _Duration0302;
		[SerializeField]
		private float _Duration0303;
		[SerializeField]
		private float _DmgZoneR0401;
		[SerializeField]
		private float _DmgZoneR0402;
		[SerializeField]
		private int _ReduceDuration;
		[SerializeField]
		private float _DmgZoneR05;
		[SerializeField]
		private float _AttackDmgRate;
		[SerializeField]
		private float _ReceiveDmgRate;
		[SerializeField]
		private int _BuffId;
		[SerializeField]
		private float _RetryTime;
		[SerializeField]
		private string _HitAttr06;
		[SerializeField]
		private string _BarrierEff;
		[SerializeField]
		private string _BarrierBrokenEff;
		[SerializeField]
		private int _BarrierHitTimes;
		[SerializeField]
		private float _BarrierDuration;
		[SerializeField]
		private ShowTiming _ShowingTiming;
		[SerializeField]
		private int _PartnerId;
		[SerializeField]
		private float _PartnerDeadPos;
		[SerializeField]
		private int _PartnerActionOnWeakDestroy;
		[SerializeField]
		private int _ParterActionOnTimerAction;
		[SerializeField]
		private float _ReducedDmgRate04;
		[SerializeField]
		private int _BuffId02;
		[SerializeField]
		private float _BuffInterval;
		[SerializeField]
		private int _TargetParamId;
		[SerializeField]
		private int _StopAbilityActionId;
		[SerializeField]
		private string _UndeadEffect;
		[SerializeField]
		private int _ReducedDP;
		[SerializeField]
		private int _ReducedUTP;
		[SerializeField]
		private int _WarpGateId;
		[SerializeField]
		private float _ZoneR01;
		[SerializeField]
		private int _ActionId01;
		[SerializeField]
		private int _BuffId03;
		[SerializeField]
		private int _YinYangType;
		[SerializeField]
		private int _AtkDmgRate02;
		[SerializeField]
		private int _RecDmgRate02;
		[SerializeField]
		private int _AbnormalRate0100;
		[SerializeField]
		private int _AbnormalRate0101;
		[SerializeField]
		private int _AbnormalRate0102;
		[SerializeField]
		private AbnormalStatusType _AbnormaType0201;
		[SerializeField]
		private int _AbnormalRate0201;
		[SerializeField]
		private AbnormalStatusType _AbnormaType0202;
		[SerializeField]
		private int _AbnormalRate0202;
		[SerializeField]
		private AbnormalStatusType _AbnormaType0203;
		[SerializeField]
		private int _AbnormalRate0203;
	
		// Properties
		public int Id { get; }
		public EnemyAbilityType AbilityType { get; }
		public string Name { get; }
		public string IconId { get; }
		public string EffectName { get; }
		public float BerserkBreakLimit { get; }
		public int BerserkODAtkRate { get; }
		public int BerserkODDefRate { get; }
		public int BerserkBreakAtkRate { get; }
		public int BerserkBreakDefRate { get; }
		public int BerserkODDmgRateOnBurstAtk { get; }
		public int HpCost { get; }
		public float DownScale { get; }
		public string GeneratorLabel { get; }
		public string Reserve01 { get; }
		public float KillerDefDevide { get; }
		public int DebuffId { get; }
		public int BaseDpDamage { get; }
		public int AttackRangeToleranceType { get; }
		public float AttackRangeToleranceRate { get; }
		public string HitAttr01 { get; }
		public float DmgInterval { get; }
		public float DmgZoneR { get; }
		public float ReducedDmgRate { get; }
		public float MirageDownODRate { get; }
		public float SpeedRate01 { get; }
		public string HitAttr02 { get; }
		public float DmgZoneR02 { get; }
		public float HoleR01 { get; }
		public float Duration01 { get; }
		public string HitAttr0301 { get; }
		public float DmgZoneR0301 { get; }
		public float ReducedDmgRate0201 { get; }
		public string HitAttr0302 { get; }
		public float DmgZoneR0302 { get; }
		public float ReducedDmgRate0202 { get; }
		public string HitAttr0303 { get; }
		public float DmgZoneR0303 { get; }
		public float ReducedDmgRate0203 { get; }
		public string HitAttr0304 { get; }
		public float ReducedDmgRate0204 { get; }
		public int OdDefRate { get; }
		public string HitAttr04 { get; }
		public int FixedDmgStack02 { get; }
		public int FixedDmgStack03 { get; }
		public int FixedDmgStack04 { get; }
		public int FixedDmgStack05 { get; }
		public string HitAttr05 { get; }
		public float DmgInterval02 { get; }
		public float Duration02 { get; }
		public int UseVirus { get; }
		public string HitEffect02 { get; }
		public string HitSe02 { get; }
		public float ReducedDmgRate03 { get; }
		public float LevelDmgRate { get; }
		public float LevelUpInterval { get; }
		public int MaxLevel { get; }
		public float BodyScale { get; }
		public float Duration04 { get; }
		public string HitEffect01 { get; }
		public string HitSe01 { get; }
		public int FixedAbnormalRate { get; }
		public int FixedAbnormalRate02 { get; }
		public int FixedAbnormalRate03 { get; }
		public float Duration03 { get; }
		public float Duration0302 { get; }
		public float Duration0303 { get; }
		public float DmgZoneR0401 { get; }
		public float DmgZoneR0402 { get; }
		public int ReduceDuration { get; }
		public float DmgZoneR05 { get; }
		public float AttackDmgRate { get; }
		public float ReceiveDmgRate { get; }
		public int BuffId { get; }
		public float RetryTime { get; }
		public string HitAttr06 { get; }
		public string BarrierEff { get; }
		public string BarrierBrokenEff { get; }
		public int BarrierHitTimes { get; }
		public float BarrierDuration { get; }
		public ShowTiming ShowingTiming { get; }
		public int PartnerId { get; }
		public float PartnerDeadPos { get; }
		public int PartnerActionOnWeakDestroy { get; }
		public int ParterActionOnTimerAction { get; }
		public float ReducedDmgRate04 { get; }
		public int BuffId02 { get; }
		public float BuffInterval { get; }
		public int TargetParamId { get; }
		public int StopAbilityActionId { get; }
		public string UndeadEffect { get; }
		public int ReducedDP { get; }
		public int ReducedUTP { get; }
		public int WarpGateId { get; }
		public float ZoneR01 { get; }
		public int ActionId01 { get; }
		public int BuffId03 { get; }
		public int YinYangType { get; }
		public int AtkDmgRate02 { get; }
		public int RecDmgRate02 { get; }
		public int AbnormalRate0100 { get; }
		public int AbnormalRate0101 { get; }
		public int AbnormalRate0102 { get; }
		public AbnormalStatusType AbnormaType0201 { get; }
		public int AbnormalRate0201 { get; }
		public AbnormalStatusType AbnormaType0202 { get; }
		public int AbnormalRate0202 { get; }
		public AbnormalStatusType AbnormaType0203 { get; }
		public int AbnormalRate0203 { get; }
	
		// Constructors
		public EnemyAbilityElement();
	}
}
