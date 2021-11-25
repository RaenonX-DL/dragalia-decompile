using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityProcGoldenBarrier : EnemyAbilityProcBase, ICollideCallback
	{
		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		private List<CharacterBase> _counterTarget;

		private List<CharacterBase> _counterTargetForAdditionalAttack;

		private float _barrierInterval;

		private bool _isBarrierRestartWaiting;

		private bool isStoreAbnormalResist;

		private float[] storeAbnormalResist;

		private bool _barrierFromAbility;

		public EnemyAbilityProcGoldenBarrier(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnStartBarrier(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnBuildDamage(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnHitBarrier(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCheckDamageReaction(bool isBarrierBroken, ref EnemyAbility.Argument arg)
		{
		}

		public void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public void OnNotCollided(CharacterBase chara)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
