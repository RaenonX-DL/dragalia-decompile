using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class PlayerEventReceiver : EventReceiverBase
	{
		private bool _controlled;

		private float targetChargePullLength;

		private Vector3 targetChargeMarkerPos;

		private Quaternion targetChargeRotation;

		private float remainChargeTime;

		private int targetChangeMode;

		public override CharacterBase character => null;

		public PlayerCharacter player => null;

		public CharacterSelector selector
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int proxyActorId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool controlled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LastControlled => default(bool);

		public int LastDp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void Initialize(CharacterId characterId)
		{
		}

		public override void FastUpdate()
		{
		}

		public override void ThrowCarryRequest(ThrowCarryRequest throwCarryRequest)
		{
		}

		public override void ThrowCarryReply(ThrowCarryReply throwCarryReply)
		{
		}

		public override void ThrowRelease(ThrowRelease throwRelease)
		{
		}

		public void Charge(Charge charge)
		{
		}

		public void SetCurrentChangeMode(int mode)
		{
		}

		protected override void ChangeStateImpl(CharacterState characterState)
		{
		}

		protected override void UpdateSkillState()
		{
		}

		protected override void UpdateChargeState()
		{
		}

		protected void ProcessCharge(bool isChargeDirectionIndependent)
		{
		}

		protected void ProcessChargeAfterMove(bool isChargeDirectionIndependent)
		{
		}

		private void UpdateChangeMode()
		{
		}

		public static bool NeedModeChangeSync(PlayerCharacter.ModeChangeType modeChangeType)
		{
			return default(bool);
		}

		private void CheckDragonTransformEffect()
		{
		}
	}
}
