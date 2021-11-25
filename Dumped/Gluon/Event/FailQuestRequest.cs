using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class FailQuestRequest : EventBase<FailQuestRequest>
	{
		public enum FailTypes
		{
			Timeup,
			AllDead
		}

		[Required]
		[Key(1)]
		public FailTypes failType;
	}
}
