namespace Gluon
{
	public class FollowerAI_20050418 : FollowerAIBase
	{
		private int nextChargeLevel;

		private bool isEnteredChargeState;

		public override void Update(PlayerCharacter owner)
		{
		}

		public override bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public override int GetChargeLevel(PlayerCharacter owner, CharacterBase target)
		{
			return default(int);
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
