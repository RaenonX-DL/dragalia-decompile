using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRNotifyPulseRadiusEventParam : BRNotifyEventParamBase
	{
		[Required]
		[Key(0)]
		public float radius;
	}
}
