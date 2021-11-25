using Gluon.Event;

namespace Gluon
{
	public class EnemyDeadMultiPlayService
	{
		private bool _isDirty;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private EnemyDead _tempSendEvent;

		public void PostInitializeEnemy(EnemyCharacter enemy)
		{
		}

		public void UpdateSendEvent()
		{
		}

		public void OnEnemyDead(EnemyCharacter deadEnemy, DeadReason reason)
		{
		}

		private void NotifyEnemyDead(EnemyCharacter deadEnemy)
		{
		}

		private void SendEnemyDead()
		{
		}

		private void SetDirty()
		{
		}
	}
}
