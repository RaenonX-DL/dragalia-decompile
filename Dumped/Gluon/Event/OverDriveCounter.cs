using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class OverDriveCounter : EventBase<OverDriveCounter>
	{
		[Required]
		[Key(1)]
		public CharacterId owner;

		[Required]
		[Key(2)]
		public CharacterId target;
	}
}
