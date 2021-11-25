using System.Collections.Generic;

namespace Gluon
{
	public class MyPageSeasonSkitMapList
	{
		public class SceneInfo
		{
			public string mapName;

			public string sceneName;

			public int[] characterIds;

			public SceneInfo(string mapName, string sceneName)
			{
			}
		}

		private static MyPageSeasonSkitMapList _instance;

		public List<SceneInfo> sceneInfoList;

		private const int numOfScene = 21;

		public static MyPageSeasonSkitMapList instance => null;

		public static void DeleteInstance()
		{
		}

		private MyPageSeasonSkitMapList()
		{
		}

		public int GetSceneCount()
		{
			return default(int);
		}
	}
}
