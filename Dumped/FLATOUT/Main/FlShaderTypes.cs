using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlShaderTypes
	{
		Normal,
		Add,
		Sub,
		Multiply,
		HardLight,
		Invert,
		Opaque,
		Mask,
		AlphaMask,
		Grayscale,
		StencilMask,
		StencilAlphaMask,
		ObjectMask,
		ObjectAlphaMask,
		Normal3D,
		Add3D,
		NormalBlur,
		AddBlur,
		MultiplyBlur,
		GrayscaleBlur
	}
}
