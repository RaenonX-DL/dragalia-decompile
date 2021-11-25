using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum SellListType
	{
		None,
		Chara,
		Weapon,
		Amulet,
		Dragon
	}
}
