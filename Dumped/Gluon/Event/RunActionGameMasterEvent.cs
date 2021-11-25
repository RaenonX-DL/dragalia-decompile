using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionGameMasterEvent : RunActionParameterBase
	{
		[Key(0)]
		public int nextEvent;

		[Key(1)]
		public string egLabel;

		[Key(2)]
		public int turnMax;
	}
}
