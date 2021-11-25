using System;
using System.Runtime.CompilerServices;

namespace Cute.Core
{
	public class ParallelJob
	{
		private Action action;

		public bool IsDone
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

		public static ParallelJob Dispatch(Action action)
		{
			return null;
		}

		private ParallelJob(Action action)
		{
		}

		internal void Run()
		{
		}
	}
}
