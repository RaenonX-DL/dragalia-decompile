using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[StructLayout(3, Size = 8)]
	public delegate void ConflictCallback(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData);
}
