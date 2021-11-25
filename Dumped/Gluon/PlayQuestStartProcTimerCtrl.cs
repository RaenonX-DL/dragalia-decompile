using System.Collections.Generic;
using System.Diagnostics;

namespace Gluon
{
	public class PlayQuestStartProcTimerCtrl
	{
		private const float stateTotalTimeThreshold = 10f;

		private float stateTotalTime;

		private long procTotalTime;

		private List<string> recordNames;

		private List<long> recordTimes;

		private Stopwatch sw;

		private bool isStarted;

		private bool isSended;

		private void Start()
		{
		}

		public void Record(string procName)
		{
		}

		public void Send()
		{
		}

		public void Update()
		{
		}
	}
}
