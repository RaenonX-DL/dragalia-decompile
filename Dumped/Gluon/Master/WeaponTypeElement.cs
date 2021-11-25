using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponTypeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Label;

		[SerializeField]
		private int _DefaultWeapon;

		[SerializeField]
		private int _ShareWeapon;

		[SerializeField]
		private float _CoRecoverSp;

		[SerializeField]
		private float _SearchRange;

		[SerializeField]
		private float _SearchAngle;

		[SerializeField]
		private int _CriticalProbability;

		[SerializeField]
		private float _DamageCoef;

		[SerializeField]
		private float _MinDamageCoef;

		[SerializeField]
		private float _AdditionStartDistance;

		[SerializeField]
		private float _AdditionEndDistance;

		[SerializeField]
		private float _DecayStartDistance;

		[SerializeField]
		private float _DecayEndDistance;

		[SerializeField]
		private WeaponAttackRangeType _AttackRangeType;

		[SerializeField]
		private int _DefaultSkill01;

		[SerializeField]
		private int _DefaultSkill02;

		[SerializeField]
		private int _DefaultSkill03;

		[SerializeField]
		private int _DefaultSkill04;

		[SerializeField]
		private int _DefaultSkill05;

		[SerializeField]
		private int _DefaultSkill05Ex;

		[SerializeField]
		private int _BurstChargePhase1;

		[SerializeField]
		private int _BurstChargePhase2;

		[SerializeField]
		private int _BurstPhase1;

		[SerializeField]
		private int _BurstPhase2;

		[SerializeField]
		private int _ChargeCancel;

		[SerializeField]
		private int _ChargeMarker;

		[SerializeField]
		private float _ChargeSuperArmorTime;

		[SerializeField]
		private int _ChargeSuperArmorLv;

		[SerializeField]
		private float _BurstCameraFollowSpeed;

		[SerializeField]
		private int _DashSkill;

		[SerializeField]
		private float _AiBurstProbabilityOD;

		[SerializeField]
		private float _AiBurstProbabilityBarrier;

		[SerializeField]
		private float _AiBurstProbabilityEnhanced;

		public int Id => default(int);

		public string Label => null;

		public int DefaultWeapon => default(int);

		public int ShareWeapon => default(int);

		public float CoRecoverSp => default(float);

		public float SearchRange => default(float);

		public float SearchAngle => default(float);

		public int CriticalProbability => default(int);

		public float DamageCoef => default(float);

		public float MinDamageCoef => default(float);

		public float AdditionStartDistance => default(float);

		public float AdditionEndDistance => default(float);

		public float DecayStartDistance => default(float);

		public float DecayEndDistance => default(float);

		public WeaponAttackRangeType AttackRangeType => default(WeaponAttackRangeType);

		public int DefaultSkill01 => default(int);

		public int DefaultSkill02 => default(int);

		public int DefaultSkill03 => default(int);

		public int DefaultSkill04 => default(int);

		public int DefaultSkill05 => default(int);

		public int DefaultSkill05Ex => default(int);

		public int BurstChargePhase1 => default(int);

		public int BurstChargePhase2 => default(int);

		public int BurstPhase1 => default(int);

		public int BurstPhase2 => default(int);

		public int ChargeCancel => default(int);

		public int ChargeMarker => default(int);

		public float ChargeSuperArmorTime => default(float);

		public int ChargeSuperArmorLv => default(int);

		public float BurstCameraFollowSpeed => default(float);

		public int DashSkill => default(int);

		public float AiBurstProbabilityOD => default(float);

		public float AiBurstProbabilityBarrier => default(float);

		public float AiBurstProbabilityEnhanced => default(float);
	}
}
