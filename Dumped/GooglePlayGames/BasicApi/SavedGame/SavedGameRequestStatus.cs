using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[StructLayout(3, Size = 4)]
	public enum SavedGameRequestStatus
	{
		Success = 1,
		TimeoutError = -1,
		InternalError = -2,
		AuthenticationError = -3,
		BadInputError = -4
	}
}
