using System.Runtime.InteropServices;

namespace Gluon.GraphicParameter
{
	[StructLayout(3, Size = 4)]
	public enum AntiAliasingLabel
	{
		None,
		MSAAx2,
		MSAAx4,
		MSAAx8
	}
}
