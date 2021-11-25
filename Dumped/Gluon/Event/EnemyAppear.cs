using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class EnemyAppear : EventBase<EnemyAppear>
	{
		[Required]
		[Key(1)]
		public List<EnemyAppearSyncData> appearList;
	}
}
