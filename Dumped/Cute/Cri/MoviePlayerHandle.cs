using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Cute.Cri
{
	[StructLayout(0, Size = 4)]
	public struct MoviePlayerHandle
	{
		public uint PlayerId
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MoviePlayerHandle(uint playerId)
		{
		}
	}
}
