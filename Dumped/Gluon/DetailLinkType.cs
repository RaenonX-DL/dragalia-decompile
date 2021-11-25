using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum DetailLinkType
	{
		NONE,
		GET_QUEST,
		GET_TEXT,
		TRADE
	}
}
