namespace Gluon
{
	public class FollowerAI_10850402 : FollowerAIBase
	{
		private enum RandomBAState
		{
			None,
			Reserved,
			Entered,
			Expelled
		}

		private RandomBAState randomBAState;

		public override void Update(PlayerCharacter owner)
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

		public override bool IsEnableSkill(PlayerCharacter owner, CharacterBase target, int index)
		{
			return default(bool);
		}
	}
}
