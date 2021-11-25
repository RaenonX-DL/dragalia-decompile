using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum LibraryCameraSetting
	{
		Camera1 = 1,
		Camera2,
		Camera3,
		Camera4,
		Camera5
	}
}
