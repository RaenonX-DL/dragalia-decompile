using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CharacterStateBoundary : CharacterStateBase
	{
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

		public int boundaryDataId
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

		protected override void OnStateEnter_Internal()
		{
		}

		public override void OnStateExit()
		{
		}
	}
}
