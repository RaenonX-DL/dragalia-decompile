using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CharacterStateBlastUp : CharacterStateBase
	{
		private ActionBlastUp action;

		public CharacterBase attacker;

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

		public int reaction
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool disallowRecovery
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
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
