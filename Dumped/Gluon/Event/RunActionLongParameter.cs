using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionLongParameter : RunActionParameterBase
	{
		[Key(0)]
		public long value;
	}
}
