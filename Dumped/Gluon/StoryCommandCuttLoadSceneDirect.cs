using System.Collections;
using Cute.AssetBundle;

namespace Gluon
{
	[CommandName("cutt_loadscene_direct")]
	public class StoryCommandCuttLoadSceneDirect : IStoryCommand
	{
		private IEnumerator coroutine;

		private DungeonManager dungeonManager;

		private DownloadOperation downloadOperation;

		public void Start(string scenePath0, string scenePath1, string scenePath2, string areaName)
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		private IEnumerator _Update()
		{
			return null;
		}
	}
}
