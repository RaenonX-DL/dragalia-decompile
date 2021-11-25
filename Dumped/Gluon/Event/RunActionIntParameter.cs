using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionIntParameter : RunActionParameterBase
	{
		[Key(0)]
		public int value;
	}
}
