namespace Gluon
{
	public class PhotonSuspendCheatChecker
	{
		private enum SuspendSpans
		{
			ShortSuspend = 1,
			LongSuspend
		}

		private bool _isInBossBattle;

		private bool _isShortSuspendReceived;

		private bool _isSuspending;

		private long _lastSuspendTick;

		private static readonly int LongSuspendThreshold;

		public void Update()
		{
		}

		public void SetIsInBossBattle(bool isInBossBattle)
		{
		}

		public void OnApplicationPause(bool paused)
		{
		}

		private void OnApplicationResumed(SuspendSpans resumeEvent)
		{
		}

		private bool CheckDisconnectCondition(SuspendSpans resumeEvent)
		{
			return default(bool);
		}

		private long GetCurrentTick()
		{
			return default(long);
		}

		private bool CheckIsLongSuspend(long currentTick, int threshold)
		{
			return default(bool);
		}
	}
}
