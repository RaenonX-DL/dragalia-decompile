using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class EnergyPoint : EventBase<EnergyPoint>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Required]
		[Key(2)]
		public int[] ep;
	}
}
