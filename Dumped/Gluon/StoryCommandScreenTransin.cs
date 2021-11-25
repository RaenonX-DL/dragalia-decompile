using System.Collections;

namespace Gluon
{
	[CommandName("screen_transin")]
	public class StoryCommandScreenTransin : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool visible;

		private int type;

		private float sec;

		public void Start(int type, float sec)
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
