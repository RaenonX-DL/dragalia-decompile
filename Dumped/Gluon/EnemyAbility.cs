using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbility
	{
		public struct Argument
		{
			public int argInt01;

			public float argFloat01;

			public float argFloat02;

			public string argString01;

			public CharacterBase argChara01;
		}

		private List<EnemyAbilityProcBase> _abilities;

		private EnemyCharacter _owner;

		private bool _isWaitInitState;

		private bool _isDoneInitState;

		public const int PLAY_EFF_TRIG = 8;

		public const int HIDE_EFF_TRIG = 13;

		private const float VODING_SE_WAIT_TIME = 1f;

		private float _voidingSeTime;

		public List<EnemyAbilityProcBase> abilities => null;

		public bool isExistBerserkAbility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EnemyAbility(EnemyCharacter owner)
		{
		}

		private EnemyAbilityProcBase Create(int id)
		{
			return null;
		}

		private EnemyAbilityProcBase CreateBerserk(int id)
		{
			return null;
		}

		private void Reset()
		{
		}

		public bool IsActive(int abilityId)
		{
			return default(bool);
		}

		public bool IsActive(EnemyAbilityType type)
		{
			return default(bool);
		}

		public bool IsActiveBerserk()
		{
			return default(bool);
		}

		public EnemyAbilityProcBase GetAbility(int abilityId)
		{
			return null;
		}

		public EnemyAbilityProcBase GetAbility(EnemyAbilityType type)
		{
			return null;
		}

		public int GetAbilityId(EnemyAbilityType type)
		{
			return default(int);
		}

		public bool HasAbility(EnemyAbilityType type)
		{
			return default(bool);
		}

		public void HideEffect()
		{
		}

		public void RestoreEffect()
		{
		}

		public void PlayVoidingSe()
		{
		}

		public void OnUpdate()
		{
		}

		public void OnCharacterInit()
		{
		}

		public void OnCharacterEntry()
		{
		}

		public void OnCharacterRevive()
		{
		}

		public void OnCharacterDead()
		{
		}

		public void OnCharacterLeave()
		{
		}

		public void OnDeadParts(EnemyCharacter parts)
		{
		}

		public void OnCollideOffense(CharacterBase receiver, CollisionHitAttribute hitAttr, bool isFollowerAvoid)
		{
		}

		public void OnCollideReceive(CollisionHitAttribute attr, int damage)
		{
		}

		public void OnCalcBaseDamageAttack(CharacterBase receiver, ref Argument arg)
		{
		}

		public void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref Argument arg)
		{
		}

		public void OnApplyDamage(CharacterDamageIntermediate damageData, bool alive)
		{
		}

		public void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref Argument arg)
		{
		}

		public void OnApplySlipDamage(ref Argument arg, int damage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType)
		{
		}

		public void OnApplyDebuffExtraDamage(ref Argument arg)
		{
		}

		public void OnBuildDamage(ref Argument arg)
		{
		}

		public void OnCheckDamageReaction(bool isBarrierBroken, ref Argument arg)
		{
		}

		public void OnActionParts(int abilityId, bool onoff = true)
		{
		}

		public void OnOverdrive(ref Argument arg)
		{
		}

		public void OnOverdriveDamage(CollisionHitAttribute hitAttr, float od_rate, ref Argument arg)
		{
		}

		public void OnBreak()
		{
		}

		public void OnBreakRemotely()
		{
		}

		public void OnBreakFinish()
		{
		}

		public void OnCalcDefCoefForMirage(CharacterBase attacker, ref Argument arg)
		{
		}

		public void OnExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Argument arg)
		{
		}

		public void OnCalcModeDifense(CharacterBase attacker, ref Argument arg)
		{
		}

		public void OnDrain(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Argument arg)
		{
		}

		public void OnPostDrain()
		{
		}

		public void OnStartBarrier(ref Argument arg)
		{
		}

		public void OnHitBarrier(CharacterBase attacker, ref Argument arg)
		{
		}

		public void OnApplyReduceHp(ref Argument arg)
		{
		}

		public void OnFatalAttack(ref Argument arg)
		{
		}

		public void OnStateEnter_ShapeShift()
		{
		}

		public void OnShiftIntoForm2nd()
		{
		}

		public void OnShiftIntoOriginal()
		{
		}

		public void OnApplyBuffDebuff(ref Argument arg)
		{
		}

		public void OnApplyBuffDebuffVarious(CharacterBuffType buffType, bool isBuff, CharacterBase from, ref Argument arg)
		{
		}

		public void OnPlayEffectBuff(ref Argument arg)
		{
		}

		public void OnStopEffectBuff(CharacterBuff buff)
		{
		}

		public void OnDispTextBuff(ref Argument arg)
		{
		}

		public void OnStopBuffField(List<CharacterBase> outCharaList, ref Argument arg)
		{
		}

		public void OnDispel(ref Argument arg)
		{
		}

		public void OnAbnormalStatusProbability(int type, float probability, ref Argument arg)
		{
		}

		public void OnBeforeSetAbnormal(CollisionHitAttribute attr, int conditionId, ref Argument arg)
		{
		}

		public void OnSetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability)
		{
		}

		public void OnAbnormalClearType(AbnormalStatusType type, ref Argument arg)
		{
		}

		public void OnWeakPointDestroy(bool isPlayAction = true)
		{
		}

		public void OnWeakPointDefeated(bool isPlayAction = true)
		{
		}

		public void OnSwitchElement()
		{
		}

		public void OnChangeRoomGroup(CharacterBase target)
		{
		}

		public void OnDisconnectUser(int disconnectActorId)
		{
		}

		public void OnRecieveCharacterState(CharacterState recvEvent)
		{
		}

		public void OnRecieveEnemyDead(DeadReason reason, float prevHpRate)
		{
		}
	}
}
