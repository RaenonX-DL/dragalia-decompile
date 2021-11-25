using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Cute.Core
{
	public class LeanThreadPool
	{
		private static LeanThreadPool instance;

		private Thread[] threads;

		private Semaphore semaphore;

		private object jobsLock;

		private object convergeLock;

		private List<ParallelJob> jobs;

		private bool quit;

		private int convergeCount;

		public static LeanThreadPool Instance => null;

		private LeanThreadPool()
		{
		}

		private void ThreadFunction()
		{
		}

		public IEnumerator KillAll()
		{
			return null;
		}

		public void AddJob(ParallelJob job)
		{
		}
	}
}
