using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class PlayerEventSender : EventSenderBase
	{
		private CharacterSelector selector;

		private bool isSyncChargeRequested;

		private float lastSendChargePullLength;

		private Vector3 lastSendChargeMarkerPos;

		private float lastSendChargeRotation;

		private int lastSendChangeMode;

		private TransformCharacter transformCharacter;

		private Charge charge;

		public override CharacterBase character => null;

		public PlayerCharacter player => null;

		public override void Initialize(CharacterId characterId, bool useMoveBundle)
		{
		}

		private void OnChangeCharacter(CharacterSelector.Type type, bool isFinishDragon)
		{
		}

		protected override void LateUpdate()
		{
		}

		protected override void UpdateSkillState()
		{
		}

		protected override void UpdateChargeState()
		{
		}

		public void RequestChargeEvent()
		{
		}

		private Charge CreateChargeEvent()
		{
			return null;
		}

		private bool CheckSendCharge(Charge charge)
		{
			return default(bool);
		}

		protected void SendChargeEvent(Charge charge)
		{
		}

		private void UpdateSendChangeMode()
		{
		}
	}
}
