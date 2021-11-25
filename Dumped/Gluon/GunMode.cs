using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum GunMode
	{
		None,
		Rifle,
		Shotgun,
		Machinegun
	}
}
