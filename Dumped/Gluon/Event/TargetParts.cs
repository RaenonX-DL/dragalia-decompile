using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class TargetParts : EventBase<TargetParts>
	{
		[Key(1)]
		public int partsId;
	}
}
