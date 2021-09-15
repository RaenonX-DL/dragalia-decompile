/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcBase
	{
		// Fields
		[CompilerGenerated]
		private Gluon.EnemyAbility _enemyability_k__BackingField;
		[CompilerGenerated]
		private EnemyCharacter _owner_k__BackingField;
		[CompilerGenerated]
		private EnemyAbilityElement _data_k__BackingField;
		[CompilerGenerated]
		private bool _isActive_k__BackingField;
		protected Color RESIST_FONT_COLOR;
		private Gluon.Event.EnemyAbility _tempSendEvent;
	
		// Properties
		protected Gluon.EnemyAbility enemyability { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected EnemyCharacter owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected EnemyAbilityElement data { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int id { get; }
		public string name { get; }
		public EnemyAbilityType type { get; }
		public string iconId { get; }
		public string effKey { get; }
		public bool isActive { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public virtual bool isBerserk { get; }
	
		// Constructors
		public EnemyAbilityProcBase(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public virtual void Setup();
		public virtual void Play();
		public virtual void Stop();
		public virtual void Show();
		public virtual void Hide();
		public virtual void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND);
		public void KickEffectTrigger(int trig);
		protected bool CheckKiller(CharacterBase character);
		public virtual void OnEntry();
		public virtual void OnRevive();
		public virtual void OnUpdate();
		public virtual void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr);
		public virtual void OnFollowerAvoid(CharacterBase receiver);
		public virtual void OnDamage(CharacterBase attacker);
		public virtual void OnCalcBaseDamageAttack(CharacterBase receiver, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnBuildDamage(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnCheckDamageReaction(bool isBarrierBroken, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnOverdrive(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnOverdriveDamage(CollisionHitAttribute hitAttr, float od_rate, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnBreak();
		public virtual void OnBreakFinish();
		public virtual void OnActionParts(bool onoff);
		public virtual void OnCalcDefCoefForMirage(CharacterBase attacker, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnCalcModeDifense(CharacterBase attacker, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnDrain(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnPostDrain();
		public virtual void OnStartBarrier(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnHitBarrier(CharacterBase attacker, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnApplyDamage(CharacterDamageIntermediate damageData, bool alive);
		public virtual void OnApplySlipDamage(ref Gluon.EnemyAbility.Argument arg, int damage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType);
		public virtual void OnApplyDebuffExtraDamage(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnApplyReduceHp(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnFatalAttack(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnStateEnter_ShapeShift();
		public virtual void OnShiftIntoForm2nd();
		public virtual void OnShiftIntoOriginal();
		public virtual void OnDeadParts(EnemyCharacter parts);
		public virtual void OnApplyBuffDebuff(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnPlayEffectBuff(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnStopEffectBuff(CharacterBuff buff);
		public virtual void OnDispTextBuff(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnStopBuffField(List<CharacterBase> outCharaList, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnDispel(ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnAbnormalStatusProbability(int type, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnBeforeSetAbnormal(CollisionHitAttribute attr, int conditionId, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnSetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability);
		public virtual void OnAbnormalClearType(AbnormalStatusType type, ref Gluon.EnemyAbility.Argument arg);
		public virtual void OnWeakPointDestroy(bool isPlayAction);
		public virtual void OnWeakPointDefeated(bool isPlayAction);
		public virtual void OnChangeRoomGroup(CharacterBase target);
		public virtual void OnDisconnectUser(int disconnectActorId);
		public virtual bool CanReceiveEnemyAbilityEvent(Gluon.Event.EnemyAbility recvEvent);
		public virtual void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility enemyAbility);
		public virtual void OnRecieveCharacterState(CharacterState recvEvent);
		public virtual void CreateCharacterMarkRelationUI();
		protected void SendEnemyAbilityEvent(Gluon.Event.EnemyAbility.States state, bool ignoreIfSameState, int value = 0, CharacterBase character = null, int intParam = 0, string strParam = null, float[] floatParams = null);
		protected CharacterBase GetHitAttributeOwner(CollisionHitAttribute attr);
	}
}
