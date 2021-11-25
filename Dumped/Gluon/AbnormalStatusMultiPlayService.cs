using System.Collections.Generic;
using Gluon.Event;

namespace Gluon
{
	public class AbnormalStatusMultiPlayService
	{
		private bool _isDirty;

		private CharacterBase _owner;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private ChangeAbnormalStatus _tempSendChangeEvent;

		private short[] _tempSendChangeResists;

		private SlipDamage _tempSendSlipDamageEvent;

		public AbnormalStatusMultiPlayService(CharacterBase owner)
		{
		}

		public void SetDirty()
		{
		}

		public void UpdateSendEvent()
		{
		}

		private void SendCurrentAbnormalStatus()
		{
		}

		public void OnReceiveCurrentAbnormalStatus(ChangeAbnormalStatus recvEvent)
		{
		}

		public void NotifySlipDamage(CharacterBase owner, int slipDamage, AbnormalStatusType type, CharacterBase attacker, bool isFollower, Dictionary<CharacterBase, int> slipDamageOwnerDict)
		{
		}

		public void OnReceiveSlipDamage(CharacterBase owner, CharacterBase attacker, SlipDamage slipDamage)
		{
		}
	}
}
