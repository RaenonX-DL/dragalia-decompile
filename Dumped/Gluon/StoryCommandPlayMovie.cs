using System.Collections;

namespace Gluon
{
	[CommandName("play_movie")]
	public class StoryCommandPlayMovie : IStoryCommand
	{
		private IEnumerator coroutine;

		private string fileName;

		private bool isPanScan;

		private const string storyMoviePathFormat = "Story/{0}";

		public void Start(string fileName, bool isPanScan = false)
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

		public string[] GetResourceNames(string fileName, bool isPanScan = false)
		{
			return null;
		}
	}
}
