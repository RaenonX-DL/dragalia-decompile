using System;
using System.Collections.Generic;
using Gluon.Event;

namespace Gluon
{
	public class MainGamePartySwitchCtrl
	{
		private class WaitOtherPlayersData
		{
			public bool isWaitOtherPlayers;

			public float minWaitRemainSec;

			public Action onFinishCallback;

			public MultiPlayWaitingList waitingOtherPlayers;

			public List<int> receiveBuffer;

			public void Clear()
			{
			}
		}

		private Dictionary<MainGameCtrl.PartySwitchPhase, WaitOtherPlayersData> _waitOtherPlayersDic;

		public void SetStateIdle(CharacterManager charaManager, DragonTransformCtrl dragonTransform, bool isOnlyOwnParty)
		{
		}

		public void StartWaitOtherPlayers(MainGameCtrl.PartySwitchPhase phase, float minWaitSec, Action onFinishCallback)
		{
		}

		public void StopWaitOtherPlayers(MainGameCtrl.PartySwitchPhase phase)
		{
		}

		public void Update()
		{
		}

		public bool OnReceiveGameStep(GameStepEvent recvEvent)
		{
			return default(bool);
		}
	}
}
