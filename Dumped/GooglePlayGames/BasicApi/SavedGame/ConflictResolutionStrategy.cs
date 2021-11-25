using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[StructLayout(3, Size = 4)]
	public enum ConflictResolutionStrategy
	{
		UseLongestPlaytime,
		UseOriginal,
		UseUnmerged,
		UseManual,
		UseLastKnownGood,
		UseMostRecentlySaved
	}
}
