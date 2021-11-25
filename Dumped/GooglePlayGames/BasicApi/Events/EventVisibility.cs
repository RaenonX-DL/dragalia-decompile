using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Events
{
	[StructLayout(3, Size = 4)]
	public enum EventVisibility
	{
		Hidden = 1,
		Revealed
	}
}
