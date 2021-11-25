using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi
{
	[StructLayout(3, Size = 4)]
	public enum ResponseStatus
	{
		Success = 1,
		SuccessWithStale = 2,
		LicenseCheckFailed = -1,
		InternalError = -2,
		NotAuthorized = -3,
		VersionUpdateRequired = -4,
		Timeout = -5,
		ResolutionRequired = -6
	}
}
