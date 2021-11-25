using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Stamp : EventBase<Stamp>
	{
		[Key(1)]
		public int iconId;
	}
}
