using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ActionPartsNotifyEvent : EventBase<ActionPartsNotifyEvent>
	{
		public enum ActionPartsNotifyEventTypes
		{
			GozTackleInit,
			GozTackleTarget
		}

		[Required]
		[Key(1)]
		public ActionPartsNotifyEventTypes type;

		[Required]
		[Key(2)]
		public CharacterId target;

		[Key(3)]
		public ActionPartsNotifyEventParamBase param;
	}
}
