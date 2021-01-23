/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class WeaponTypeElement : IMasterElement
	{
		// Fields
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
	
		// Properties
		public int Id { get; }
		public string Label { get; }
		public int DefaultWeapon { get; }
		public int ShareWeapon { get; }
		public float CoRecoverSp { get; }
		public float SearchRange { get; }
		public float SearchAngle { get; }
		public int CriticalProbability { get; }
		public float DamageCoef { get; }
		public float MinDamageCoef { get; }
		public float AdditionStartDistance { get; }
		public float AdditionEndDistance { get; }
		public float DecayStartDistance { get; }
		public float DecayEndDistance { get; }
		public WeaponAttackRangeType AttackRangeType { get; }
		public int DefaultSkill01 { get; }
		public int DefaultSkill02 { get; }
		public int DefaultSkill03 { get; }
		public int DefaultSkill04 { get; }
		public int DefaultSkill05 { get; }
		public int DefaultSkill05Ex { get; }
		public int BurstChargePhase1 { get; }
		public int BurstChargePhase2 { get; }
		public int BurstPhase1 { get; }
		public int BurstPhase2 { get; }
		public int ChargeCancel { get; }
		public int ChargeMarker { get; }
		public float ChargeSuperArmorTime { get; }
		public int ChargeSuperArmorLv { get; }
		public float BurstCameraFollowSpeed { get; }
		public int DashSkill { get; }
		public float AiBurstProbabilityOD { get; }
		public float AiBurstProbabilityBarrier { get; }
		public float AiBurstProbabilityEnhanced { get; }
	
		// Constructors
		public WeaponTypeElement();
	}
}
