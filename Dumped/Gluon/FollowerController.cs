using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.AI;

namespace Gluon
{
	public class FollowerController : FastUpdateMonoBehaviour
	{
		public enum AIType
		{
			Normal,
			Healer,
			Leif
		}

		private StateMachine<FollowerController> stateMachine;

		private const float MAX_DISTANCE_FROM_PLAYER = 20f;

		private const float MAX_DISTANCE_TARGET_ENEMY = 20f;

		public const float POPED_ENEMY_DETECTING_TIME = 1f;

		private bool isEnabledNavMeshBeforeTimeStop;

		private bool navMeshCtrlFlagForTimeStop;

		private NavMeshPath checkPath;

		public static bool forceIdleMode
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

		public static bool setTargetToPlayerTarget
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

		public PlayerCharacter character => null;

		public Vector3 followPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

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

		public AIType aiType
		{
			[CompilerGenerated]
			get
			{
				return default(AIType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterBase targetEnemy
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

		private void Awake()
		{
		}

		private void OnDestroy()
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

		public bool CheckCharacterState()
		{
			return default(bool);
		}

		public void SetStateIdle(bool immediate = false)
		{
		}

		public bool CheckTransform()
		{
			return default(bool);
		}

		public bool CheckAttack()
		{
			return default(bool);
		}

		public static bool CheckCharge(CharacterSelector selector, CharacterBase target, float probabilityCoef = 1f, bool force = false)
		{
			return default(bool);
		}

		public bool CheckSkill(bool needsCheckRangeHeal = true)
		{
			return default(bool);
		}

		public static bool CheckSkillForDisableMove(CharacterBase chara, int skillIndex, int actionId, EnemyCharacter enemy, out bool isContinue, out bool checkEnemy)
		{
			return default(bool);
		}

		private bool CheckSkillForRockman()
		{
			return default(bool);
		}

		public CharacterBase CheckHealSkill(int checkHealType = 1)
		{
			return null;
		}

		public CharacterBase CheckRangeHealSkill()
		{
			return null;
		}

		public CharacterBase CheckReviveSkill()
		{
			return null;
		}

		public static CharacterBase SelectHealTarget(CharacterSelector selector, int actionId, int healType)
		{
			return null;
		}

		public bool CheckPlayerTarget()
		{
			return default(bool);
		}

		public void EnableNavMeshAgent(bool enable)
		{
		}

		public void SetIsEnabledNavMeshBeforeTimeStop()
		{
		}

		public void ApplyIsEnabledNavMeshBeforeTimeStop()
		{
		}

		public CharacterBase GetTargetEnemy()
		{
			return null;
		}

		private bool IsNotTargetedEnemy(CharacterBase chara)
		{
			return default(bool);
		}

		private bool IsState(Type type)
		{
			return default(bool);
		}

		private bool IsIdleState()
		{
			return default(bool);
		}

		public bool IsRestState()
		{
			return default(bool);
		}

		public bool IsAvoidState()
		{
			return default(bool);
		}

		public bool CheckMarker(bool checkAction = true)
		{
			return default(bool);
		}

		public static bool IsInsideMarker(Vector3 pos, float radius, ref ChargeMarker retMarker, CharacterBase targetChara)
		{
			return default(bool);
		}

		public static Vector3 GetEscapeMarkerPosition(ChargeMarker marker, CharacterBase chara, Vector3 destination)
		{
			return default(Vector3);
		}

		private void SetPos(Vector3 value)
		{
		}

		public void CheckFinishDragon()
		{
		}

		private void CheckDistanceFromPlayer()
		{
		}

		private float GetTargetDistance(CharacterBase target)
		{
			return default(float);
		}

		public bool IsBurstAttackRange(CharacterBase target)
		{
			return default(bool);
		}

		private bool IsServantAI(DragonCharacter.ServantAIType aiType)
		{
			return default(bool);
		}

		private void UpdateServantAction()
		{
		}

		private void UpdateSkillLinkInvincbleTime()
		{
		}

		public bool IsGuestCharacter()
		{
			return default(bool);
		}

		public bool IsNotTargetEnemyAbilityActive(CharacterBase targetEnemy)
		{
			return default(bool);
		}

		public Type GetNextStateType()
		{
			return null;
		}

		public static bool CheckChangeMode(PlayerCharacter playerChara)
		{
			return default(bool);
		}

		public bool CheckDisableMove()
		{
			return default(bool);
		}

		public void SetRest()
		{
		}

		public bool CanReachPos(Vector3 targetPos, bool ignoreHeight = false)
		{
			return default(bool);
		}

		public CharacterBase GetTargetForBR()
		{
			return null;
		}

		private bool CanReachPosForBR(Vector3 targetPos)
		{
			return default(bool);
		}
	}
}
