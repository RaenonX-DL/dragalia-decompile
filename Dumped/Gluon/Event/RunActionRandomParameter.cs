using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionRandomParameter : RunActionParameterBase
	{
		[Key(0)]
		public uint randomSeed;
	}
}
