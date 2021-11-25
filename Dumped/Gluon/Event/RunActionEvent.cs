using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct RunActionEvent
	{
		[Key(0)]
		public int actionId;

		[Key(1)]
		public RunActionParameterBase param;

		public bool IsEmpty()
		{
			return default(bool);
		}

		public void Clear()
		{
		}
	}
}
