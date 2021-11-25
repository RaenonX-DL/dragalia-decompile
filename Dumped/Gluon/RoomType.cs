using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum RoomType
	{
		Normal = 1,
		Conditional = 2,
		Undefined = -1
	}
}
