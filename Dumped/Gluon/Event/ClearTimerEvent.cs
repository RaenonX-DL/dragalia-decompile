using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ClearTimerEvent : EventBase<ClearTimerEvent>
	{
		public enum EventTypes
		{
			Start,
			Pause,
			Restart
		}

		[Required]
		[Key(1)]
		public EventTypes eventType;
	}
}
