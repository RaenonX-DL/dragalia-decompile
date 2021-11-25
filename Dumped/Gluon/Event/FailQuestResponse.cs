using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class FailQuestResponse : EventBase<FailQuestResponse>
	{
		public enum ResultTypes
		{
			Timeup,
			Clear
		}

		[Required]
		[Key(1)]
		public ResultTypes resultType;
	}
}
