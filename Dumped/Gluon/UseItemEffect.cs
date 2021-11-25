using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum UseItemEffect
	{
		NULL = 0,
		RECOVER_STAMINA = 1006,
		RECOVER_MULTI = 1007,
		QUEST_SKIP = 1008
	}
}
