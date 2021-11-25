using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi
{
	[StructLayout(3, Size = 4)]
	public enum SignInStatus
	{
		Success,
		UiSignInRequired,
		DeveloperError,
		NetworkError,
		InternalError,
		Canceled,
		AlreadyInProgress,
		Failed,
		NotAuthenticated
	}
}
