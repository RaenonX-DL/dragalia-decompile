namespace Gluon
{
	public class FollowerAI_29900020 : FollowerAIBase
	{
		private readonly int skillTriggerMax;

		private int skillTrigger;

		public override bool IsSkillAvailable(PlayerCharacter owner, int skillIndex)
		{
			return default(bool);
		}

		public override void OnSkillExit(PlayerCharacter owner, int skillIndex)
		{
		}

		public override void OnAttackExit(PlayerCharacter owner, int actionId)
		{
		}

		public override void OnTransformEnter(PlayerCharacter owner)
		{
		}

		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false)
		{
			return default(bool);
		}

		public override bool NeedsCheckPrioritizeBurstAttack()
		{
			return default(bool);
		}
	}
}
