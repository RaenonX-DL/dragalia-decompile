using UnityEngine;

namespace Gluon
{
	public class FollowerAI_10350504 : FollowerAIBase
	{
		private bool isReservedRandomBurstAttack;

		private bool isEnteredChargeState;

		public override bool NeedsCheckPrioritizeBurstAttack()
		{
			return default(bool);
		}

		public override void Update(PlayerCharacter owner)
		{
		}

		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false)
		{
			return default(bool);
		}

		private float GetTargetSqrDistance(Vector3 dir, float radius)
		{
			return default(float);
		}

		public override float GetProbabilityForBurstAttackOnOverrideMode(PlayerCharacter owner, float probability, CharacterBase target)
		{
			return default(float);
		}

		public override bool BurstAttackIsAttack()
		{
			return default(bool);
		}
	}
}
