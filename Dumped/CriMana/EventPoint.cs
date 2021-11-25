using System;
using System.Runtime.InteropServices;

namespace CriMana
{
	[StructLayout(0, Size = 56)]
	public struct EventPoint
	{
		public IntPtr cueName;

		public uint cueNameSize;

		public ulong time;

		public ulong tunit;

		public int type;

		public IntPtr paramString;

		public uint paramStringSize;

		public uint cntCallback;
	}
}
