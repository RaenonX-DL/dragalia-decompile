using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DollEvent : EventBase<DollEvent>
	{
		[Key(1)]
		public CharacterId target;

		[Key(2)]
		public CharacterId from;

		[Key(3)]
		public int value;

		[Key(4)]
		public float duration;

		[Key(5)]
		public bool isTimeUp;

		[Key(6)]
		public bool canTransform;
	}
}
