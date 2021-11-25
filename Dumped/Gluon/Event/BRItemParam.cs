using System.Runtime.InteropServices;
using MessagePack;

namespace Gluon.Event
{
	[StructLayout(0, Size = 12)]
	[MessagePackObject(false)]
	public struct BRItemParam
	{
		[Key(0)]
		public BRItemId id;

		[Key(1)]
		public BattleRoyalDungeonItem type;
	}
}
