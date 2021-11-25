using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestClearStatusType
	{
		LOCKED,
		NEW,
		CLEAR,
		SECRET,
		COMPLETE
	}
}
