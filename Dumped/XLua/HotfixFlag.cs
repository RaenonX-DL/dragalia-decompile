using System;
using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 4)]
	[Flags]
	public enum HotfixFlag
	{
		Stateless = 0x0,
		[Obsolete]
		Stateful = 0x1,
		ValueTypeBoxing = 0x2,
		IgnoreProperty = 0x4,
		IgnoreNotPublic = 0x8,
		Inline = 0x10,
		IntKey = 0x20,
		AdaptByDelegate = 0x40,
		IgnoreCompilerGenerated = 0x80,
		NoBaseProxy = 0x100
	}
}
