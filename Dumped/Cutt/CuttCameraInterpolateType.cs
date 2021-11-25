using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	public enum CuttCameraInterpolateType
	{
		None,
		Linear,
		Curve,
		Ease
	}
}
