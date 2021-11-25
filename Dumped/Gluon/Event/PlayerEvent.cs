using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class PlayerEvent : EventBase<PlayerEvent>
	{
		public enum PlayerEventTypes : byte
		{
			UpdateAllDeadConfirmed
		}

		[Key(1)]
		public PlayerEventTypes type;

		[Key(2)]
		public bool flag;
	}
}
