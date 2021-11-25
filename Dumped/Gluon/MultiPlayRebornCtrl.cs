using System;
using System.Collections.Generic;
using Gluon.Event;

namespace Gluon
{
	public class MultiPlayRebornCtrl
	{
		private class CharaData
		{
			public float elapsedTime;

			public bool wasShowFirst;
		}

		private Dictionary<CharacterBase, CharaData> _charaDic;

		private NotifyCharacter.UpdateRebornTimerCountParam _tmpNotifyParam;

		private RebornEvent tmpRebornEvent;

		public void OnReceiveRebornEvent(int actorId, RebornEvent recvEvent)
		{
		}

		public void SendStartWaitReborn(List<CharacterBase> targetCharas, bool isAbilityReborn)
		{
		}

		public void SendReborn(List<Tuple<CharacterBase, float>> rebornCharaInfos, bool isAbilityReborn)
		{
		}

		public void Update()
		{
		}

		public int GetOtherPlayerSystemRebornCharacterCount(int actorId)
		{
			return default(int);
		}

		public int GetOtherPlayerSystemRebornProcessCount(int actorId)
		{
			return default(int);
		}
	}
}
