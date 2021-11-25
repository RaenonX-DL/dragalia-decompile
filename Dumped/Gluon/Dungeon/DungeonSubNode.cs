using System.Runtime.InteropServices;

namespace Gluon.Dungeon
{
	[StructLayout(3, Size = 4)]
	public enum DungeonSubNode
	{
		Map,
		StopObject,
		Lightmap,
		Drop,
		Gimmick,
		Other,
		EnemyGenerator,
		EnemyWall,
		EnemyTrigger,
		MaxNum
	}
}
