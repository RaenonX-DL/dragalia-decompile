namespace Gluon
{
	public class CharacterStateSwoon : CharacterStateBase
	{
		public CharacterBase.AbnormalStatusProbabilityResult probability;

		public CollisionHitAttribute hitAttr;

		public int conditionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		protected override void OnStateEnter_Internal()
		{
		}

		public override void OnStateExit()
		{
		}
	}
}
