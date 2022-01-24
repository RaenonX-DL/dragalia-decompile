using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class PlayerActionElement : IMasterElement
	{
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
		private int _AdditionalInputActionConditionId;

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

		[SerializeField]
		private int _DisableAverageHitAttributeDependentCoef;

		public int Id => default(int);

		public string ActionName => null;

		public float Range => default(float);

		public int CanTurnPrepare => default(int);

		public int IsDragonAttack => default(int);

		public int IsDefaultSkill => default(int);

		public int IsChargeSkill => default(int);

		public int IsHeroSkill => default(int);

		public int HealType => default(int);

		public int MaxStockBullet => default(int);

		public int NextAction => default(int);

		public int CastingAction => default(int);

		public int IsNextActionShiftByInput => default(int);

		public int MinAdditionalInputNumForNextActionShift => default(int);

		public int IsLoopAction => default(int);

		public int NotMoveToNextActionImmediately => default(int);

		public int IsCounterAction => default(int);

		public int MaxAdditionalInput => default(int);

		public int AdditionalInputActionConditionId => default(int);

		public int InputUIType => default(int);

		public int IsAllyTarget => default(int);

		public int BurstInputType => default(int);

		public int BurstMarkerId => default(int);

		public int EnhancedBurstAttackOffsetFlag => default(int);

		public int EnhancedBurstAttackAnimationType => default(int);

		public int IsLongRangeCamera => default(int);

		public int IgnoreLongRangeCamera => default(int);

		public string OverwriteVoice => null;

		public int ConsumeEp => default(int);

		public float ChargeMoveSpeedFactor => default(float);

		public int ChargeType => default(int);

		public int OnHitExecType => default(int);

		public int BuffConsumptionType => default(int);

		public int ConnectCombo => default(int);

		public int DisableAverageHitAttributeDependentCoef => default(int);
	}
}
