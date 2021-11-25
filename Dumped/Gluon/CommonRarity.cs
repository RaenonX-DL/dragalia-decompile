using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CommonRarity
	{
		None,
		Rarity_1,
		N,
		R,
		SR,
		SSR
	}
}
