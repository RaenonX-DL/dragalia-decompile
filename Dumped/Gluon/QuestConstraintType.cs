using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestConstraintType
	{
		NONE,
		NONE_SUPPORT,
		NONE_MULTI,
		NONE_SUPPORT_AND_MULTI
	}
}
