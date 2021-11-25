using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class AbilityGauge : EventBase<AbilityGauge>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Required]
		[Key(2)]
		public int[] gaugeValueList;
	}
}
