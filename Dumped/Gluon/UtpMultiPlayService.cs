using Gluon.Event;

namespace Gluon
{
	public class UtpMultiPlayService
	{
		private bool _isDirty;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private CharacterSpecialState _tempSendEvent;

		public void SetDirty()
		{
		}

		public void UpdateSendEvent(CharacterBase owner)
		{
		}

		private void SendCurrentPoint(CharacterBase owner)
		{
		}
	}
}
