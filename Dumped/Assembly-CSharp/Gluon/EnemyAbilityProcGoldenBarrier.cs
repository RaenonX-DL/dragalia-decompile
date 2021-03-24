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
	public class EnemyAbilityProcGoldenBarrier : EnemyAbilityProcBase, ICollideCallback
	{
		// Fields
		private CollisionHitAttribute _hitAttribute;
		private HitException _hitException;
		private List<CharacterBase> _counterTarget;
		private List<CharacterBase> _counterTargetForAdditionalAttack;
		private float _barrierInterval;
		private bool _isBarrierRestartWaiting;
		private bool isStoreAbnormalResist;
		private float[] storeAbnormalResist;
		private bool _barrierFromAbility;
	
		// Constructors
		public EnemyAbilityProcGoldenBarrier(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void OnUpdate();
		public override void OnStartBarrier(ref Gluon.EnemyAbility.Argument arg);
		public override void OnBuildDamage(ref Gluon.EnemyAbility.Argument arg);
		public override void OnHitBarrier(CharacterBase attacker, ref Gluon.EnemyAbility.Argument arg);
		public override void OnCheckDamageReaction(bool isBarrierBroken, ref Gluon.EnemyAbility.Argument arg);
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
	}
}
