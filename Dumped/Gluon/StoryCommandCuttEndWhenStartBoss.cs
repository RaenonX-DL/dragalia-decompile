using System.Collections;

namespace Gluon
{
	[CommandName("cutt_end_start_boss")]
	public class StoryCommandCuttEndWhenStartBoss : IStoryCommand
	{
		private IEnumerator coroutine;

		public void Start()
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
