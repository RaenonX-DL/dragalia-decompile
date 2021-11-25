using System.Runtime.CompilerServices;

namespace Gluon
{
	public abstract class IState<T>
	{
		public StateMachine<T> stateMachine
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string dispEnterLabel => null;

		public string dispUpdateLabel => null;

		public string dispExitLabel => null;

		public T owner => (T)null;

		public void Build(StateMachine<T> stateMachine)
		{
		}

		public virtual void OnStateEnter()
		{
		}

		public virtual void OnStateUpdate()
		{
		}

		public virtual void OnStateExit()
		{
		}
	}
}
