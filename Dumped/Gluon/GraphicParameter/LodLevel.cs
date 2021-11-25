using System.Runtime.InteropServices;

namespace Gluon.GraphicParameter
{
	[StructLayout(3, Size = 4)]
	public enum LodLevel
	{
		Low3 = -3,
		Low2 = -2,
		Low1 = -1,
		Default = 0,
		High1 = 1,
		High2 = 2,
		AlwaysVisible = -100,
		NeverDisplay = 100
	}
}
