using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CharacterStateDead : CharacterStateBase
	{
		private bool reserveEnd;

		public bool playMotion
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isRestoreMotion
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isAbilityRebornReserved
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int DamageOwnerActorId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int DamageOwnerIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool isDeadEnd
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

		public override void OnStateExit()
		{
		}

		public override void OnStateUpdate()
		{
		}

		protected override bool NeedsResetHidingBuffOnEnter()
		{
			return default(bool);
		}
	}
}
