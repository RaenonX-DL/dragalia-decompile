namespace Gluon
{
	public class CharacterStateUniqueTransform : CharacterStateBase
	{
		protected override void OnStateEnter_Internal()
		{
		}

		public override void OnStateExit()
		{
		}

		protected override bool NeedsResetHidingBuffOnEnter()
		{
			return default(bool);
		}
	}
}
