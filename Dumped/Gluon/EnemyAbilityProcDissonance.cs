using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityProcDissonance : EnemyAbilityProcBase, ICollideCallback
	{
		private class CounterInfo
		{
			public CharacterBase chara;

			public int skillId;

			public int skillProductId;
		}

		private CollisionHitAttribute _hitAttribute;

		private List<CharacterBase> _counterTarget;

		private List<CounterInfo> listCounterInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool isDissonanceBuff => default(bool);

		public EnemyAbilityProcDissonance(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void Stop()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute hitAttr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
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
	}
}
