namespace Gluon
{
	public class CharacterStateAvoid : CharacterStateBase
	{
		private int currentLayer;

		public int actionId
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
