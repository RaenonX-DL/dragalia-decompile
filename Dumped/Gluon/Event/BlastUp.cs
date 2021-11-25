using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BlastUp
	{
		[Key(1)]
		public float gravity;

		[Key(2)]
		public float angle;

		[Key(3)]
		public float height;

		[Key(4)]
		public byte reaction;
	}
}
