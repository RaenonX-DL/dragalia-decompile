using Gluon.Event;

namespace Gluon
{
	public class AbilityMultiPlayService
	{
		private bool _isDirty;

		private CharacterBase _owner;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private ChangeAbility _tempSendEvent;

		private Ability OwnerAblity => null;

		public AbilityMultiPlayService(CharacterBase owner)
		{
		}

		public void SetDirty()
		{
		}

		public void UpdateSendEvent()
		{
		}

		public void OnRecieveCurrentAbility(ChangeAbility recvEvent)
		{
		}

		public void SendImmediately()
		{
		}

		private void SendCurrentAbility()
		{
		}

		private bool CanSendAbility()
		{
			return default(bool);
		}
	}
}
