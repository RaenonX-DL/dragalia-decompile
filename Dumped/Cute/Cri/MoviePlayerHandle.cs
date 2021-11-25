using System.Runtime.CompilerServices;

namespace Cute.Cri
{
	public struct MoviePlayerHandle
	{
		public const uint InvalidId = 0u;

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

		public bool IsInvalidId => default(bool);

		private MoviePlayerHandle(uint playerId)
		{
		}

		public static MoviePlayerHandle CreateMoviePlayerHandle()
		{
			return default(MoviePlayerHandle);
		}
	}
}
