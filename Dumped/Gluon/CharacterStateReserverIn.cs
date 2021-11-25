namespace Gluon
{
	public class CharacterStateReserverIn : CharacterStateBase
	{
		private enum State
		{
			Fall,
			Landing
		}

		private State state;

		private ActionMoveGravity fallAction;

		protected override void OnStateEnter_Internal()
		{
		}

		public override void OnStateExit()
		{
		}

		public override void OnStateUpdate()
		{
		}
	}
}
