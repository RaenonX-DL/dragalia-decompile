using Gluon.Event;

namespace Gluon
{
	public class AbilityGaugeMultiPlayService
	{
		private bool _isDirty;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		public void SetDirty()
		{
		}

		public void UpdateSendEvent(CharacterBase owner)
		{
		}

		public void OnRecieveCurrentGauge(CharacterBase owner, AbilityGauge recvEvent)
		{
		}

		private void SendCurrentGauge(CharacterBase owner)
		{
		}
	}
}
