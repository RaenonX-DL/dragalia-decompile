using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct RemoveSyncData
	{
		[Key(0)]
		public int multiPlayKey;

		[Key(1)]
		public RemoveBuffReason reason;
	}
}
