using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugBossHpEvent : EventBase<DebugBossHpEvent>
	{
		[Required]
		[Key(1)]
		public CharacterId[] targets;

		[Required]
		[Key(2)]
		public int[] hp;
	}
}
