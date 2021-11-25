using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class AuraEvent : EventBase<AuraEvent>
	{
		[Required]
		[Key(1)]
		public List<AuraEventCommandData> commands;
	}
}
