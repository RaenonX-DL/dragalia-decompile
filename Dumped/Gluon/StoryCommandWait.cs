using System.Collections;

namespace Gluon
{
	[CommandName("wait")]
	public class StoryCommandWait : IStoryCommand
	{
		private IEnumerator coroutine;

		private float sec;

		public void Start(float sec)
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
