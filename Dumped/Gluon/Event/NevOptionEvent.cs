using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class NevOptionEvent : EventBase<NevOptionEvent>
	{
		public enum NevOptionEventTypes
		{
			OnShootOption,
			AppearNevOption
		}

		[Required]
		[Key(1)]
		public NevOptionEventTypes type;

		[Required]
		[Key(2)]
		public CharacterId target;

		[Key(3)]
		public NevOptionEventParamBase param;
	}
}
