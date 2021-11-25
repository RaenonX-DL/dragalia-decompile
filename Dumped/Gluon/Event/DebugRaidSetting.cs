using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugRaidSetting : EventBase<DebugRaidSetting>
	{
		[Key(1)]
		public int type;

		[Key(2)]
		public int value;
	}
}
