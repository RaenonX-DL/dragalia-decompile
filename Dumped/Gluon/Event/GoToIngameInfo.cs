using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class GoToIngameInfo
	{
		[MessagePackObject(false)]
		public class ActorData
		{
			[Key(0)]
			public int ActorId;

			[Key(1)]
			public ulong ViewerId;
		}

		[MessagePackObject(false)]
		public class BRInitData
		{
			[Key(0)]
			public int locationPattern;

			[Key(1)]
			public List<int> playerPositions;

			[Key(2)]
			public string multiPlayKey;
		}

		[Key(0)]
		public List<ActorData> elements;

		[Key(1)]
		public BRInitData brInitData;
	}
}
