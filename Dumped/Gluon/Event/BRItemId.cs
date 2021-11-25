using Gluon.Dungeon;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct BRItemId
	{
		public enum BRItemCreateType : byte
		{
			None,
			Field,
			PlayerDead,
			EnemyDead,
			Gimmick
		}

		public static readonly BRItemId None;

		[Key(0)]
		public BRItemCreateType type;

		[Key(1)]
		public uint value;

		public bool IsSame(BRItemId id)
		{
			return default(bool);
		}

		public static BRItemId FromField(int index)
		{
			return default(BRItemId);
		}

		public static BRItemId FromPlayerCharacter(PlayerCharacter chara, int index)
		{
			return default(BRItemId);
		}

		public static BRItemId FromEnemyCharacter(EnemyCharacter chara, int index)
		{
			return default(BRItemId);
		}

		public static BRItemId FromDungeonGimmick(DungeonObjectStatus gimmick)
		{
			return default(BRItemId);
		}
	}
}
