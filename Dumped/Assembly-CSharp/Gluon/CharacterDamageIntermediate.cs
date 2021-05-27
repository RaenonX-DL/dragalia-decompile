/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterDamageIntermediate
	{
		// Fields
		public int damage;
		public bool isBarrierBroken;
		public bool isLethal;
		public bool isKiller;
		public bool isTolerance;
		public bool isPenetrateShield;
		public float pureElementalRate;
		public float dragonTimerDamage;
		public CharacterBase damageOwner;
		public int overdriveDamage;
		public bool isOnCollided;
		[CompilerGenerated]
		private AttackHit _attackHit_k__BackingField;
		[CompilerGenerated]
		private CollisionHitAttribute _hitAttr_k__BackingField;
	
		// Properties
		public float hpDrainRate { get; }
		public float hpDrainRate2 { get; }
		public int additionRecoveryDp { get; }
		public float recoveryDragonTime { get; }
		public ActionHitExecType hitExecType { get; }
		public bool isQuestSkill { get; }
		public bool enableApplyMultipleDebuff { get; }
		public AttackHit attackHit { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public CollisionHitAttribute hitAttr { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public int skillId { get; }
		public int actionId { get; }
		public Vector3 hitPos { get; }
		public bool isDamageMyself { get; }
		public bool isCancelBind { get; }
		public float skillDamageUpBuffRate { get; }
		public float burstDamageUpBuffRate { get; }
		public bool isTensionMax { get; }
		public bool isInspirationMax { get; }
		public bool isAttrDragon { get; }
	
		// Constructors
		public CharacterDamageIntermediate();
	
		// Methods
		public void Clear();
		public bool HasMultiPlayOwner(CharacterBase character);
		public void WriteToAttackHit(AttackHit outAttackHit);
		public void ReadFromAttackHit(AttackHit inAttackHit, CollisionHitAttribute inHitAttr);
	}
}
