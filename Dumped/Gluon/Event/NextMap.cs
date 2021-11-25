using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class NextMap : EventBase<NextMap>
	{
		[Key(1)]
		public int nextIndex;

		[Key(2)]
		public int targetIndex;
	}
}
