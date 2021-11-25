namespace Gluon
{
	public class FollowerAI_10350505 : FollowerAIBase
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

		public override bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public override bool IsEnableSkill2(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public override bool IsEnableServantTransform(PlayerCharacter owner)
		{
			return default(bool);
		}
	}
}
