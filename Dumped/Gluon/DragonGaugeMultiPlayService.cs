using Gluon.Event;

namespace Gluon
{
	public class DragonGaugeMultiPlayService
	{
		private bool _isDirty;

		private float _nextSendEventTimer;

		private DragonGauge _tempSendEvent;

		private static float SendEventInterval => default(float);

		public void SetDirty(int currentDp)
		{
		}

		public void UpdateSendEvent(int currentDp)
		{
		}

		private void SendCurrentDragonGauge(int currentDp)
		{
		}

		public void OnReceiveEvent(DragonGauge recvEvent)
		{
		}
	}
}
