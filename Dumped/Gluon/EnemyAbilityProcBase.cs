using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityProcBase
	{
		protected Color RESIST_FONT_COLOR;

		private Gluon.Event.EnemyAbility _tempSendEvent;

		protected EnemyAbility enemyability
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

		protected EnemyCharacter owner
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

		protected EnemyAbilityElement data
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

		public int id => default(int);

		public string name => null;

		public EnemyAbilityType type => default(EnemyAbilityType);

		public string iconId => null;

		public virtual string effKey => null;

		public bool isActive
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

		public virtual bool isBerserk => default(bool);

		public EnemyAbilityProcBase(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public virtual void Setup()
		{
		}

		public virtual void Play()
		{
		}

		public virtual void Stop()
		{
		}

		public virtual void Show()
		{
		}

		public virtual void Hide()
		{
		}

		public virtual void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND)
		{
		}

		public void KickEffectTrigger(int trig)
		{
		}

		protected bool CheckKiller(CharacterBase character)
		{
			return default(bool);
		}

		public virtual void OnEntry()
		{
		}

		public virtual void OnRevive()
		{
		}

		public virtual void OnCharacterDead()
		{
		}

		public virtual void OnCharacterLeave()
		{
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr)
		{
		}

		public virtual void OnFollowerAvoid(CharacterBase receiver)
		{
		}

		public virtual void OnDamage(CollisionHitAttribute attr, int damage)
		{
		}

		public virtual void OnCalcBaseDamageAttack(CharacterBase receiver, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnBuildDamage(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnCheckDamageReaction(bool isBarrierBroken, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnOverdrive(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnOverdriveDamage(CollisionHitAttribute hitAttr, float od_rate, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnBreak()
		{
		}

		public virtual void OnBreakRemotely()
		{
		}

		public virtual void OnBreakFinish()
		{
		}

		public virtual void OnActionParts(bool onoff)
		{
		}

		public virtual void OnCalcDefCoefForMirage(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnCalcModeDifense(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnDrain(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnPostDrain()
		{
		}

		public virtual void OnStartBarrier(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnHitBarrier(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnApplyDamage(CharacterDamageIntermediate damageData, bool alive)
		{
		}

		public virtual void OnApplySlipDamage(ref EnemyAbility.Argument arg, int damage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType)
		{
		}

		public virtual void OnApplyDebuffExtraDamage(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnApplyReduceHp(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnFatalAttack(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnStateEnter_ShapeShift()
		{
		}

		public virtual void OnShiftIntoForm2nd()
		{
		}

		public virtual void OnShiftIntoOriginal()
		{
		}

		public virtual void OnDeadParts(EnemyCharacter parts)
		{
		}

		public virtual void OnApplyBuffDebuff(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnApplyBuffDebuffVarious(CharacterBuffType buffType, bool isBuff, CharacterBase from, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnPlayEffectBuff(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnStopEffectBuff(CharacterBuff buff)
		{
		}

		public virtual void OnDispTextBuff(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnStopBuffField(List<CharacterBase> outCharaList, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnDispel(ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnAbnormalStatusProbability(int type, float probability, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnBeforeSetAbnormal(CollisionHitAttribute attr, int conditionId, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnSetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability)
		{
		}

		public virtual void OnAbnormalClearType(AbnormalStatusType type, ref EnemyAbility.Argument arg)
		{
		}

		public virtual void OnWeakPointDestroy(bool isPlayAction)
		{
		}

		public virtual void OnWeakPointDefeated(bool isPlayAction)
		{
		}

		public virtual void OnSwitchElement()
		{
		}

		public virtual void OnChangeRoomGroup(CharacterBase target)
		{
		}

		public virtual void OnDisconnectUser(int disconnectActorId)
		{
		}

		public virtual bool CanReceiveEnemyAbilityEvent(Gluon.Event.EnemyAbility recvEvent)
		{
			return default(bool);
		}

		public virtual void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility enemyAbility)
		{
		}

		public virtual void OnRecieveCharacterState(CharacterState recvEvent)
		{
		}

		public virtual void OnRecieveEnemyDead(DeadReason reason, float prevHpRate)
		{
		}

		public virtual void CreateCharacterMarkRelationUI()
		{
		}

		protected void SetEnemyAbilityCountUI(int count)
		{
		}

		protected void SendEnemyAbilityEvent(Gluon.Event.EnemyAbility.States state, bool ignoreIfSameState, int value = 0, [Optional] CharacterBase character, int intParam = 0, [Optional] string strParam, [Optional] float[] floatParams)
		{
		}

		protected CharacterBase GetHitAttributeOwner(CollisionHitAttribute attr)
		{
			return null;
		}
	}
}
