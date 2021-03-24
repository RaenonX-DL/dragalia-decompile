/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateBase : IState<Gluon.PlayerCtrl>
	{
		// Fields
		private NavMeshPath checkPath;
		[CompilerGenerated]
		private int _currentCombo_k__BackingField;
		[CompilerGenerated]
		private bool _ignoreDownRecovery_k__BackingField;
		[CompilerGenerated]
		private bool _isExceededThreshold_k__BackingField;
	
		// Properties
		protected int currentCombo { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected bool ignoreDownRecovery { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected bool isExceededThreshold { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PlayerStateBase();
	
		// Methods
		protected virtual bool NeedsUpdateLastWakeOnCollidedTime();
		public override void OnStateEnter();
		public override void OnStateUpdate();
		public override void OnStateExit();
		protected virtual bool IsOperateState();
		protected virtual bool CheckMove();
		protected bool CheckQuickMove();
		protected void Move(bool forceDash = false);
		protected bool CheckQuickTurn();
		protected bool CheckAvoid();
		protected virtual bool CheckAttack(bool ignoreInput = false, Action onReservedNextAttackAction = null);
		protected void ReserveNextAttack(bool ignoreInput, Action onReservedNextAttackAction);
		protected virtual bool CheckCharge();
		protected virtual bool CheckGuard();
		protected bool CheckAutoPlayMode(bool enableMove, bool checkBurst, bool checkEscapeMarker = true);
		protected void ClearReserveActionAndSetStateIdle();
		private bool CheckAutoPlayAttack(bool checkBurst);
		private bool CheckSkillForRockman();
		protected bool CheckAutoPlayBurst(float probabilityCoef = 1f);
		protected bool IsAttackRangeForAuto(int actionId);
		protected void UpdateChargeDirection(bool enableMove, bool isAttack);
		private void UpdateChargeDirectionForTypePull(Vector2 dir);
		private void UpdateChargeDirectionForTypeMove(Vector2 dir, bool isAttack);
		protected bool CheckAutoPlayMarker(bool checkAction);
		protected bool UpdateMoveForOfficialAutoPlayMode(float speed);
		private bool GetNearestObjectForAutoPlayMode(Vector3 position, bool checkActive, bool checkReachEnemy, out bool cantReachEnemy, out Vector3 retTargetPos, out bool retIgnoreHeight);
		private bool GetNearestDropItemBoxForAutoPlayMode(Vector3 position, out Vector3 retTargetPos);
		private bool CanReachPos(Vector3 targetPos, bool ignoreHeight = false);
	}
}
