/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerController : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private static bool _forceIdleMode_k__BackingField;
		[CompilerGenerated]
		private Vector3 _followPosition_k__BackingField;
		[CompilerGenerated]
		private CharacterSelector _selector_k__BackingField;
		private StateMachine<FollowerController> stateMachine;
		private const float MAX_DISTANCE_FROM_PLAYER = 20f;
		private const float MAX_DISTANCE_TARGET_ENEMY = 20f;
		public const float POPED_ENEMY_DETECTING_TIME = 1f;
		[CompilerGenerated]
		private AIType _aiType_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _targetEnemy_k__BackingField;
		private bool isEnabledNavMeshBeforeTimeStop;
		private bool navMeshCtrlFlagForTimeStop;
	
		// Properties
		public static bool forceIdleMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public PlayerCharacter character { get; }
		public Vector3 followPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterSelector selector { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AIType aiType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterBase targetEnemy { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum AIType
		{
			Normal = 0,
			Healer = 1,
			Leif = 2
		}
	
		// Constructors
		public FollowerController();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public void Initialize();
		private void InitializeState();
		public override void FastUpdate();
		public bool CheckCharacterState();
		public bool CheckTransform();
		public bool CheckAttack();
		public static bool CheckCharge(CharacterSelector selector, CharacterBase target, float probabilityCoef = 1f, bool force = false);
		public bool CheckSkill(bool needsCheckRangeHeal = true);
		public static bool CheckSkillForDisableMove(CharacterBase chara, int skillIndex, int actionId, EnemyCharacter enemy, out bool isContinue, out bool checkEnemy);
		private bool CheckSkillForRockman();
		public CharacterBase CheckHealSkill(int checkHealType = 1);
		public CharacterBase CheckRangeHealSkill();
		public static CharacterBase SelectHealTarget(CharacterSelector selector, int actionId, int healType);
		public bool CheckPlayerTarget();
		public void EnableNavMeshAgent(bool enable);
		public void SetIsEnabledNavMeshBeforeTimeStop();
		public void ApplyIsEnabledNavMeshBeforeTimeStop();
		public CharacterBase GetTargetEnemy();
		private bool IsNotTargetedEnemy(CharacterBase chara);
		private bool IsState(Type type);
		public bool IsRestState();
		public bool IsAvoidState();
		public bool CheckMarker(bool checkAction = true);
		public static bool IsInsideMarker(Vector3 pos, float radius, ref ChargeMarker retMarker, CharacterBase targetChara);
		public static Vector3 GetEscapeMarkerPosition(ChargeMarker marker, CharacterBase chara, Vector3 destination);
		private void SetPos(Vector3 value);
		private void CheckFinishDragon();
		private void CheckDistanceFromPlayer();
		private float GetTargetDistance(CharacterBase target);
		public bool IsBurstAttackRange(CharacterBase target);
		private void UpdateSkillLinkInvincbleTime();
		public bool IsGuestCharacter();
		public bool IsNotTargetEnemyAbilityActive(CharacterBase targetEnemy);
		public Type GetNextStateType();
		public static bool CheckChangeMode(PlayerCharacter playerChara);
		public bool CheckDisableMove();
		public void SetRest();
		public CharacterBase GetTargetForBR();
		private bool CanReachPosForBR(Vector3 targetPos);
	}
}
