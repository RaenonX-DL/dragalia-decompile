using System;
using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	[Flags]
	public enum CuttTimelineKeyAttribute
	{
		Disable = 0x1,
		CameraDelayEnable = 0x2,
		CameraDelayInherit = 0x4,
		KeyCommonBitMask = 0xFFFF
	}
}
