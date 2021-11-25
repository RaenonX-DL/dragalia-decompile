using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ConsumeUtpToRecoverHpEvent : EventBase<ConsumeUtpToRecoverHpEvent>
	{
		[Required]
		[Key(1)]
		public CharacterId owner;

		[Key(2)]
		public int hp;

		[Key(3)]
		public float prevHp;

		[Key(4)]
		public float utp;

		[Key(5)]
		public int recoveryHp;
	}
}
