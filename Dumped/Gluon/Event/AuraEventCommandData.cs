using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct AuraEventCommandData
	{
		[Required]
		[Key(0)]
		public CharacterId to;

		[Required]
		[Key(1)]
		public AuraEventCommandType commandType;

		[Key(2)]
		public int multiPlayKey;

		[Key(3)]
		public int auraId;

		[Key(4)]
		public int auraType;

		[Key(5)]
		public int targetType;

		[Key(6)]
		public int level;

		[Key(7)]
		public float rate;

		[Key(8)]
		public float duration;

		[Key(9)]
		public CharacterId from;

		[Key(10)]
		public int actionId;

		[Key(11)]
		public int skillId;

		[Key(12)]
		public int productId;

		[Key(13)]
		public int publishLevel;

		[Key(14)]
		public Dictionary<int, int> maxLimitLevelDict;

		[Key(15)]
		public RemoveBuffReason reason;

		[Key(16)]
		public bool durationUpdate;

		[Key(17)]
		public bool hideCaption;
	}
}
