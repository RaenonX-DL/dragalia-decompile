namespace Gluon
{
	public class CharacterStateBlastDown : CharacterStateBase
	{
		private ActionBlastDown action;

		private const float DIE_TIMING = 0.2f;

		private float _elapsed;

		private bool hasDead;

		public float gravity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float angle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float height
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

		public override void OnStateUpdate()
		{
		}

		public override void OnStateExit()
		{
		}
	}
}
