using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class EnemyDead : EventBase<EnemyDead>
	{
		[Required]
		[Key(1)]
		public List<EnemyDeadSyncData> deadList;
	}
}
