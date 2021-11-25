using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityProcPetrifaction : EnemyAbilityProcBase, ICollideCallback
	{
		public struct PetrifactionPlayer
		{
			public CharacterBase chara;

			public float timer;

			public float interval;

			public long bindEventId;
		}

		private CollisionHitAttribute _hitAttribute;

		public const int playerNum = 4;

		private CharacterBase currentTarget;

		private HitException _hitException;

		private PetrifactionPlayer[] petrifactionPlayer;

		public const string PETFAC_EFFECT_NAME = "EFF_BOS_0150301_001";

		public const string SE_NAME = "SE_ENE_BOS_0150000_01_0001";

		public EnemyAbilityProcPetrifaction(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void Stop()
		{
		}

		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public virtual void OnNotCollided(CharacterBase chara)
		{
		}

		public virtual void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnCatch(CharacterBase chara, long bindEventId)
		{
		}

		public void ReleaseChara(ref PetrifactionPlayer target)
		{
		}

		public bool GetElapsedTime(CharacterBase chara, out float elapsed, out float duration)
		{
			return default(bool);
		}
	}
}
