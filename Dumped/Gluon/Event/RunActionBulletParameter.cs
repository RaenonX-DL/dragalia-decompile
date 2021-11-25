using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionBulletParameter : RunActionParameterBase
	{
		[Key(0)]
		public uint randomSeed;

		[Key(1)]
		public int appearChildTaskId;
	}
}
