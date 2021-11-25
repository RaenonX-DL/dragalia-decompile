using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class MoveBundle : EventBase<MoveBundle>
	{
		[Required]
		[Key(1)]
		public MoveBundleUnit[] moves;
	}
}
