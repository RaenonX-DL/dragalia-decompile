using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi
{
	[StructLayout(3, Size = 4)]
	public enum Gravity
	{
		TOP = 48,
		BOTTOM = 80,
		LEFT = 3,
		RIGHT = 5,
		CENTER_HORIZONTAL = 1
	}
}
