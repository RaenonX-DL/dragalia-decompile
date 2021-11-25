using System.Collections;

namespace Gluon
{
	[CommandName("next_page")]
	public class StoryCommandNextPage : IStoryCommand
	{
		private IEnumerator coroutine;

		private float waitTime;

		private bool isNoNeedTouch;

		public void Start(float waitTime = 0.3f)
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
