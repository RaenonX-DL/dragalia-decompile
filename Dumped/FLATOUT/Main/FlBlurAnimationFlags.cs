using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlBlurAnimationFlags
	{
		Blur = 1,
		BlurX = 2,
		BlurY = 4
	}
}
