using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ReasonRemoveActor : EventBase<ReasonRemoveActor>
	{
		[Key(1)]
		public string reason;
	}
}
