/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class PlayerActionElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _ActionName;
		[SerializeField]
		private float _Range;
		[SerializeField]
		private int _CanTurnPrepare;
		[SerializeField]
		private int _IsDragonAttack;
		[SerializeField]
		private int _IsDefaultSkill;
		[SerializeField]
		private int _IsChargeSkill;
		[SerializeField]
		private int _IsHeroSkill;
		[SerializeField]
		private int _HealType;
		[SerializeField]
		private int _MaxStockBullet;
		[SerializeField]
		private int _NextAction;
		[SerializeField]
		private int _CastingAction;
		[SerializeField]
		private int _IsNextActionShiftByInput;
		[SerializeField]
		private int _MinAdditionalInputNumForNextActionShift;
		[SerializeField]
		private int _IsLoopAction;
		[SerializeField]
		private int _NotMoveToNextActionImmediately;
		[SerializeField]
		private int _IsCounterAction;
		[SerializeField]
		private int _MaxAdditionalInput;
		[SerializeField]
		private int _InputUIType;
		[SerializeField]
		private int _IsAllyTarget;
		[SerializeField]
		private int _BurstInputType;
		[SerializeField]
		private int _BurstMarkerId;
		[SerializeField]
		private int _EnhancedBurstAttackOffsetFlag;
		[SerializeField]
		private int _EnhancedBurstAttackAnimationType;
		[SerializeField]
		private int _IsLongRangeCamera;
		[SerializeField]
		private int _IgnoreLongRangeCamera;
		[SerializeField]
		private string _OverwriteVoice;
		[SerializeField]
		private int _ConsumeEp;
		[SerializeField]
		private float _ChargeMoveSpeedFactor;
		[SerializeField]
		private int _ChargeType;
		[SerializeField]
		private int _OnHitExecType;
		[SerializeField]
		private int _BuffConsumptionType;
		[SerializeField]
		private int _ConnectCombo;
	
		// Properties
		public int Id { get; }
		public string ActionName { get; }
		public float Range { get; }
		public int CanTurnPrepare { get; }
		public int IsDragonAttack { get; }
		public int IsDefaultSkill { get; }
		public int IsChargeSkill { get; }
		public int IsHeroSkill { get; }
		public int HealType { get; }
		public int MaxStockBullet { get; }
		public int NextAction { get; }
		public int CastingAction { get; }
		public int IsNextActionShiftByInput { get; }
		public int MinAdditionalInputNumForNextActionShift { get; }
		public int IsLoopAction { get; }
		public int NotMoveToNextActionImmediately { get; }
		public int IsCounterAction { get; }
		public int MaxAdditionalInput { get; }
		public int InputUIType { get; }
		public int IsAllyTarget { get; }
		public int BurstInputType { get; }
		public int BurstMarkerId { get; }
		public int EnhancedBurstAttackOffsetFlag { get; }
		public int EnhancedBurstAttackAnimationType { get; }
		public int IsLongRangeCamera { get; }
		public int IgnoreLongRangeCamera { get; }
		public string OverwriteVoice { get; }
		public int ConsumeEp { get; }
		public float ChargeMoveSpeedFactor { get; }
		public int ChargeType { get; }
		public int OnHitExecType { get; }
		public int BuffConsumptionType { get; }
		public int ConnectCombo { get; }
	
		// Constructors
		public PlayerActionElement();
	}
}
