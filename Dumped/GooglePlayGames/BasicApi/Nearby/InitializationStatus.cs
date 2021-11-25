using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout(3, Size = 4)]
	public enum InitializationStatus
	{
		Success,
		VersionUpdateRequired,
		InternalError
	}
}
