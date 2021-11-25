namespace Gluon
{
	public class FailQuestCtrl
	{
		private bool needsFailResult;

		private bool needsRetry;

		public void Timeup()
		{
		}

		public void AllDead()
		{
		}

		public void ContinueImpossible()
		{
		}

		public void ObjectiveFailed()
		{
		}

		public void Retry(int questId)
		{
		}

		public void Update()
		{
		}

		public bool NeedsRetry()
		{
			return default(bool);
		}

		public bool NeedsFailResult()
		{
			return default(bool);
		}

		private bool IsPlayingWithOtherPlayer()
		{
			return default(bool);
		}

		private void CheckNeedsFailResult()
		{
		}

		private void CheckNeedsRetry(int questId)
		{
		}

		private void CheckRebattleTimeout()
		{
		}

		private void SendFail()
		{
		}
	}
}
