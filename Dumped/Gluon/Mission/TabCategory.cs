using System.Runtime.InteropServices;

namespace Gluon.Mission
{
	[StructLayout(3, Size = 4)]
	public enum TabCategory
	{
		Daily,
		Period,
		Normal,
		Special,
		Drill,
		Max
	}
}
