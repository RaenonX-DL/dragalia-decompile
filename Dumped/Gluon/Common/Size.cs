using System;
using System.Runtime.InteropServices;

namespace Gluon.Common
{
	[Serializable]
	[StructLayout(0, Size = 8)]
	public struct Size
	{
		public int width;

		public int height;

		public Size(int w, int h)
		{
		}
	}
}
