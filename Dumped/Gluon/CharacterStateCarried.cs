using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CharacterStateCarried : CharacterStateBase
	{
		public CharacterBase carryChara;

		public bool isFalling
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
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
