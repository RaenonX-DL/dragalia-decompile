/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAIBase
	{
		// Fields
		protected List<int> _tmpSkillIndexList;
	
		// Constructors
		public FollowerAIBase();
	
		// Methods
		public virtual void Update(PlayerCharacter owner);
		public virtual bool IsEnableSkill(PlayerCharacter owner, CharacterBase target, int index);
		public virtual bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target);
		public virtual bool IsEnableSkill2(PlayerCharacter owner, CharacterBase target);
		public virtual bool IsEnableWeaponSkill(PlayerCharacter owner, CharacterBase target);
		public virtual bool IsEnableSkill4(PlayerCharacter owner, CharacterBase target);
		public virtual bool CheckDragonSkillForAuto();
		public virtual bool IsPrioritizeBurstAttack(PlayerCharacter owner, float probabilityCoef = 1f, bool force = false);
		public virtual bool IsIgnoreCommonConditionForBurstAttack(PlayerCharacter owner);
		public virtual bool ShouldCancelSkill(PlayerCharacter owner, int skillIndex);
		public virtual bool IsEnableBurstAttack(CharacterSelector selector);
		public virtual float GetChargeCompleteWaitSecForAI(PlayerCharacter owner, float defaultVal);
		public virtual bool ShouldUseExCombo(PlayerCharacter owner, CharacterBase target);
		public virtual float GetProbabilityForBurstAttackOnOverrideMode(float probability, CharacterBase target);
		public virtual int GetChargeLevel(PlayerCharacter owner, CharacterBase target);
		public virtual bool NeedsCheckPrioritizeBurstAttack();
		public virtual bool BurstAttackIsAttack();
		public virtual bool IsEnableTransform(PlayerCharacter owner);
		public virtual bool IsEnableUniqueTransform(PlayerCharacter owner);
		public virtual bool IsEnableServantTransform(PlayerCharacter owner);
		public virtual bool IsEnableReleaseUniqueTransform(PlayerCharacter owner);
		public virtual bool IsEnableAdditionalInputCount(PlayerCharacter owner, int counter = 0);
		public virtual bool AdditionalInputCountTimes(PlayerCharacter owner, int counter);
		public virtual bool CheckAndSwitchMode(PlayerCharacter ownerm, CharacterBase target);
		public virtual PlayerActionElement GetActionDataOnCheckSkill(PlayerActionElement elem, PlayerCharacter owner, int skillIndex);
		public virtual void OnSkillEnter(PlayerCharacter owner, int skillIndex);
		public virtual void OnSkillExit(PlayerCharacter owner, int skillIndex);
		public virtual void AvoidOnAttacked(PlayerCharacter owner, CollisionHitAttribute attr);
		public virtual bool IsBarrierEnemy(PlayerCharacter owner, EnemyCharacter enemy);
		protected virtual void ChangeMode(PlayerCharacter owner, int mode);
		public virtual List<int> GetSkillIndexList(PlayerCharacter owner);
	}
}
