using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BuffFieldEvent : EventBase<BuffFieldEvent>
	{
		public enum BuffFieldEventTypes
		{
			Create,
			Delete
		}

		[Required]
		[Key(1)]
		public BuffFieldEventTypes type;

		[Required]
		[Key(2)]
		public long buffFieldId;

		[Required]
		[Key(3)]
		public CharacterId owner;

		[Key(4)]
		public BuffFieldEventParamBase param;
	}
}
