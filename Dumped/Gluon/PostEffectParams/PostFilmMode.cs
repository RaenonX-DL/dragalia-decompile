using System.Runtime.InteropServices;

namespace Gluon.PostEffectParams
{
	[StructLayout(3, Size = 4)]
	public enum PostFilmMode
	{
		None,
		Lerp,
		Add,
		Mul,
		VignetteLerp,
		VignetteAdd,
		VignetteMul
	}
}
