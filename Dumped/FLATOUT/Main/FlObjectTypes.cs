using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlObjectTypes
	{
		Motion,
		Object,
		Plane,
		Text,
		Mask,
		AlphaMask,
		StencilMask,
		StencilAlphaMask,
		Opaque,
		ObjectMask,
		ObjectAlphaMask
	}
}
