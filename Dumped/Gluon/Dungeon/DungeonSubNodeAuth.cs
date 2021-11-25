using System.Runtime.InteropServices;

namespace Gluon.Dungeon
{
	[StructLayout(3, Size = 4)]
	public enum DungeonSubNodeAuth
	{
		Quests,
		BG,
		MaxNum
	}
}
