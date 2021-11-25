using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CharacterStateSkillCasting : CharacterStateBase
	{
		private bool _prevEnableNavMeshAgent;

		public int skillIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

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

		public CommonObjectStatus target
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int skillId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
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
