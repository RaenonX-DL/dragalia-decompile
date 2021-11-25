using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;

namespace Gluon
{
	public class PlayerStateBase : IState<PlayerCtrl>
	{
		private NavMeshPath checkPath;

		protected int currentCombo
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool ignoreDownRecovery
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool isExceededThreshold
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected virtual bool NeedsUpdateLastWakeOnCollidedTime()
		{
			return default(bool);
		}

		public override void OnStateEnter()
		{
		}

		public override void OnStateUpdate()
		{
		}

		public override void OnStateExit()
		{
		}

		protected virtual bool IsOperateState()
		{
			return default(bool);
		}

		protected virtual bool CheckMove()
		{
			return default(bool);
		}

		protected bool CheckQuickMove()
		{
			return default(bool);
		}

		protected void Move(bool forceDash = false)
		{
		}

		protected bool CheckQuickTurn()
		{
			return default(bool);
		}

		protected bool CheckAvoid()
		{
			return default(bool);
		}

		protected virtual bool CheckAttack(bool ignoreInput = false, [Optional] Action onReservedNextAttackAction)
		{
			return default(bool);
		}

		protected void ReserveNextAttack(bool ignoreInput, Action onReservedNextAttackAction)
		{
		}

		protected virtual bool CheckCharge()
		{
			return default(bool);
		}

		protected virtual bool CheckGuard()
		{
			return default(bool);
		}

		protected bool CheckAutoPlayMode(bool enableMove, bool checkBurst, bool checkEscapeMarker = true)
		{
			return default(bool);
		}

		protected void ClearReserveActionAndSetStateIdle()
		{
		}

		private bool CheckAutoPlayAttack(bool checkBurst)
		{
			return default(bool);
		}

		private bool CheckSkillForRockman()
		{
			return default(bool);
		}

		protected bool CheckAutoPlayBurst(float probabilityCoef = 1f)
		{
			return default(bool);
		}

		protected bool IsAttackRangeForAuto(int actionId)
		{
			return default(bool);
		}

		protected void UpdateChargeDirection(bool enableMove, bool isAttack)
		{
		}

		private void UpdateChargeDirectionForTypePull(Vector2 dir)
		{
		}

		private void UpdateChargeDirectionForTypeMove(Vector2 dir, bool isAttack)
		{
		}

		protected bool CheckAutoPlayMarker(bool checkAction)
		{
			return default(bool);
		}

		protected bool UpdateMoveForOfficialAutoPlayMode(float speed)
		{
			return default(bool);
		}

		private bool GetNearestObjectForAutoPlayMode(Vector3 position, bool checkActive, bool checkReachEnemy, out bool cantReachEnemy, out Vector3 retTargetPos, out bool retIgnoreHeight)
		{
			return default(bool);
		}

		private bool GetNearestDropItemBoxForAutoPlayMode(Vector3 position, out Vector3 retTargetPos)
		{
			return default(bool);
		}

		private bool CanReachPos(Vector3 targetPos, bool ignoreHeight = false)
		{
			return default(bool);
		}
	}
}
