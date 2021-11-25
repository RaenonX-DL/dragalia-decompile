using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ActionMarker
	{
		NONE = 0,
		AM_GMK015_BOMB = 50,
		AM_GMK008_01_001 = 51,
		AM_GMK006_01_000 = 52,
		AM_GMK018_01_000 = 54,
		AM_GMK018_02_001 = 55,
		AM_GMK020_01_000 = 56,
		AM_GMK020_02_001 = 57,
		AM_GMK021_01_000 = 58,
		AM_GMK021_02_001 = 59,
		AM_GMK019_01_000 = 60,
		AM_GMK019_02_001 = 61,
		AM_GMK011_01_001 = 0x40,
		AM_GMK022_01_000 = 65,
		AM_GMK117_01_000 = 66,
		AM_GMK117_02_001 = 67,
		AM_GMK008_01_002 = 68,
		AM_C001_00_00 = 50010000,
		AM_C004_00_00 = 50040000,
		AM_C005_00_00 = 50050000,
		AM_C006_00_00 = 50060000,
		AM_C007_00_00 = 50070000
	}
}
