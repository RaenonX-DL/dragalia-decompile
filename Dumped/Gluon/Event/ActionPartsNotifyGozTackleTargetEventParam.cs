using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ActionPartsNotifyGozTackleTargetEventParam : ActionPartsNotifyEventParamBase
	{
		[Required]
		[Key(0)]
		public CharacterId tackleTarget;

		[Required]
		[Key(1)]
		public int tackleNo;
	}
}
