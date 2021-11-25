using Gluon.Event;

namespace Gluon
{
	public class SkillPointMultiPlayService
	{
		private bool _isDirty;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private SkillPoint _tempSendEvent;

		public void SetDirty()
		{
		}

		public void UpdateSendEvent(CharacterBase owner)
		{
		}

		public void OnRecieveCurrentSp(CharacterBase owner, SkillPoint recvEvent)
		{
		}

		private void SendCurrentSp(CharacterBase owner)
		{
		}
	}
}
