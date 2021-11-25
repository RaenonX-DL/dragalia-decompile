using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct RunActionParameterElement
	{
		[Key(0)]
		public int partsIndex;

		[Key(1)]
		public RunActionParameterBase child;
	}
}
