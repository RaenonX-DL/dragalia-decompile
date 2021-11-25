using Gluon.Event;

namespace Gluon
{
	public class EnergyPointMultiPlayService
	{
		private bool _isDirty;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private EnergyPoint _tempSendEvent;

		public void SetDirty()
		{
		}

		public void UpdateSendEvent(CharacterBase owner)
		{
		}

		public void OnRecieveCurrentEp(CharacterBase owner, EnergyPoint recvEvent)
		{
		}

		private void SendCurrentEp(CharacterBase owner)
		{
		}
	}
}
