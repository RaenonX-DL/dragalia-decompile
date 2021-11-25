using System.Collections;

namespace Gluon
{
	[CommandName("cutt_load_story")]
	public class StoryCommandCuttLoadStory : IStoryCommand
	{
		private IEnumerator coroutine;

		private static CuttDriverInStory cuttDriver;

		public static void ReleaseCuttStory()
		{
		}

		public void Start(string cuttName, int type)
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

		public static CuttDriverInGame GetCuttDriver()
		{
			return null;
		}

		public string[] GetResourceNames(string cuttName, int type)
		{
			return null;
		}
	}
}
