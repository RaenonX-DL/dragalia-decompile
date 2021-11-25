using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRNotifyEvent : EventBase<BRNotifyEvent>
	{
		public enum BRNotifyEventTypes
		{
			GameEnd,
			PulseRadius,
			LevelUp,
			LookingCharacter,
			Extra
		}

		[Required]
		[Key(1)]
		public BRNotifyEventTypes type;

		[Key(2)]
		public BRNotifyEventParamBase param;
	}
}
