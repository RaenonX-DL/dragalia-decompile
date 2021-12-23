using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ApplyOpeningDebuffEvent : EventBase<ApplyOpeningDebuffEvent>
	{
		[Required]
		[Key(1)]
		public CharacterId target;
	}
}
