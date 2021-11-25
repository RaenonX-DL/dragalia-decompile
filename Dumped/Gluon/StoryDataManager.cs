namespace Gluon
{
	public class StoryDataManager
	{
		public enum UnitGroupType
		{
			None,
			Chara,
			Dragon
		}

		private const string questMainPath = "Story/QuestStory/Main/";

		private const string questEventPath = "Story/QuestStory/Event/";

		private const string unitCharaPath = "Story/UnitStory/Chara/";

		private const string unitDragonPath = "Story/UnitStory/Dragon/";

		private const string castlePath = "Story/CastleStory/";

		private const string tutorialPath = "Story/tutorial/";

		private const string albumPath = "Story/AlbumPicture/";

		private static readonly string[] commonScriptNames;

		public static string scriptPath;

		public static string nextScene;

		public static bool isSampleStory;

		public static string GetQuestScriptPath(QuestGroupType type, string fileName = "")
		{
			return null;
		}

		public static string GetUnitScriptPath(UnitGroupType type, string fileName = "")
		{
			return null;
		}

		public static string GetCastleScriptPath(string fileName = "")
		{
			return null;
		}

		public static string GetTutorialScriptPath(string fileName = "")
		{
			return null;
		}

		public static string GetAlbumScriptPath(string fileName = "")
		{
			return null;
		}

		public static StoryScript LoadStoryScript(string filePath)
		{
			return null;
		}

		public static BaseScript LoadCommonStoryScript()
		{
			return null;
		}

		public static bool IsCommonScript(string path)
		{
			return default(bool);
		}
	}
}
