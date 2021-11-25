using System.Runtime.InteropServices;

namespace CriMana
{
	[StructLayout(3, Size = 4)]
	public enum AlphaType
	{
		CompoOpaq,
		CompoAlphaFull,
		CompoAlpha3Step,
		CompoAlpha32Bit
	}
}
