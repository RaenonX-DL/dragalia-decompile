namespace Gluon
{
	public class CharacterStateTorpedo : CharacterStateBase
	{
		private enum State
		{
			None,
			Torpedo,
			Down,
			Standup
		}

		private State state;

		public CharacterBase throwChara;

		private float elapsedTime;

		private float downLoopTime;

		private const string animDownName = "blast_dead";

		private const string animStandupName = "blast_6";

		protected override void OnStateEnter_Internal()
		{
		}

		public override void OnStateUpdate()
		{
		}

		public override void OnStateExit()
		{
		}
	}
}
