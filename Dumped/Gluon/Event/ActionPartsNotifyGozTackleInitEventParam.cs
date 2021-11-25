using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ActionPartsNotifyGozTackleInitEventParam : ActionPartsNotifyEventParamBase
	{
		[Required]
		[Key(0)]
		public CharacterId[] tackleTargets;
	}
}
