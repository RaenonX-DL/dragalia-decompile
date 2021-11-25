using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class CharacterExternalMove
	{
		private ActionMoveExternal actionMoveKnockBack;

		private List<Vector3> absorbVelocityList;

		private bool isAbsorbing;

		public bool IsExternalMoveAffected => default(bool);

		public bool Setup(CharacterBase owner, CollisionHitAttribute attr, Vector3 collisionPos, AttackHit attackHit, float coe_time = 1f, float coe_dis = 1f)
		{
			return default(bool);
		}

		public void Update(CharacterBase owner, float delta)
		{
		}

		private bool SetupNormal(CharacterBase owner, CollisionHitAttribute attr, Vector3 collisionPos, AttackHit attackHit, float coe_time = 1f, float coe_dis = 1f)
		{
			return default(bool);
		}

		public void KnockBack(CharacterBase owner, Vector3 dir, float duration, float distance)
		{
		}

		private bool SetupAbsorpt(CharacterBase owner, CollisionHitAttribute attr, Vector3 collisionPos, AttackHit attackHit, float coe_time = 1f, float coe_dis = 1f)
		{
			return default(bool);
		}

		public void Absorb(CharacterBase owner, float duration, float distance, Vector3 collisionPos, bool inverse = false)
		{
		}

		public Vector3 CalcMixedAbsorbVelocity()
		{
			return default(Vector3);
		}

		public void ClearExternalMove()
		{
		}
	}
}
