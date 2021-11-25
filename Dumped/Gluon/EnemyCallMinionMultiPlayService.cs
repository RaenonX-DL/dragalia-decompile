using Gluon.Event;

namespace Gluon
{
	public class EnemyCallMinionMultiPlayService : ImportantTaskMultiPlayServiceBase<EnemyCharacter.CallMinionInfo>
	{
		private EnemyCharacter.CallMinionInfo _tmpTaskParam;

		public void RequestCallMinion(int taskId, EnemyCharacter.CallMinionInfo param)
		{
		}

		protected override void SendEvent(int taskId, EnemyCharacter.CallMinionInfo param)
		{
		}

		public void OnReceiveCallMinion(CallMinionEvent recvEvent)
		{
		}

		protected override EnemyCharacter.CallMinionInfo CloneParam(EnemyCharacter.CallMinionInfo src)
		{
			return null;
		}

		protected override void Execute(EnemyCharacter.CallMinionInfo param)
		{
		}

		protected override void OnReserved(EnemyCharacter.CallMinionInfo param)
		{
		}

		protected override void OnResetReserve(EnemyCharacter.CallMinionInfo param)
		{
		}
	}
}
