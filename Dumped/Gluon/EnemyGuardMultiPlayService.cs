using Gluon.Event;

namespace Gluon
{
	public class EnemyGuardMultiPlayService
	{
		private int _currentGuardRequestId;

		private RequestGuard _requestGuardEvent;

		private DenyGuard _denyGuardEvent;

		private RequestGuardCounter _requestGuardCounterEvent;

		private RequestCounter _requestCounterEvent;

		public void TrySendGuard(EnemyCharacter guardExecutor)
		{
		}

		public void OnGuardRequested(EnemyCharacter guardExecutor, RequestGuard requestGuard)
		{
		}

		public void OnGuardDenied(EnemyCharacter guardExecutor, DenyGuard denyGuard)
		{
		}

		public void TrySendGuardCounter(EnemyCharacter counterExecutor)
		{
		}

		public void OnGuardCounterRequested(EnemyCharacter counterExecutor, RequestGuardCounter requestCounter)
		{
		}

		public void TrySendCounter(EnemyCharacter counterExecutor, CharacterBase counterTarget)
		{
		}

		public void OnCounterRequested(EnemyCharacter counterExecutor, RequestCounter requestCounter)
		{
		}

		private void SendRequestGuard(EnemyCharacter guardExecutor)
		{
		}

		private void SendRequestGuardCounter(EnemyCharacter counterExecutor)
		{
		}

		private void SendRequestCounter(EnemyCharacter counterExecutor, CharacterBase counterTargetChara)
		{
		}

		private void SendDenyGuard(RequestGuard requestGuard)
		{
		}
	}
}
