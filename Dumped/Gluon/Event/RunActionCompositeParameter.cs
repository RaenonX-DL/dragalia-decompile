using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionCompositeParameter : RunActionParameterBase
	{
		[Key(0)]
		public RunActionParameterBase baseParam;

		[Key(1)]
		public RunActionParameterBase extParam;
	}
}
