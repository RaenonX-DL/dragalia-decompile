using System.Runtime.InteropServices;

namespace Gluon.Mission
{
	[StructLayout(3, Size = 4)]
	public enum Dependency
	{
		OneShot,
		Derivative,
		Cumulative
	}
}
