using System.Collections;

namespace Gluon
{
	[CommandName("set_BG_effect")]
	public class StoryCommandSetBackgroundEffect : IStoryCommand
	{
		private IEnumerator coroutine;

		private string[] effectIds;

		public void Start(string[] effectIds)
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

		private void SetBackgroundEffect(string[] effectIds)
		{
		}

		public string[] GetResourceNames(string[] effectIds)
		{
			return null;
		}
	}
}
