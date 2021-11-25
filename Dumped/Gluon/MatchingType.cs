using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum MatchingType
	{
		Anyone = 1,
		ById = 2,
		ByLocation = 4,
		Guild = 5,
		NoDisplay = 6,
		Undefined = -1
	}
}
