using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Statistics : EventBase<Statistics>
	{
		[Key(1)]
		public int roundTripTime;

		[Key(2)]
		public int roundTripTimeVariance;

		[Key(3)]
		public float incommingByteCountPerSec;

		[Key(4)]
		public float outgoingByteCountPerSec;

		[Key(5)]
		public int maxQueuedIncommingCommands;

		[Key(6)]
		public int maxQueuedOutgoingCommands;
	}
}
