using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyAbilityElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private EnemyAbilityType _AbilityType;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _IconId;

		[SerializeField]
		private float _UiOffsetY2D;

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
		private int _TargetType;

		[SerializeField]
		private int _BuffId03;

		[SerializeField]
		private int _BuffId0302;

		[SerializeField]
		private int _BuffId0303;

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
		private Gluon.AbnormalStatusType _AbnormaType0201;

		[SerializeField]
		private int _AbnormalRate0201;

		[SerializeField]
		private Gluon.AbnormalStatusType _AbnormaType0202;

		[SerializeField]
		private int _AbnormalRate0202;

		[SerializeField]
		private Gluon.AbnormalStatusType _AbnormaType0203;

		[SerializeField]
		private int _AbnormalRate0203;

		[SerializeField]
		private int _BuffId04;

		[SerializeField]
		private int _ActionId03;

		[SerializeField]
		private int _ActionId02;

		[SerializeField]
		private int _Count0101;

		[SerializeField]
		private int _Count0102;

		[SerializeField]
		private int _Count02;

		[SerializeField]
		private float _Duration05;

		[SerializeField]
		private int _BuffId05;

		[SerializeField]
		private int _BuffNum;

		[SerializeField]
		private int _MaskType;

		[SerializeField]
		private int _BuffId06;

		[SerializeField]
		private float _BuffInterval02;

		[SerializeField]
		private float _RecDmgRate03;

		[SerializeField]
		private int _SongType;

		[SerializeField]
		private int _Count03;

		[SerializeField]
		private int _AbnormalRate0301;

		[SerializeField]
		private int _AbnormalRate0302;

		[SerializeField]
		private string _HitAttr07;

		[SerializeField]
		private int _BuffId07;

		[SerializeField]
		private int _RecDmgRate04;

		[SerializeField]
		private int _Count0401;

		[SerializeField]
		private int _Count0402;

		[SerializeField]
		private int _Count0403;

		[SerializeField]
		private int _Count0404;

		[SerializeField]
		private string _HitAttr0801;

		[SerializeField]
		private string _HitAttr0802;

		[SerializeField]
		private float _HealInterval01;

		[SerializeField]
		private int _WallHp0101;

		[SerializeField]
		private int _WallHp0102;

		[SerializeField]
		private string _HitAttr09;

		[SerializeField]
		private float _DmgZoneR06;

		[SerializeField]
		private float _DmgInterval03;

		[SerializeField]
		private int _VisibleZone;

		[SerializeField]
		private float _EffScale01;

		[SerializeField]
		private int _FieldType;

		[SerializeField]
		private float _DmgZoneR0701;

		[SerializeField]
		private float _DmgZoneR0702;

		[SerializeField]
		private int _Count05;

		[SerializeField]
		private int _ActionId04;

		[SerializeField]
		private string _HitEffect03;

		[SerializeField]
		private float _Interval01;

		[SerializeField]
		private string _HitAttr10;

		[SerializeField]
		private int _BuffId08;

		[SerializeField]
		private int _MaxLevel02;

		public int Id => default(int);

		public EnemyAbilityType AbilityType => default(EnemyAbilityType);

		public string Name => null;

		public string IconId => null;

		public float UiOffsetY2D => default(float);

		public string EffectName => null;

		public float BerserkBreakLimit => default(float);

		public int BerserkODAtkRate => default(int);

		public int BerserkODDefRate => default(int);

		public int BerserkBreakAtkRate => default(int);

		public int BerserkBreakDefRate => default(int);

		public int BerserkODDmgRateOnBurstAtk => default(int);

		public int HpCost => default(int);

		public float DownScale => default(float);

		public string GeneratorLabel => null;

		public string Reserve01 => null;

		public float KillerDefDevide => default(float);

		public int DebuffId => default(int);

		public int BaseDpDamage => default(int);

		public int AttackRangeToleranceType => default(int);

		public float AttackRangeToleranceRate => default(float);

		public string HitAttr01 => null;

		public float DmgInterval => default(float);

		public float DmgZoneR => default(float);

		public float ReducedDmgRate => default(float);

		public float MirageDownODRate => default(float);

		public float SpeedRate01 => default(float);

		public string HitAttr02 => null;

		public float DmgZoneR02 => default(float);

		public float HoleR01 => default(float);

		public float Duration01 => default(float);

		public string HitAttr0301 => null;

		public float DmgZoneR0301 => default(float);

		public float ReducedDmgRate0201 => default(float);

		public string HitAttr0302 => null;

		public float DmgZoneR0302 => default(float);

		public float ReducedDmgRate0202 => default(float);

		public string HitAttr0303 => null;

		public float DmgZoneR0303 => default(float);

		public float ReducedDmgRate0203 => default(float);

		public string HitAttr0304 => null;

		public float ReducedDmgRate0204 => default(float);

		public int OdDefRate => default(int);

		public string HitAttr04 => null;

		public int FixedDmgStack02 => default(int);

		public int FixedDmgStack03 => default(int);

		public int FixedDmgStack04 => default(int);

		public int FixedDmgStack05 => default(int);

		public string HitAttr05 => null;

		public float DmgInterval02 => default(float);

		public float Duration02 => default(float);

		public int UseVirus => default(int);

		public string HitEffect02 => null;

		public string HitSe02 => null;

		public float ReducedDmgRate03 => default(float);

		public float LevelDmgRate => default(float);

		public float LevelUpInterval => default(float);

		public int MaxLevel => default(int);

		public float BodyScale => default(float);

		public float Duration04 => default(float);

		public string HitEffect01 => null;

		public string HitSe01 => null;

		public int FixedAbnormalRate => default(int);

		public int FixedAbnormalRate02 => default(int);

		public int FixedAbnormalRate03 => default(int);

		public float Duration03 => default(float);

		public float Duration0302 => default(float);

		public float Duration0303 => default(float);

		public float DmgZoneR0401 => default(float);

		public float DmgZoneR0402 => default(float);

		public int ReduceDuration => default(int);

		public float DmgZoneR05 => default(float);

		public float AttackDmgRate => default(float);

		public float ReceiveDmgRate => default(float);

		public int BuffId => default(int);

		public float RetryTime => default(float);

		public string HitAttr06 => null;

		public string BarrierEff => null;

		public string BarrierBrokenEff => null;

		public int BarrierHitTimes => default(int);

		public float BarrierDuration => default(float);

		public ShowTiming ShowingTiming => default(ShowTiming);

		public int PartnerId => default(int);

		public float PartnerDeadPos => default(float);

		public int PartnerActionOnWeakDestroy => default(int);

		public int ParterActionOnTimerAction => default(int);

		public float ReducedDmgRate04 => default(float);

		public int BuffId02 => default(int);

		public float BuffInterval => default(float);

		public int TargetParamId => default(int);

		public int StopAbilityActionId => default(int);

		public string UndeadEffect => null;

		public int ReducedDP => default(int);

		public int ReducedUTP => default(int);

		public int WarpGateId => default(int);

		public float ZoneR01 => default(float);

		public int ActionId01 => default(int);

		public int TargetType => default(int);

		public int BuffId03 => default(int);

		public int BuffId0302 => default(int);

		public int BuffId0303 => default(int);

		public int YinYangType => default(int);

		public int AtkDmgRate02 => default(int);

		public int RecDmgRate02 => default(int);

		public int AbnormalRate0100 => default(int);

		public int AbnormalRate0101 => default(int);

		public int AbnormalRate0102 => default(int);

		public Gluon.AbnormalStatusType AbnormaType0201 => default(Gluon.AbnormalStatusType);

		public int AbnormalRate0201 => default(int);

		public Gluon.AbnormalStatusType AbnormaType0202 => default(Gluon.AbnormalStatusType);

		public int AbnormalRate0202 => default(int);

		public Gluon.AbnormalStatusType AbnormaType0203 => default(Gluon.AbnormalStatusType);

		public int AbnormalRate0203 => default(int);

		public int BuffId04 => default(int);

		public int ActionId03 => default(int);

		public int ActionId02 => default(int);

		public int Count0101 => default(int);

		public int Count0102 => default(int);

		public int Count02 => default(int);

		public float Duration05 => default(float);

		public int BuffId05 => default(int);

		public int BuffNum => default(int);

		public int MaskType => default(int);

		public int BuffId06 => default(int);

		public float BuffInterval02 => default(float);

		public float RecDmgRate03 => default(float);

		public int SongType => default(int);

		public int Count03 => default(int);

		public int AbnormalRate0301 => default(int);

		public int AbnormalRate0302 => default(int);

		public string HitAttr07 => null;

		public int BuffId07 => default(int);

		public int RecDmgRate04 => default(int);

		public int Count0401 => default(int);

		public int Count0402 => default(int);

		public int Count0403 => default(int);

		public int Count0404 => default(int);

		public string HitAttr0801 => null;

		public string HitAttr0802 => null;

		public float HealInterval01 => default(float);

		public int WallHp0101 => default(int);

		public int WallHp0102 => default(int);

		public string HitAttr09 => null;

		public float DmgZoneR06 => default(float);

		public float DmgInterval03 => default(float);

		public int VisibleZone => default(int);

		public float EffScale01 => default(float);

		public int FieldType => default(int);

		public float DmgZoneR0701 => default(float);

		public float DmgZoneR0702 => default(float);

		public int Count05 => default(int);

		public int ActionId04 => default(int);

		public string HitEffect03 => null;

		public float Interval01 => default(float);

		public string HitAttr10 => null;

		public int BuffId08 => default(int);

		public int MaxLevel02 => default(int);
	}
}
