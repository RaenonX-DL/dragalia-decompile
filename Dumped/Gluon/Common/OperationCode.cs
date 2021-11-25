using System.Runtime.InteropServices;

namespace Gluon.Common
{
	[StructLayout(3, Size = 1)]
	public enum OperationCode : byte
	{
		Join = byte.MaxValue,
		AuthenticateOnce = 231,
		Authenticate = 230,
		JoinLobby = 229,
		LeaveLobby = 228,
		CreateGame = 227,
		JoinGame = 226,
		JoinRandomGame = 225,
		Leave = 254,
		RaiseEvent = 253,
		SetProperties = 252,
		GetProperties = 251,
		ChangeGroups = 248,
		FindFriends = 222,
		GetLobbyStats = 221,
		GetRegions = 220,
		WebRpc = 219,
		ServerSettings = 218
	}
}
