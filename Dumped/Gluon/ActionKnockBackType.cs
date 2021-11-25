using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ActionKnockBackType
	{
		NONE,
		NORMAL,
		RANDOM,
		SLIDE,
		ABSORPT,
		EVICTION,
		REPULSION,
		ABSORPT_EA,
		REPULSION_EA,
		ABSORPT_AERIAL,
		REPULSION_AERIAL
	}
}
