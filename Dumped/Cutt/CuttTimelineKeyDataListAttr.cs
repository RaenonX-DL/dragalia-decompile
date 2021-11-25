using System;
using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	[Flags]
	public enum CuttTimelineKeyDataListAttr
	{
		Disable = 0x1
	}
}
