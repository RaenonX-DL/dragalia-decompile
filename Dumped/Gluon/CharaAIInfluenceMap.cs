using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CharaAIInfluenceMap
	{
		BASIC_FORMATION,
		MINE,
		ATTACK,
		HEAL,
		AVOID_MARKER
	}
}
