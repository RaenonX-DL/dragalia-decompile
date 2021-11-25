using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestPlayModeType
	{
		NONE,
		NORMAL,
		SOLO,
		MULTI,
		RANDOM_MATCHING,
		RANDOM_MATCHING_SIXTEEN
	}
}
