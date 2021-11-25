using System.Collections.Generic;

namespace Gluon
{
	public class MyPageSeasonMoveMapList
	{
		public class SceneInfo
		{
			public string mapName;

			public string sceneName;

			public string bgName;

			public MyPageTransitionController.MoveMapType mapType;

			public MyPageTransitionController.DayTimeType dayTimeType;

			public int fortLevel;

			public bool isRunning;

			public int[] characterIds;

			public SceneInfo(string mapName, string sceneName, string bgName, MyPageTransitionController.MoveMapType mapType, MyPageTransitionController.DayTimeType dayTimeType, int fortLevel, bool isRunning)
			{
			}
		}

		private const int numOfScene = 21;

		private static MyPageSeasonMoveMapList _instance;

		public List<SceneInfo> sceneInfoList;

		public static MyPageSeasonMoveMapList instance => null;

		public static void DeleteInstance()
		{
		}

		private MyPageSeasonMoveMapList()
		{
		}

		public int GetSceneCount()
		{
			return default(int);
		}
	}
}
