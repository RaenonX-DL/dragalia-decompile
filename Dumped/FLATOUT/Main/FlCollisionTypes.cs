using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlCollisionTypes
	{
		None,
		Square,
		Circle,
		Square2D,
		Circle2D
	}
}
