using System.Collections.Generic;
using Gluon.Event;

namespace Gluon
{
	public class TanatosHourGlassMultiPlayService
	{
		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private CharacterSpecialState _tempSendEvent;

		private Dictionary<int, int> _multiPartyDeathCountDic;

		private int _lastMyHourGlass;

		public TanatosHourGlassMultiPlayService(Dictionary<int, int> multiPartyDeathCountDic)
		{
		}

		public void UpdateSendEvent(EnemyCharacter owner)
		{
		}

		private void SendHourGlass(CharacterBase owner, int hourGlass)
		{
		}

		public void OnRecieveHourGlass(CharacterSpecialState recvEvent)
		{
		}
	}
}
