using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ReduceSacrificeShieldHp : EventBase<ReduceSacrificeShieldHp>
	{
		[Required]
		[Key(1)]
		public CharacterId target;

		[Key(2)]
		public float reduceSacrificeShieldHp;
	}
}
