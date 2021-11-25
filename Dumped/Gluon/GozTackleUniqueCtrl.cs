using System.Collections.Generic;
using Gluon.Event;

namespace Gluon
{
	public class GozTackleUniqueCtrl : EnemyUniqueCtrl
	{
		private List<CharacterId> tackleTargets;

		private List<bool> tackleTargetsSyncFlag;

		public override void Initialize()
		{
		}

		public void SendGozTackleInit(List<CharacterBase> targets)
		{
		}

		public void SendGozTackleTarget(CharacterBase target, int tackleNo)
		{
		}

		public override void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent)
		{
		}

		public CharacterBase GetSyncTarget(int tackleNo)
		{
			return null;
		}
	}
}
