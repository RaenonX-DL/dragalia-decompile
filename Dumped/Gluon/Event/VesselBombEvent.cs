using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class VesselBombEvent : EventBase<VesselBombEvent>
	{
		public enum VesselBombEventTypes
		{
			Countdown,
			CountdownWithCoolTime,
			Resisted
		}

		[Key(1)]
		public VesselBombEventTypes EventVesselBombEventType;

		[Required]
		[Key(2)]
		public CharacterId target;

		[Key(3)]
		public int dungeonPartyIndex;

		[Key(4)]
		public VesselBombEventParameterBase param;
	}
}
