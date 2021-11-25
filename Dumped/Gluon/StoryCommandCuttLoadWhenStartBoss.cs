using System.Collections;

namespace Gluon
{
	[CommandName("cut_load_start_boss")]
	public class StoryCommandCuttLoadWhenStartBoss : IStoryCommand
	{
		private IEnumerator coroutine;

		public void Start(string cuttName)
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
