using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DragonGauge : EventBase<DragonGauge>
	{
		[Key(1)]
		public int gaugeValue;
	}
}
