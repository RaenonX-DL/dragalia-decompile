/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerCtrl : CommonObjectStatus
	{
		// Fields
		public float speed;
		public TargetInfo targetInfo;
		private PlayerFootMark.Type playerMarkerType;
		private StateMachine<PlayerCtrl> stateMachine;
		[CompilerGenerated]
		private CharacterSelector _selector_k__BackingField;
		[CompilerGenerated]
		private bool __enableInput_k__BackingField;
		[CompilerGenerated]
		private float _charaChangeEffectWaitTime_k__BackingField;
		[CompilerGenerated]
		private bool _forceCharacterChangeForDoll_k__BackingField;
		[CompilerGenerated]
		private bool _enableTransformDragon_k__BackingField;
		[CompilerGenerated]
		private bool _isGuardStartRequest_k__BackingField;
		[CompilerGenerated]
		private bool _isGuardEndRequest_k__BackingField;
		private bool _isHideMarker;
		public const string dragonTransformAuraEffectName = "EFF_CMN_TRA_021";
		private const int dragonTransformAuraGroup = 2;
		private Vector3 safePos;
		private float checkGroundTimer;
	
		// Properties
		public CommonObjectStatus target { get; }
		public PlayerCharacter character { get; }
		public CharacterSelector selector { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private bool _enableInput { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool enableInput { get; set; }
		public float charaChangeEffectWaitTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool forceCharacterChangeForDoll { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool enableTransformDragon { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isGuardStartRequest { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isGuardEndRequest { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isHideMarker { get; set; }
	
		// Nested types
		public struct TargetInfo
		{
			// Fields
			public CommonObjectStatus target;
			public CharacterBase enemy;
			public DungeonObjectBase dungonObject;
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<EnemyManage.EnemyInfo> __9__75_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _FindPriorityTarget_b__75_0(EnemyManage.EnemyInfo d);
		}
	
		// Constructors
		public PlayerCtrl();
	
		// Methods
		protected override void OnDestroy();
		public void Initialize();
		private void InitializeState();
		public override void FastUpdate();
		public void UpdateRotation(float x, float y);
		public Vector3 GetForward(float x, float y);
		public Vector3 GetNormalizedProjectDirection(Vector3 inputDir);
		public Vector3 GetProjectDirection(Vector3 inputDir);
		public void UpdateMove(float speed);
		public void UpdateSkillMove(float speed);
		public void UpdateSkillMoveCasting(float speed, Vector3 forward);
		private void UpdateMarker();
		private void HideMarker();
		private bool CheckBattleMarker(PlayerFootMark.Type markerType);
		private bool IsMoveMarkerCondition();
		private void CheckFinishDragon();
		public void CheckDragonTransformEffect(int trigger);
		public static void CheckDragonTransformEffectCore(CharacterSelector selector, PlayerCharacter character, bool isEnableTransform, bool isEnableAction, int trigger);
		private void UpdateAnimationSpeed();
		private void UpdateCharacterChangeEffectWaitTime();
		public bool SetActionSkill(int idx);
		public bool SetActionSkill(int idx, int actionId);
		public void SkillProduction(SkillDataElement sde, int idx);
		public void RequestGuardStart();
		public void RequestGuardEnd();
		public void SetStateIdle(bool checkSame = false);
		private void UpdateTarget();
		private bool FindPriorityTarget();
		private float FindEnemyTarget(float inRange, float outRange, ref float minAngle);
		private void CheckTargetEnemy(CharacterBase enemy, Vector3 forward, float searchAngle, ref float minAngle, float inRange, float absoluteRange, ref float minDistance);
		private bool CanSetTargetCondition(CharacterBase enemy);
		private void FindDungeonObjectTarget(float sqrCheckDistance, float minAngle);
		public void SetTargetEnemy(CharacterBase enemy);
		private void SetTargetObject(DungeonObjectBase dobj);
		public float GetTargetSqrDistance(Vector3 dir, float radius);
		public bool IsEnableTargetChange();
		public bool IsInputMove(out Vector2 dir);
		public bool IsInputQuickTurn();
		public bool IsInputQuickRightTurn();
		public bool IsInputQuickLeftTurn();
		public bool IsInputAvoid(out Vector2 dir);
		public bool IsInputAttack();
		public bool IsInputCharge(out Vector2 dir);
		public bool IsInputBurstAttack();
		private void ForceInputBurst();
		public void InputBurstForTimeStop();
		public void CancelInputCharge();
		public bool IsBurstAttackInputTypeHoldDown();
		public bool IsEnableAction();
		public bool IsDashAction();
		public bool IsBurstAttackAction();
		public float GetBurstCameraFollowSpeed();
		public bool IsLongRangeWeaponType(bool onlyUseWeaponType);
		public bool IsLongRangeAttackAction();
		public bool IsKeepZoomAction();
		public CommonObjectStatus GetSkillTarget();
		public List<CharacterBase> GetSkillMultiBulletTargets();
		public bool StartTransform();
		public bool StartDragonTransform();
		public void TransformDragon();
		public bool IsTransformDragonProduction();
		private bool StartUniqueTransform();
		public void TransformUnique();
		public void ReleaseTransform();
		public bool CheckCharacterState();
		private void OnBlastSp();
		public void OnPause();
		public bool IsOfficialAutoPlayMode();
		public bool IsDpsCheckAiMode();
		public static bool IsAutoPlayTargetableObject(DungeonObjectBase dobj);
		public bool PlaySupportSkill();
		public void CheckGround();
		public int GetBRWeaponLevel();
		public int GetBRWeaponGlowItemNum();
		public int GetBRWeaponGlowItemNextNum(int level);
		public int GetBRKillCount();
	}
}
