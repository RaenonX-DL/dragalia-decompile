using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlTextMeshFlags
	{
		Normal = 1,
		Shadow = 2,
		Outline = 4
	}
}
