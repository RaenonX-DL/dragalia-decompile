using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Location
	{
		[Key(0)]
		public float latitude;

		[Key(1)]
		public float longitude;
	}
}
