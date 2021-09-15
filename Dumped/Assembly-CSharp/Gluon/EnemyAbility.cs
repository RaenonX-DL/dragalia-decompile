/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbility
	{
		// Fields
		private List<EnemyAbilityProcBase> _abilities;
		private EnemyCharacter _owner;
		private bool _isWaitInitState;
		private bool _isDoneInitState;
		public const int PLAY_EFF_TRIG = 8;
		public const int HIDE_EFF_TRIG = 13;
		private const float VODING_SE_WAIT_TIME = 1f;
		private float _voidingSeTime;
		[CompilerGenerated]
		private bool _isExistBerserkAbility_k__BackingField;
	
		// Properties
		public List<EnemyAbilityProcBase> abilities { get; }
		public bool isExistBerserkAbility { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public struct Argument
		{
			// Fields
			public int argInt01;
			public float argFloat01;
			public float argFloat02;
			public string argString01;
			public CharacterBase argChara01;
		}
	
		// Constructors
		public EnemyAbility(EnemyCharacter owner);
	
		// Methods
		private EnemyAbilityProcBase Create(int id);
		private EnemyAbilityProcBase CreateBerserk(int id);
		private void Reset();
		public bool IsActive(int abilityId);
		public bool IsActiveBerserk();
		public EnemyAbilityProcBase GetAbility(int abilityId);
		public EnemyAbilityProcBase GetAbility(EnemyAbilityType type);
		public int GetAbilityId(EnemyAbilityType type);
		public bool HasAbility(EnemyAbilityType type);
		public void HideEffect();
		public void RestoreEffect();
		public void PlayVoidingSe();
		public void OnUpdate();
		public void OnCharacterInit();
		public void OnCharacterEntry();
		public void OnCharacterRevive();
		public void OnCharacterDead();
		public void OnCharacterLeave();
		public void OnDeadParts(EnemyCharacter parts);
		public void OnCollideOffense(CharacterBase receiver, CollisionHitAttribute hitAttr, bool isFollowerAvoid);
		public void OnCollideReceive(CharacterBase attacker);
		public void OnCalcBaseDamageAttack(CharacterBase receiver, ref Argument arg);
		public void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref Argument arg);
		public void OnApplyDamage(CharacterDamageIntermediate damageData, bool alive);
		public void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref Argument arg);
		public void OnApplySlipDamage(ref Argument arg, int damage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType);
		public void OnApplyDebuffExtraDamage(ref Argument arg);
		public void OnBuildDamage(ref Argument arg);
		public void OnCheckDamageReaction(bool isBarrierBroken, ref Argument arg);
		public void OnActionParts(int abilityId, bool onoff = true);
		public void OnOverdrive(ref Argument arg);
		public void OnOverdriveDamage(CollisionHitAttribute hitAttr, float od_rate, ref Argument arg);
		public void OnBreak();
		public void OnBreakFinish();
		public void OnCalcDefCoefForMirage(CharacterBase attacker, ref Argument arg);
		public void OnExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Argument arg);
		public void OnCalcModeDifense(CharacterBase attacker, ref Argument arg);
		public void OnDrain(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Argument arg);
		public void OnPostDrain();
		public void OnStartBarrier(ref Argument arg);
		public void OnHitBarrier(CharacterBase attacker, ref Argument arg);
		public void OnApplyReduceHp(ref Argument arg);
		public void OnFatalAttack(ref Argument arg);
		public void OnStateEnter_ShapeShift();
		public void OnShiftIntoForm2nd();
		public void OnShiftIntoOriginal();
		public void OnApplyBuffDebuff(ref Argument arg);
		public void OnPlayEffectBuff(ref Argument arg);
		public void OnStopEffectBuff(CharacterBuff buff);
		public void OnDispTextBuff(ref Argument arg);
		public void OnStopBuffField(List<CharacterBase> outCharaList, ref Argument arg);
		public void OnDispel(ref Argument arg);
		public void OnAbnormalStatusProbability(int type, ref Argument arg);
		public void OnBeforeSetAbnormal(CollisionHitAttribute attr, int conditionId, ref Argument arg);
		public void OnSetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability);
		public void OnAbnormalClearType(AbnormalStatusType type, ref Argument arg);
		public void OnWeakPointDestroy(bool isPlayAction = true);
		public void OnWeakPointDefeated(bool isPlayAction = true);
		public void OnSwitchElement();
		public void OnChangeRoomGroup(CharacterBase target);
		public void OnDisconnectUser(int disconnectActorId);
		public void OnRecieveCharacterState(CharacterState recvEvent);
	}
}
