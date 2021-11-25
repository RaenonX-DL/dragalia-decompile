using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum FortMenuGroupType
	{
		NONE,
		MENU_PRODUCE,
		MENU_CHARA,
		MENU_DRAGON,
		MENU_OTHER
	}
}
