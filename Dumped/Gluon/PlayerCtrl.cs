using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class PlayerCtrl : CommonObjectStatus
	{
		public struct TargetInfo
		{
			public CommonObjectStatus target;

			public CharacterBase enemy;

			public DungeonObjectBase dungonObject;
		}

		public float speed;

		public TargetInfo targetInfo;

		private PlayerFootMark.Type playerMarkerType;

		private StateMachine<PlayerCtrl> stateMachine;

		private bool _isHideMarker;

		public const string dragonTransformAuraEffectName = "EFF_CMN_TRA_021";

		private const int dragonTransformAuraGroup = 2;

		private Vector3 safePos;

		private float checkGroundTimer;

		private NotifyCharacter.SkillCutInParam _skillCutInParam;

		public CommonObjectStatus target => null;

		public PlayerCharacter character => null;

		public CharacterSelector selector
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private bool _enableInput
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

		public bool enableInput
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float charaChangeEffectWaitTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool forceCharacterChangeForDoll
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

		public bool enableTransformDragon
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

		public bool isGuardStartRequest
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

		public bool isGuardEndRequest
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

		public bool isHideMarker
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected override void OnDestroy()
		{
		}

		public void Initialize()
		{
		}

		private void InitializeState()
		{
		}

		public override void FastUpdate()
		{
		}

		public void UpdateRotation(float x, float y)
		{
		}

		public Vector3 GetForward(float x, float y)
		{
			return default(Vector3);
		}

		public Vector3 GetNormalizedProjectDirection(Vector3 inputDir)
		{
			return default(Vector3);
		}

		public Vector3 GetProjectDirection(Vector3 inputDir)
		{
			return default(Vector3);
		}

		public void UpdateMove(float speed)
		{
		}

		public void UpdateMoveWhileLookingAtTarget(Vector2 dir, float speed)
		{
		}

		public void UpdateSkillMove(float speed)
		{
		}

		public void UpdateSkillMoveCasting(float speed, Vector3 forward)
		{
		}

		private void UpdateMarker()
		{
		}

		private void HideMarker()
		{
		}

		private bool CheckBattleMarker(PlayerFootMark.Type markerType)
		{
			return default(bool);
		}

		private bool IsMoveMarkerCondition()
		{
			return default(bool);
		}

		private void CheckFinishDragon()
		{
		}

		public void CheckDragonTransformEffect(int trigger)
		{
		}

		public static void CheckDragonTransformEffectCore(CharacterSelector selector, PlayerCharacter character, bool isEnableTransform, bool isEnableAction, int trigger)
		{
		}

		private void UpdateAnimationSpeed()
		{
		}

		private void UpdateCharacterChangeEffectWaitTime()
		{
		}

		public bool SetActionSkill(int idx)
		{
			return default(bool);
		}

		public bool SetActionSkill(int idx, int actionId)
		{
			return default(bool);
		}

		public void SkillProduction(SkillDataElement sde, int idx)
		{
		}

		public void RequestGuardStart()
		{
		}

		public void RequestGuardEnd()
		{
		}

		public void SetStateIdle(bool checkSame = false)
		{
		}

		public void UpdateTarget()
		{
		}

		private bool FindPriorityTarget()
		{
			return default(bool);
		}

		private float FindEnemyTarget(float inRange, float outRange, ref float minAngle)
		{
			return default(float);
		}

		private void CheckTargetEnemy(CharacterBase enemy, Vector3 forward, float searchAngle, ref float minAngle, float inRange, float absoluteRange, ref float minDistance)
		{
		}

		private bool CanSetTargetCondition(CharacterBase enemy)
		{
			return default(bool);
		}

		private void FindDungeonObjectTarget(float sqrCheckDistance, float minAngle)
		{
		}

		public void SetTargetEnemy(CharacterBase enemy)
		{
		}

		private void SetTargetObject(DungeonObjectBase dobj)
		{
		}

		public float GetTargetSqrDistance(Vector3 dir, float radius)
		{
			return default(float);
		}

		public bool IsEnableTargetChange()
		{
			return default(bool);
		}

		public bool IsInputMove(out Vector2 dir)
		{
			return default(bool);
		}

		public bool IsInputQuickTurn()
		{
			return default(bool);
		}

		public bool IsInputQuickRightTurn()
		{
			return default(bool);
		}

		public bool IsInputQuickLeftTurn()
		{
			return default(bool);
		}

		public bool IsInputAvoid(out Vector2 dir)
		{
			return default(bool);
		}

		public bool IsInputAttack()
		{
			return default(bool);
		}

		public bool IsInputCharge(out Vector2 dir)
		{
			return default(bool);
		}

		public bool IsInputBurstAttack()
		{
			return default(bool);
		}

		private void ForceInputBurst()
		{
		}

		public void InputBurstForTimeStop()
		{
		}

		public void CancelInputCharge()
		{
		}

		public bool IsBurstAttackInputTypeHoldDown()
		{
			return default(bool);
		}

		public bool IsEnableAction()
		{
			return default(bool);
		}

		public bool IsDashAction()
		{
			return default(bool);
		}

		public bool IsBurstAttackAction()
		{
			return default(bool);
		}

		public float GetBurstCameraFollowSpeed()
		{
			return default(float);
		}

		public bool IsLongRangeWeaponType(bool onlyUseWeaponType)
		{
			return default(bool);
		}

		public bool IsLongRangeAttackAction()
		{
			return default(bool);
		}

		public bool IsKeepZoomAction()
		{
			return default(bool);
		}

		public CommonObjectStatus GetSkillTarget()
		{
			return null;
		}

		public List<CharacterBase> GetSkillMultiBulletTargets()
		{
			return null;
		}

		public bool StartTransform()
		{
			return default(bool);
		}

		public bool StartDragonTransform()
		{
			return default(bool);
		}

		public void TransformDragon()
		{
		}

		public bool IsTransformDragonProduction()
		{
			return default(bool);
		}

		private bool StartUniqueTransform()
		{
			return default(bool);
		}

		public void TransformUnique()
		{
		}

		public void TransformServant()
		{
		}

		public void ReleaseTransform(bool isCancel)
		{
		}

		public bool CheckCharacterState()
		{
			return default(bool);
		}

		private void OnBlastSp()
		{
		}

		public void OnPause()
		{
		}

		public bool IsOfficialAutoPlayMode()
		{
			return default(bool);
		}

		public bool IsDpsCheckAiMode()
		{
			return default(bool);
		}

		public static bool IsAutoPlayTargetableObject(DungeonObjectBase dobj)
		{
			return default(bool);
		}

		public bool PlaySupportSkill()
		{
			return default(bool);
		}

		public void CheckGround()
		{
		}

		public int GetBRWeaponLevel()
		{
			return default(int);
		}

		public int GetBRWeaponGlowItemNum()
		{
			return default(int);
		}

		public int GetBRWeaponGlowItemNextNum(int level)
		{
			return default(int);
		}

		public int GetBRKillCount()
		{
			return default(int);
		}
	}
}
