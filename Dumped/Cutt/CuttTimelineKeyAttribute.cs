using System;

namespace Cutt
{
	[Flags]
	public enum CuttTimelineKeyAttribute
	{
		Disable = 0x1,
		CameraDelayEnable = 0x2,
		CameraDelayInherit = 0x4,
		KeyCommonBitMask = 0xFFFF
	}
}
