using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class StateMachine<T>
	{
		private Dictionary<Type, IState<T>> states;

		public T owner
		{
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IState<T> current
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

		public IState<T> next
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

		public IState<T> prev
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

		public StateMachine(T owner)
		{
		}

		public U GetState<U>() where U : IState<T>, new()
		{
			return null;
		}

		public U SetState<U>(bool immediate = false) where U : IState<T>, new()
		{
			return null;
		}

		public IState<T> SetState(IState<T> state, bool immediate = false)
		{
			return null;
		}

		public void Update()
		{
		}
	}
}
