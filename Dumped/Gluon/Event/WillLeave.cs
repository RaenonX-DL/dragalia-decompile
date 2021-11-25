using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class WillLeave : EventBase<WillLeave>
	{
		public enum Reasons
		{
			None,
			Retire,
			LeaveAlone,
			BRContinueRetire
		}

		[Key(1)]
		public Reasons reason;
	}
}
