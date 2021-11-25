namespace Gluon
{
	public class CharacterStateDamaged : CharacterStateBase
	{
		public float motionTimeScale
		{
			get
			{
				return default(float);
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

		protected override bool NeedsResetHidingBuffOnEnter()
		{
			return default(bool);
		}
	}
}
