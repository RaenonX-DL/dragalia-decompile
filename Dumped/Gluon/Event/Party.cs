using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Party : EventBase<Party>
	{
		[Required]
		[Key(1)]
		public Dictionary<int, int> memberCountTable;

		[Key(2)]
		public int rankingType;

		[Key(3)]
		public int reBattleCount;

		[Key(4)]
		public bool isAutoFailTimeoutEnabled;

		[Key(5)]
		public float forceAutoFailTime;

		[Key(6)]
		public bool isDisableOnDamagedWhenLeave;
	}
}
