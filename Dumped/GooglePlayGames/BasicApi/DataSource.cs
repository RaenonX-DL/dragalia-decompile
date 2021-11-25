using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi
{
	[StructLayout(3, Size = 4)]
	public enum DataSource
	{
		ReadCacheOrNetwork,
		ReadNetworkOnly
	}
}
