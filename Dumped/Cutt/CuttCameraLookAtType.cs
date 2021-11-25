using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	public enum CuttCameraLookAtType
	{
		Character,
		Locator,
		Rotation
	}
}
