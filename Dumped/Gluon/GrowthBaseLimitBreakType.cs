using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum GrowthBaseLimitBreakType
	{
		None,
		Target,
		NeedMaterial,
		Max,
		NotReleaseRank5
	}
}
