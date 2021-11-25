using System.Collections;

namespace Gluon
{
	[CommandName("topic")]
	public class StoryCommandTopic : IStoryCommand
	{
		private IEnumerator coroutine;

		private string fileName;

		private float fadeTime;

		private bool visible;

		public void Start(string fileName, float fadeTime = 1f)
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
