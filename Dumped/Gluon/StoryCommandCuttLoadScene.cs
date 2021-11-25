using System.Collections;
using Cute.AssetBundle;

namespace Gluon
{
	[CommandName("cutt_loadscene")]
	public class StoryCommandCuttLoadScene : IStoryCommand
	{
		private IEnumerator coroutine;

		private DungeonManager dungeonManager;

		private DownloadOperation downloadOperation;

		public void Start(int questDataId, int areaIndex)
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
