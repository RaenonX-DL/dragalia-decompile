using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugBattleSetting : EventBase<DebugBattleSetting>
	{
		[Key(1)]
		public int type;

		[Key(2)]
		public int value;
	}
}
